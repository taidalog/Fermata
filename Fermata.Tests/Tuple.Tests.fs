module Tuple.Tests

open Xunit
open Fermata

[<Fact>]
let ``Tuple.map 1`` () =
    let actual = Tuple.map int ("0", "1")
    let expected = (0, 1)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.map3 1`` () =
    let actual = Tuple.map3 int ("0", "1", "2")
    let expected = (0, 1, 2)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.map4 1`` () =
    let actual = Tuple.map4 int ("0", "1", "2", "3")
    let expected = (0, 1, 2, 3)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith 1`` () =
    let actual = Tuple.mapWith (int, float) ("0", "1")
    let expected = (0, 1.0)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith3 1`` () =
    let actual = Tuple.mapWith3 (int, float, int64) ("0", "1", "2")
    let expected = (0, 1.0, 2L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith4 1`` () =
    let actual = Tuple.mapWith4 (int, float, int64, byte) ("0", "1", "2", "3")
    let expected = (0, 1.0, 2L, 3uy)
    Assert.Equal(expected, actual)
