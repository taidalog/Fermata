// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Tuple.Tests

open Xunit
open Fermata

[<Fact>]
let ``Tuple.map 1`` () =
    let actual = Tuple.map int ("0", "1")
    let expected = (0, 1)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.map 2`` () =
    let actual = Tuple.map List.rev ([ 0; 1; 2; 3; 4 ], [ 5; 6; 7; 8; 9 ])
    let expected = ([ 4; 3; 2; 1; 0 ], [ 9; 8; 7; 6; 5 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.map3 1`` () =
    let actual = Tuple.map3 int ("0", "1", "2")
    let expected = (0, 1, 2)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.map3 2`` () =
    let actual = Tuple.map3 List.length ([], [ 0 ], [ 1; 2 ])
    let expected = (0, 1, 2)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.map4 1`` () =
    let actual = Tuple.map4 int ("0", "1", "2", "3")
    let expected = (0, 1, 2, 3)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.map4 2`` () =
    let actual = Tuple.map4 ((+) "U+") ("0000", "1000", "2000", "3000")
    let expected = ("U+0000", "U+1000", "U+2000", "U+3000")
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith 1`` () =
    let actual = Tuple.mapWith (int, float) ("0", "1")
    let expected = (0, 1.0)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith 2`` () =
    let actual =
        Tuple.mapWith (List.rev, List.length) ([ 0; 1; 2; 3; 4 ], [ 5; 6; 7; 8; 9 ])

    let expected = ([ 4; 3; 2; 1; 0 ], 5)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith3 1`` () =
    let actual = Tuple.mapWith3 (int, float, int64) ("0", "1", "2")
    let expected = (0, 1.0, 2L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith3 2`` () =
    let actual =
        Tuple.mapWith3 (List.length, List.rev, List.map ((*) 2)) ([ 0 ], [ 1; 2 ], [ 3; 4; 5 ])

    let expected = (1, [ 2; 1 ], [ 6; 8; 10 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith4 1`` () =
    let actual = Tuple.mapWith4 (int, float, int64, byte) ("0", "1", "2", "3")
    let expected = (0, 1.0, 2L, 3uy)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Tuple.mapWith4 2`` () =
    let actual = Tuple.mapWith4 (((+) 2), ((-) 2), ((*) 2), ((/) 2)) (1, 1, 1, 1)

    let expected = (3, 1, 2, 2)
    Assert.Equal(expected, actual)
