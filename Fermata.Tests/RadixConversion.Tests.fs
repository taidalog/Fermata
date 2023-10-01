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
    let expected = Ok(Dec 42)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.validate 2`` () =
    let actual = "FF" |> Dec.validate

    let msg =
        match actual with
        | Ok _ -> ""
        | Error e ->
            match e with
            | Exceptions.Format s -> s
            | _ -> ""

    //let expected =
    //    Error(Exceptions.Format "The input string 'FF' was not in a correct format.")

    Assert.Matches("(The )?[Ii]nput string ('FF' )?was not in a correct format.", msg)

[<Fact>]
let ``Dec.validate 3`` () =
    let actual = "2147483648" |> Dec.validate

    let expected =
        Error(Exceptions.Overflow "Value was either too large or too small for an Int32.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toBin 1`` () =
    let actual = Dec 42 |> Dec.toBin
    let expected = Bin "101010"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toBin 2`` () =
    let actual = "42" |> Dec.validate |> Result.map Dec.toBin
    let expected = Ok(Bin "101010")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toBin 3`` () =
    let d = "42" |> Dec.validate

    let actual =
        match d with
        | Ok dec ->
            let (Bin b) = dec |> Dec.toBin
            b
        | Error _ -> ""

    let expected = "101010"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toBin 4`` () =
    let d = "42." |> Dec.validate
    let b = d |> Result.map Dec.toBin

    let actual =
        match b with
        | Ok(Bin x) -> x
        | Error _ -> ""

    let expected = ""
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toHex 1`` () =
    let input = Dec 42
    let actual = input |> Dec.toHex
    let expected = Hex "2a"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toHex 2`` () =
    let actual = "42" |> Dec.validate |> Result.map Dec.toHex
    let expected = Ok(Hex "2a")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toHex 3`` () =
    let d = "42" |> Dec.validate

    let actual =
        match d with
        | Ok dec ->
            let (Hex h) = dec |> Dec.toHex
            h
        | Error _ -> ""

    let expected = "2a"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toHex 4`` () =
    let d = "42." |> Dec.validate
    let h = d |> Result.map Dec.toHex

    let actual =
        match h with
        | Ok(Hex x) -> x
        | Error _ -> ""

    let expected = ""
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.validate 1`` () =
    let input = "101010"
    let actual = input |> Bin.validate
    let expected = Ok(Bin "101010")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.validate 2`` () =
    let input = "FF"
    let actual = input |> Bin.validate

    let expected =
        Error(Exceptions.Format "The input string 'FF' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.validate 3`` () =
    let input = "100000000000000000000000000000000"
    let actual = input |> Bin.validate

    let expected =
        Error(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 32")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.toDec 1`` () =
    let input = Bin "101010"
    let actual = input |> Bin.toDec
    let expected = Dec 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.toDec 2`` () =
    let actual = "101010" |> Bin.validate |> Result.map Bin.toDec
    let expected = Ok(Dec 42)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.toDec 3`` () =
    let b = "101010" |> Bin.validate

    let actual =
        match b with
        | Ok bin ->
            let (Dec d) = bin |> Bin.toDec
            string d
        | Error _ -> ""

    let expected = "42"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.toDec 4`` () =
    let b = "XX" |> Bin.validate
    let d = b |> Result.map Bin.toDec

    let actual =
        match d with
        | Ok(Dec x) -> string x
        | Error _ -> ""

    let expected = ""
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.validate 1`` () =
    let input = "FF"
    let actual = input |> Hex.validate
    let expected = Ok(Hex "FF")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.validate 2`` () =
    let input = "XX"
    let actual = input |> Hex.validate

    let expected =
        Error(Exceptions.Format "The input string 'XX' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.validate 3`` () =
    let input = "FFFFFFFFF"
    let actual = input |> Hex.validate

    let expected =
        Error(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 8")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.toDec 1`` () =
    let input = Hex "FF"
    let actual = input |> Hex.toDec
    let expected = Dec 255
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.toDec 2`` () =
    let actual = "ff" |> Hex.validate |> Result.map Hex.toDec
    let expected = Ok(Dec 255)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.toDec 3`` () =
    let h = "ff" |> Hex.validate

    let actual =
        match h with
        | Ok hex ->
            let (Dec d) = hex |> Hex.toDec
            string d
        | Error _ -> ""

    let expected = "255"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.toDec 4`` () =
    let h = "XX" |> Hex.validate
    let d = h |> Result.map Hex.toDec

    let actual =
        match d with
        | Ok(Dec x) -> string x
        | Error _ -> ""

    let expected = ""
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 1`` () =
    let actual = Arb.ofInt 2 "01" 42
    let expected = Ok(Arb(2, "01", "101010"))
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 2`` () =
    let actual = Arb.ofInt 5 "01234" 42
    let expected = Ok(Arb(5, "01234", "132"))
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 3`` () =
    let actual = Arb.ofInt 5 "HMNPY" 42
    let expected = Ok(Arb(5, "HMNPY", "MPN"))
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 4`` () =
    let actual = Arb.ofInt 1 "0" 42
    let expected = Error(Exceptions.Argument "Radix must be greater than 1.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 5`` () =
    let actual = Arb.ofInt 16 "" 42
    let expected = Error(Exceptions.Argument "Symbols were not specified.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.ofInt 6`` () =
    let actual = Arb.ofInt 16 "01" 42

    let expected =
        Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 1`` () =
    let actual = Arb.toInt (Arb(2, "01", "101010"))
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 2`` () =
    let actual = Arb.toInt (Arb(5, "01234", "132"))
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 3`` () =
    let actual = Arb.toInt (Arb(5, "HMNPY", "MPN"))
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 4`` () =
    let actual = Arb.toInt (Arb(1, "0", "0"))
    let expected = Error(Exceptions.Argument "Radix must be greater than 1.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 5`` () =
    let actual = Arb.toInt (Arb(16, "", "2a"))
    let expected = Error(Exceptions.Argument "Symbols were not specified.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 6`` () =
    let actual = Arb.toInt (Arb(16, "01", "2a"))

    let expected =
        Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Arb.toInt 7`` () =
    let actual = Arb.toInt (Arb(16, "0123456789abcdef", "7ffffffff")) // over `Int32.MaxValue`.

    let expected =
        Error(Exceptions.Overflow "Arithmetic operation resulted in an overflow.")

    Assert.Equal(expected, actual)
    Assert.Equal(expected, actual)
