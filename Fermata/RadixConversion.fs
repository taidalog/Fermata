namespace Fermata

open Validators

module RadixConversion =
    type Dec = Dec of int
    type Bin = Bin of string
    type Hex = Hex of string

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
