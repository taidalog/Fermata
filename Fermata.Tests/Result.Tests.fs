// Fermata Version 1.0.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Result.Tests

open Xunit
open Fermata

[<Fact>]
let ``Result.ofOption 1`` () =
    let option = Some 42
    let msg = "The input is not a number."
    let actual = Result.ofOption msg option
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Result.ofOption 2`` () =
    let option: int option = None
    let msg = "The input is not a number."
    let actual = Result.ofOption msg option
    let expected = Error "The input is not a number."
    Assert.Equal(expected, actual)
