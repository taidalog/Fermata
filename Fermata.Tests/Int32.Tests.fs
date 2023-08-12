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
        Error <| Exceptions.Format "The input string '42.' was not in a correct format."

    Assert.Equal(expected, actual)
