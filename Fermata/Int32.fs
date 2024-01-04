// Fermata Version 1.0.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

open System

[<RequireQualifiedAccess>]
module Int32 =
    let validate (value: string) : Result<int, exn> =
        try
            Ok(Int32.Parse value)
        with
        | :? System.ArgumentNullException -> Error(ArgumentNullException())
        | :? System.FormatException ->
            Error(FormatException $"The input string '%s{value}' was not in a correct format.")
        | :? System.OverflowException ->
            Error(OverflowException "Value was either too large or too small for an Int32.")
        | _ as e -> Error(ArgumentException e.Message)
