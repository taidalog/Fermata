namespace Fermata

open Validators

module RadixConversion =
    type Dec = Dec of int
    type Bin = Bin of string
    type Hex = Hex of string
    type Arb = Arb of radix: int * symbols: seq<char> * value: string

    [<RequireQualifiedAccess>]
    module Dec =
        let validate (input: string) : Result<Dec, exn> =
            input |> Int32.validate |> Result.map Dec

        let toBin (dec: Dec) : Bin =
            dec |> fun (Dec d) -> System.Convert.ToString(d, 2) |> Bin

        let toHex (dec: Dec) : Hex =
            dec |> fun (Dec d) -> System.Convert.ToString(d, 16) |> Hex

    [<RequireQualifiedAccess>]
    module Bin =
        let validate (input: string) : Result<Bin, exn> =
            Ok input
            |> Result.bind validateNotEmptyString
            |> Result.bind (validateFormat "^[01]+$")
            |> Result.bind (validateMaxLength String.length 32)
            |> Result.map Bin

        let toDec (bin: Bin) : Dec =
            bin |> fun (Bin b) -> System.Convert.ToInt32(b, 2) |> Dec

    [<RequireQualifiedAccess>]
    module Hex =
        let validate (input: string) : Result<Hex, exn> =
            Ok input
            |> Result.bind validateNotEmptyString
            |> Result.bind (validateFormat "^[0-9A-Fa-f]+$")
            |> Result.bind (validateMaxLength String.length 8)
            |> Result.map Hex

        let toDec (hex: Hex) : Dec =
            hex |> fun (Hex h) -> System.Convert.ToInt32(h, 16) |> Dec

    [<RequireQualifiedAccess>]
    module Arb =
        let rec private divideTill (number: int) (dividend: int) (divisor: int) (acc: int list) : int list =
            let quotient, remainder = System.Math.DivRem(dividend, divisor)
            let acc' = remainder :: acc

            if quotient = 0 then acc'
            else if quotient < number then quotient :: acc'
            else divideTill number quotient divisor acc'

        let ofInt (radix: int) (symbols: seq<char>) (number: int) : Result<Arb, exn> =
            if radix = 1 then
                Error(Exceptions.Argument "Radix must be greater than 1.")
            else if Seq.isEmpty symbols then
                Error(Exceptions.Argument "Symbols were not specified.")
            else if Seq.length symbols <> radix then
                Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")
            else
                divideTill radix number radix []
                |> List.map (fun x -> Seq.item x symbols |> string)
                |> String.concat ""
                |> fun x -> Ok(Arb(radix, symbols, x))

        let toInt (arb: Arb) : Result<int, exn> =
            let (Arb(radix, symbols, value)) = arb

            if radix = 1 then
                Error(Exceptions.Argument "Radix must be greater than 1.")
            else if Seq.isEmpty symbols then
                Error(Exceptions.Argument "Symbols were not specified.")
            else if Seq.length symbols <> radix then
                Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")
            else
                try
                    let weights = List.init (String.length value) ((pown) radix) |> List.rev

                    let indexes =
                        value |> Seq.map (fun x -> Seq.findIndex ((=) x) symbols) |> Seq.toList

                    List.zip weights indexes
                    |> List.map (fun (x, y) -> x * y)
                    |> List.fold (+) 0
                    |> Ok
                with
                | :? System.OverflowException as e -> Error(Exceptions.Overflow e.Message)
                | _ as e -> Error(Exceptions.Unknown e.Message)
