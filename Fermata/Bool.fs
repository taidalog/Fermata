// Fermata Version 1.0.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Bool =
    let toInt (b: bool) : int =
        match b with
        | true -> 1
        | false -> 0

    let ofInt (i: int) : bool = i <> 0
