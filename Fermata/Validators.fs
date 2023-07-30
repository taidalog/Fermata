namespace Fermata

open System
open System.Text.RegularExpressions

module Validators =
    let validateNotNullOrEmpty (input: string) : Result<string, Fermata.Errors.Errors> =
        match String.IsNullOrEmpty input with
        | true -> Error Errors.NullOrEmpty
        | false -> Ok input

    let validateNotEmptyString (input: string) : Result<string, Fermata.Errors.Errors> =
        match input with
        | "" -> Error Errors.EmptyString
        | _ -> Ok input

    let validateFormat (pattern: string) (input: string) : Result<string, Fermata.Errors.Errors> =
        match Regex.IsMatch(input, pattern) with
        | true -> Ok input
        | false -> Error Errors.WrongFormat

    let validateRange (min: 'T) (max: 'T) (input: 'T) : Result<'T, Fermata.Errors.Errors> =
        match input >= min && input <= max with
        | true -> Ok input
        | false -> Error Errors.OutOfRange
