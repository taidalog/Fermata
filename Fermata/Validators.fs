// Fermata Version 0.7.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

open System
open System.Text.RegularExpressions

module Validators =
    let validateNotNullOrEmpty (input: string) : Result<string, exn> =
        match String.IsNullOrEmpty input with
        | true -> Error(Exceptions.ArgumentNull "Value cannot be null.")
        | false -> Ok input

    let validateNotEmptyString (input: string) : Result<string, exn> =
        match input with
        | "" -> Error(Exceptions.EmptyString "Value cannot be empty string.")
        | _ -> Ok input

    let validateFormat (pattern: string) (input: string) : Result<string, exn> =
        match Regex.IsMatch(input, pattern) with
        | true -> Ok input
        | false -> Error(Exceptions.Format $"The input string '%s{input}' was not in a correct format.")

    let validateRange (min: 'T) (max: 'T) (input: 'T) : Result<'T, exn> =
        match input >= min && input <= max with
        | true -> Ok input
        | false -> Error(Exceptions.OutOfRange $"%A{input} is out of range. Value must be within %A{min} and %A{max}")

    let validateMaxLength (measurer: 'T -> int) (max: int) (value: 'T) : Result<'T, exn> =
        if measurer value > max then
            Error(Exceptions.Overflow $"Value is too long. Value must be shorter or equal to %d{max}")
        else
            Ok value
