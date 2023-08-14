// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Result =
    let ofOption (error: 'Error) (option: 'T option) : Result<'T, 'Error> =
        match option with
        | Some s -> Ok s
        | None -> Error error
