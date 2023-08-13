module Int32.Tests

open Xunit
open Fermata

[<Fact>]
let ``Int32.validate 1`` () =
    let actual = Int32.validate "42"
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Int32.validate 2`` () =
    let actual = Int32.validate "42."

    let expected =
        Error(Exceptions.Format "The input string '42.' was not in a correct format.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Int32.validate 3`` () =
    let actual = Int32.validate null

    let expected =
        Error(Exceptions.ArgumentNull "Value cannot be null. (Parameter 's')")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Int32.validate 4`` () =
    let actual = Int32.validate ""
    let expected = Error(Exceptions.EmptyString "Value cannot be empty string.")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Int32.validate 5`` () =
    let actual = Int32.validate "2147483648" // System.Int32.MaxValue + 1

    let expected =
        Error(Exceptions.Overflow "Value was either too large or too small for an Int32.")

    Assert.Equal(expected, actual)

[<Fact>]
let ``Int32.validate 6`` () =
    let actual = Int32.validate "-2147483649" // System.Int32.MinValue - 1

    let expected =
        Error(Exceptions.Overflow "Value was either too large or too small for an Int32.")

    Assert.Equal(expected, actual)
