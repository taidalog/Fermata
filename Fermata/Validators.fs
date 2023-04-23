namespace Fermata

open System
open System.Text.RegularExpressions

module Validators =
    let validateNotNullOrEmpty (input: string) : Result<string,Fermata.Errors.Errors<string>> =
        match String.IsNullOrEmpty input with
        | true -> Error (Errors.NullOrEmpty input)
        | false -> Ok input
    
    let validateNotEmptyString (input: string) : Result<string,Fermata.Errors.Errors<string>> =
        match input with
        | "" -> Error (Errors.EmptyString input)
        | _ -> Ok input
    
    let validateFormat (pattern: string) (input: string) : Result<string,Fermata.Errors.Errors<string>> =
        match Regex.IsMatch(input, pattern) with
        | true -> Ok input
        | false -> Error (Errors.WrongFormat input)
    
    let validateRange (min: 'T) (max: 'T) (input: 'T) : Result<'T,Fermata.Errors.Errors<'T>> =
        match input >= min && input <= max with
        | true -> Ok input
        | false -> Error (Errors.OutOfRange input)
