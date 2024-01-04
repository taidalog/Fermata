// Fermata Version 1.0.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Bool.Tests

open Xunit
open Fermata

[<Fact>]
let ``Bool.toInt 1`` () =
    let actual = true |> Bool.toInt
    let expected = 1
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bool.toInt 2`` () =
    let actual = false |> Bool.toInt
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bool.ofInt 1`` () =
    let actual = 42 |> Bool.ofInt
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bool.ofInt 2`` () =
    let actual = 0 |> Bool.ofInt
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bool.ofInt 3`` () =
    let actual = -192 |> Bool.ofInt
    let expected = true
    Assert.Equal(expected, actual)
