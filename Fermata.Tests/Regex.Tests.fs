// Fermata Version 1.0.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2024 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Regex.Tests

open Xunit
open Fermata

[<Fact>]
let ``Regex.match 1`` () =
    let m: System.Text.RegularExpressions.Match = "F#" |> Regex.match' "^[A-Z]#$"
    let actual = m.Success
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Regex.matches 1`` () =
    let ms: System.Text.RegularExpressions.MatchCollection =
        "Shinkansen" |> Regex.matches "[aeiou]n"

    let actual: seq<string> =
        ms |> Seq.map (fun (x: System.Text.RegularExpressions.Match) -> x.Value)

    let expected: seq<string> = seq [ "in"; "an"; "en" ]
    Assert.Equal<seq<string>>(expected, actual)

[<Fact>]
let ``Regex.isMatch 1`` () =
    let actual = "F#" |> Regex.isMatch "^[A-Z]#$"
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Regex.replace 1`` () =
    let actual = "C#" |> Regex.replace "^[A-Z](?=#$)" "F"
    let expected = "F#"
    Assert.Equal(expected, actual)
