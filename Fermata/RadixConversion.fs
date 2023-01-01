namespace Fermata

module RadixConversion =

    [<RequireQualifiedAccess>]
    module Dec =
        let validate (input : string) : bool =
            System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9]+$")
        
        let toBin (input : int) : string =
            System.Convert.ToString(input, 2)
        
        let tryToBin (input : string) : string option =
            match input |> validate with
            | true -> input |> int |> toBin |> Some
            | false -> None
        
        let toHex (input : int) : string =
            System.Convert.ToString(input, 16)
        
        let tryToHex (input : string) : string option =
            match input |> validate with
            | true -> input |> int |> toHex |> Some
            | false -> None
    

    [<RequireQualifiedAccess>]
    module Bin =
        let validate (input : string) : bool =
            System.Text.RegularExpressions.Regex.IsMatch(input, "^[01]+$")
        
        let toDec (input : string) : int =
            System.Convert.ToInt32(input, 2)
        
        let tryToDec (input : string) : int option=
            match input |> validate with
            | true -> input |> toDec |> Some
            | false -> None
    

    [<RequireQualifiedAccess>]
    module Hex =
        let validate (input : string) : bool =
            System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9A-Fa-f]+$")
        
        let toDec (input : string) : int =
            System.Convert.ToInt32(input, 16)
        
        let tryToDec (input : string) : int option =
            match input |> validate with
            | true -> input |> toDec |> Some
            | false -> None
