// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

open System.Text.RegularExpressions

[<RequireQualifiedAccess>]
module Regex =
    let match' (pattern: string) (input: string) : System.Text.RegularExpressions.Match = Regex.Match(input, pattern)

    let matches (pattern: string) (input: string) : System.Text.RegularExpressions.MatchCollection =
        Regex.Matches(input, pattern)

    let isMatch (pattern: string) (input: string) : bool = Regex.IsMatch(input, pattern)

    let replace (pattern: string) (replacement: string) (input: string) : string =
        Regex.Replace(input, pattern, replacement)
