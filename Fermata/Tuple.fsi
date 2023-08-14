// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Tuple =

    val map: mapping: ('a -> 'b) -> x: 'a * y: 'a -> 'b * 'b

    val map3: mapping: ('a -> 'b) -> x: 'a * y: 'a * z: 'a -> 'b * 'b * 'b

    val map4: mapping: ('a -> 'b) -> x1: 'a * x2: 'a * x3: 'a * x4: 'a -> 'b * 'b * 'b * 'b

    val mapWith: mapping1: ('a -> 'b) * mapping2: ('c -> 'd) -> x: 'a * y: 'c -> 'b * 'd

    val mapWith3:
        mapping1: ('a -> 'b) * mapping2: ('c -> 'd) * mapping3: ('e -> 'f) -> x: 'a * y: 'c * z: 'e -> 'b * 'd * 'f

    val mapWith4:
        mapping1: ('a -> 'b) * mapping2: ('c -> 'd) * mapping3: ('e -> 'f) * mapping4: ('g -> 'h) ->
            x1: 'a * x2: 'c * x3: 'e * x4: 'g ->
                'b * 'd * 'f * 'h
