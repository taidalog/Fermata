// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

open System

[<RequireQualifiedAccess>]
module Int32 =
    let validate (value: string) : Result<int, exn> =
        if value = String.Empty then
            Error(Exceptions.EmptyString "Value cannot be empty string.")
        else
            try
                Ok(Int32.Parse value)
            with
            | :? System.ArgumentNullException as e -> Error(Exceptions.ArgumentNull e.Message)
            | :? System.FormatException as e -> Error(Exceptions.Format e.Message)
            | :? System.OverflowException as e -> Error(Exceptions.Overflow e.Message)
            | _ as e -> Error(Exceptions.Unknown e.Message)
