// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Tuple =
    let map mapping (x, y) = mapping x, mapping y

    let map3 mapping (x, y, z) = mapping x, mapping y, mapping z

    let map4 mapping (x1, x2, x3, x4) =
        mapping x1, mapping x2, mapping x3, mapping x4

    let mapWith (mapping1, mapping2) (x, y) = mapping1 x, mapping2 y

    let mapWith3 (mapping1, mapping2, mapping3) (x, y, z) = mapping1 x, mapping2 y, mapping3 z

    let mapWith4 (mapping1, mapping2, mapping3, mapping4) (x1, x2, x3, x4) =
        mapping1 x1, mapping2 x2, mapping3 x3, mapping4 x4
