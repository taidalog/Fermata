module RadixConversion.Tests

open Xunit
open Fermata
open Fermata.RadixConversion

[<Fact>]
let ``Dec.validate 1`` () =
    let actual = "42" |> Dec.validate
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.validate 2`` () =
    let actual = "FF" |> Dec.validate

    let expected =
        Error(Exceptions.Format "The input string 'FF' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.validate 3`` () =
    let actual = "2147483648" |> Dec.validate

    let expected =
        Error(Exceptions.Overflow "Value was either too large or too small for an Int32.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.isValid 1`` () =
    let actual = "42" |> Dec.isValid
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.isValid 2`` () =
    let actual = "FF" |> Dec.isValid
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toBin`` () =
    let actual = 42 |> Dec.toBin
    let expected = "101010"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.tryToBin 1`` () =
    let input = "42"
    let actual = input |> Dec.tryToBin
    let expected = Some "101010"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.tryToBin 2`` () =
    let input = "FF"
    let actual = input |> Dec.tryToBin
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.toHex 1`` () =
    let input = 42
    let actual = input |> Dec.toHex
    let expected = "2a"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.tryToHex 1`` () =
    let input = "42"
    let actual = input |> Dec.tryToHex
    let expected = Some "2a"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Dec.tryToHex 2`` () =
    let input = "FF"
    let actual = input |> Dec.tryToHex
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.validate 1`` () =
    let input = "101010"
    let actual = input |> Bin.validate
    let expected = Ok "101010"
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
let ``Bin.isValid 1`` () =
    let input = "101010"
    let actual = input |> Bin.isValid
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.isValid 2`` () =
    let input = "FF"
    let actual = input |> Bin.isValid
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.toDec 1`` () =
    let input = "101010"
    let actual = input |> Bin.toDec
    let expected = 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.tryToDec 1`` () =
    let input = "101010"
    let actual = input |> Bin.tryToDec
    let expected = Some 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bin.tryToDec 2`` () =
    let input = "FF"
    let actual = input |> Bin.tryToDec
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.validate 1`` () =
    let input = "FF"
    let actual = input |> Hex.validate
    let expected = Ok "FF"
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
let ``Hex.isValid 1`` () =
    let input = "FF"
    let actual = input |> Hex.isValid
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.isValid 2`` () =
    let input = "XX"
    let actual = input |> Hex.isValid
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.toDec 1`` () =
    let input = "FF"
    let actual = input |> Hex.toDec
    let expected = 255
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.tryToDec 1`` () =
    let input = "FF"
    let actual = input |> Hex.tryToDec
    let expected = Some 255
    Assert.Equal(expected, actual)

[<Fact>]
let ``Hex.tryToDec 2`` () =
    let input = "XX"
    let actual = input |> Hex.tryToDec
    let expected = None
    Assert.Equal(expected, actual)
