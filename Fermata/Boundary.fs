namespace Fermata

module Boundary =
    let inline clampGap (min : ^a) (max:  ^a) (value:  ^a) : (^a * ^a)  =
        if value < min then
            (min, value - min)
        else if max < value then
            (max, value - max)
        else
            (value, LanguagePrimitives.GenericZero<'a>)
