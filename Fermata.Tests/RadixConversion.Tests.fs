// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module RadixConversion.Tests

open Xunit
open Fermata
open Fermata.RadixConversion

[<Fact>]
let ``Dec.validate 1`` () =
    let actual = "42" |> Dec.validate
    let expected = Dec.Valid 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.validate 2`` () =
    let actual = "FF" |> Dec.validate

    let expected =
        Dec.Invalid(Exceptions.Format "Input string was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.validate 3`` () =
    let actual = "2147483648" |> Dec.validate

    let expected =
        Dec.Invalid(Exceptions.Overflow "Value was either too large or too small for an Int32.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toBin 1`` () =
    let actual = "42" |> Dec.validate |> Dec.toBin
    let expected = Bin.Valid "101010"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toBin 2`` () =
    let actual = "42." |> Dec.validate |> Dec.toBin

    let expected =
        Bin.Invalid(Exceptions.Format "Input string was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toHex 1`` () =
    let actual = "42" |> Dec.validate |> Dec.toHex
    let expected = Hex.Valid "2a"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toHex 2`` () =
    let actual = "42." |> Dec.validate |> Dec.toHex

    let expected =
        Hex.Invalid(Exceptions.Format "Input string was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.validate 1`` () =
    let actual = "101010" |> Bin.validate
    let expected = Bin.Valid "101010"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.validate 2`` () =
    let actual = "FF" |> Bin.validate

    let expected =
        Bin.Invalid(Exceptions.Format "The input string 'FF' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.validate 3`` () =
    let actual = "100000000000000000000000000000000" |> Bin.validate

    let expected =
        Bin.Invalid(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 32")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.toDec 1`` () =
    let actual = "101010" |> Bin.validate |> Bin.toDec
    let expected = Dec.Valid 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.toDec 2`` () =
    let actual = "XX" |> Bin.validate |> Bin.toDec

    let expected =
        Dec.Invalid(Exceptions.Format "The input string 'XX' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.validate 1`` () =
    let actual = "FF" |> Hex.validate
    let expected = Hex.Valid "FF"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.validate 2`` () =
    let actual = "XX" |> Hex.validate

    let expected =
        Hex.Invalid(Exceptions.Format "The input string 'XX' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.validate 3`` () =
    let actual = "FFFFFFFFF" |> Hex.validate

    let expected =
        Hex.Invalid(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 8")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.toDec 1`` () =
    let actual = "ff" |> Hex.validate |> Hex.toDec
    let expected = Dec.Valid 255
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.toDec 2`` () =
    let actual = "XX" |> Hex.validate |> Hex.toDec

    let expected =
        Dec.Invalid(Exceptions.Format "The input string 'XX' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 1`` () =
    let actual = Arb.ofInt 2 "01" 42
    let expected = Arb.Valid(2, "01", "101010")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 2`` () =
    let actual = Arb.ofInt 5 "01234" 42
    let expected = Arb.Valid(5, "01234", "132")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 3`` () =
    let actual = Arb.ofInt 5 "HMNPY" 42
    let expected = Arb.Valid(5, "HMNPY", "MPN")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 4`` () =
    let actual = Arb.ofInt 1 "0" 42
    let expected = Arb.Invalid(Exceptions.Argument "Radix must be greater than 1.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 5`` () =
    let actual = Arb.ofInt 16 "" 42
    let expected = Arb.Invalid(Exceptions.Argument "Symbols were not specified.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 6`` () =
    let actual = Arb.ofInt 16 "01" 42

    let expected =
        Arb.Invalid(Exceptions.Argument "The number of the symbols and the radix didn't match.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 1`` () =
    let actual = Arb.toInt (Arb.Valid(2, "01", "101010"))
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 2`` () =
    let actual = Arb.toInt (Arb.Valid(5, "01234", "132"))
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 3`` () =
    let actual = Arb.toInt (Arb.Valid(5, "HMNPY", "MPN"))
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 4`` () =
    let actual = Arb.toInt (Arb.Valid(1, "0", "0"))
    let expected = Error(Exceptions.Argument "Radix must be greater than 1.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 5`` () =
    let actual = Arb.toInt (Arb.Valid(16, "", "2a"))
    let expected = Error(Exceptions.Argument "Symbols were not specified.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 6`` () =
    let actual = Arb.toInt (Arb.Valid(16, "01", "2a"))

    let expected =
        Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 7`` () =
    let actual = Arb.toInt (Arb.Valid(16, "0123456789abcdef", "7ffffffff")) // over `Int32.MaxValue`.

    let expected =
        Error(Exceptions.Overflow "Arithmetic operation resulted in an overflow.")

    Assert.Equal(expected, actual)
