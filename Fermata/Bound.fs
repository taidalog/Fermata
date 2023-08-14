// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

module Bound =
    let inline clampGap (lower: ^a) (upper: ^a) (value: ^a) : (^a * ^a) =
        if value < lower then (lower, value - lower)
        else if upper < value then (upper, value - upper)
        else (value, LanguagePrimitives.GenericZero<'a>)

    let inline clamp (lower: ^a) (upper: ^a) (value: ^a) : ^a =
        if value < lower then lower
        else if value > upper then upper
        else value

    let inline gap (lower: ^a) (upper: ^a) (value: ^a) : ^a =
        if value < lower then value - lower
        else if value > upper then value - upper
        else LanguagePrimitives.GenericZero<'a>

    let inline between (lower: ^a) (upper: ^a) (value: ^a) : bool = value >= lower && value <= upper

    let inline within (center: ^a) (distance: ^a) (value: ^a) : bool =
        between (center - distance) (center + distance) value

    let inline rebound (lower: ^a) (upper: ^a) (value: ^a) : ^a =
        let rec loop (lower: ^a) (upper: ^a) (value: ^a) : ^a =
            let (clamp: ^a), (gap: ^a) = clampGap lower upper value
            let zero: ^a = LanguagePrimitives.GenericZero

            match gap with
            | (var: ^a) when var = zero -> clamp
            | _ ->
                let value': ^a = if gap > zero then upper - gap else lower - gap
                loop lower upper value'

        loop lower upper value

    let inline warp (lower: ^a) (upper: ^a) (value: ^a) : ^a =
        let rec loop (lower: ^a) (upper: ^a) (value: ^a) : ^a =
            let (clamp: ^a), (gap: ^a) = clampGap lower upper value
            let zero: ^a = LanguagePrimitives.GenericZero

            match gap with
            | (var: ^a) when var = zero -> clamp
            | _ ->
                let value': ^a = if gap > zero then lower + gap else upper + gap
                loop lower upper value'

        loop lower upper value
