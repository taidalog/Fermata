// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Validators.Tests

open Xunit
open Fermata
open Fermata.Validators

[<Fact>]
let ``Validators.validateNotNullOrEmpty 1`` () =
    let actual = "hey" |> validateNotNullOrEmpty
    let expected = Ok "hey"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateNotNullOrEmpty 2`` () =
    let actual = null |> validateNotNullOrEmpty
    let expected = Error(Exceptions.ArgumentNull "Value cannot be null.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateNotNullOrEmpty 3`` () =
    let actual = "" |> validateNotNullOrEmpty
    let expected = Error(Exceptions.ArgumentNull "Value cannot be null.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateNotEmptyString 1`` () =
    let actual = "hey" |> validateNotEmptyString
    let expected = Ok "hey"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateNotEmptyString 2`` () =
    let actual = "" |> validateNotEmptyString
    let expected = Error(Exceptions.EmptyString "Value cannot be empty string.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateFormat 1`` () =
    let actual = "42" |> validateFormat "^[0-9]+$"
    let expected = Ok "42"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateFormat 2`` () =
    let actual = "4a" |> validateFormat "^[0-9]+$"

    let expected =
        Error(Exceptions.Format "The input string '4a' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateRange 1`` () =
    let actual = 42 |> validateRange 0 255
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateRange 2`` () =
    let actual = 512 |> validateRange 0 255

    let expected =
        Error(Exceptions.OutOfRange "512 is out of range. Value must be within 0 and 255")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateRange 3`` () =
    let actual = 'f' |> validateRange 'a' 'z'
    let expected = Ok 'f'
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateRange 4`` () =
    let actual = 'A' |> validateRange '0' '9'

    let expected =
        Error(Exceptions.OutOfRange "'A' is out of range. Value must be within '0' and '9'")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateMaxLength 1`` () =
    let actual = "101010" |> validateMaxLength String.length 32
    let expected = Ok "101010"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateMaxLength 2`` () =
    let actual =
        "100000000000000000000000000000000" |> validateMaxLength String.length 32

    let expected =
        Error(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 32")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateMaxLength 3`` () =
    let actual = [ 0; 1; 2; 3; 4 ] |> validateMaxLength List.length 10
    let expected = Ok [ 0; 1; 2; 3; 4 ]
    Assert.Equal(expected, actual)

[<Fact>]
let ``Validators.validateMaxLength 4`` () =
    let actual =
        [ 0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10 ] |> validateMaxLength List.length 10

    let expected =
        Error(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 10")

    Assert.Equal(expected, actual)
