namespace Fermata

open Validators

module RadixConversion =

    [<RequireQualifiedAccess>]
    module Dec =
        let validate (input : string) : Result<int,Fermata.Errors.Errors> =
            Ok input
            |> Result.bind validateNotEmptyString
            |> Result.bind (validateFormat "^[0-9]+$")
            |> Result.map int
        
        let isValid (input : string) : bool =
            input
            |> validate
            |> (function | Ok _ -> true | Error _ -> false)
        
        let toBin (input : int) : string =
            System.Convert.ToString(input, 2)
        
        let tryToBin (input : string) : string option =
            match input |> isValid with
            | true -> input |> int |> toBin |> Some
            | false -> None
        
        let toHex (input : int) : string =
            System.Convert.ToString(input, 16)
        
        let tryToHex (input : string) : string option =
            match input |> isValid with
            | true -> input |> int |> toHex |> Some
            | false -> None
    

    [<RequireQualifiedAccess>]
    module Bin =
        let validate (input : string) : Result<string,Fermata.Errors.Errors> =
            Ok input
            |> Result.bind validateNotEmptyString
            |> Result.bind (validateFormat "^[01]+$")
        
        let isValid (input : string) : bool =
            input
            |> validate
            |> (function | Ok _ -> true | Error _ -> false)
        
        let toDec (input : string) : int =
            System.Convert.ToInt32(input, 2)
        
        let tryToDec (input : string) : int option=
            match input |> isValid with
            | true -> input |> toDec |> Some
            | false -> None
    

    [<RequireQualifiedAccess>]
    module Hex =
        let validate (input : string) : Result<string,Fermata.Errors.Errors> =
            Ok input
            |> Result.bind validateNotEmptyString
            |> Result.bind (validateFormat "^[0-9A-Fa-f]+$")
        
        let isValid (input : string) : bool =
            input
            |> validate
            |> (function | Ok _ -> true | Error _ -> false)
        
        let toDec (input : string) : int =
            System.Convert.ToInt32(input, 16)
        
        let tryToDec (input : string) : int option =
            match input |> isValid with
            | true -> input |> toDec |> Some
            | false -> None
