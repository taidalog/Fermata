// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Seq.Tests

open Xunit
open Fermata

[<Fact>]
let ``Seq.tryTail 1`` () =
    let source = seq [ 0; 1; 2 ]
    let actual = source |> Seq.tryTail |> Option.map Seq.toList
    let expected = Some(seq [ 1; 2 ] |> Seq.toList)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.tryTail 2`` () =
    let source: seq<int> = seq []
    let actual = source |> Seq.tryTail
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.countWith 1`` () =
    let source = seq [ "Laziness"; "Impatience"; "Hubris" ]
    let actual = source |> Seq.countWith (fun x -> String.length x > 6)
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.countWith 2`` () =
    let source = seq [ "Laziness"; "Impatience"; "Hubris" ]
    let actual = source |> Seq.countWith (fun x -> String.length x < 0)
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.trySkip 1`` () =
    let source = seq [ 0; 1; 2; 3; 4; 5 ]
    let actual = source |> Seq.trySkip 3 |> Option.map Seq.toList
    let expected = Some(seq [ 3; 4; 5 ] |> Seq.toList)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.trySkip 2`` () =
    let source = seq [ 0; 1 ]
    let actual = source |> Seq.trySkip 3
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.filterIndex 1`` () =
    let source = seq [ "A"; "B"; "A"; "C"; "C"; "A" ]
    let actual = source |> Seq.filterIndex (fun x -> x = "A")
    let expected = seq [ 0; 2; 5 ]
    Assert.Equal<seq<int>>(expected, actual)

[<Fact>]
let ``Seq.filterIndex 2`` () =
    let source = seq [ "A"; "B"; "A"; "C"; "C"; "A" ]
    let actual = source |> Seq.filterIndex (fun x -> x = "Z")
    let expected = seq []
    Assert.Equal<seq<int>>(expected, actual)

[<Fact>]
let ``Seq.filteri 1`` () =
    let source = seq [ 42; 16; 8; 20; 120; 4 ]
    let actual = source |> Seq.filteri (fun x -> x % 10 = 0)
    let expected = seq [ (3, 20); (4, 120) ]
    Assert.Equal<seq<(int * int)>>(expected, actual)

[<Fact>]
let ``Seq.filteri 2`` () =
    let source = seq [ 42; 16; 8; 20; 120; 4 ]
    let actual = source |> Seq.filteri (fun x -> x % 2 = 1)
    let expected = seq []
    Assert.Equal<seq<(int * int)>>(expected, actual)

[<Fact>]
let ``Seq.intersect 1`` () =
    let source1 = seq [ 0; 1; 2; 3; 4 ]
    let source2 = seq [ 0; 2; 4; 6; 8 ]
    let actual = Seq.intersect source1 source2
    let expected = seq [ 0; 2; 4 ]
    Assert.Equal<seq<int>>(expected, actual)

[<Fact>]
let ``Seq.splitWith 1`` () =
    let source = seq [ 0; 2; 4; 6; 8 ]
    let actual: seq<int> * seq<int> = source |> Seq.splitWith (fun x -> x > 5)
    let expected = (seq [ 0; 2; 4 ], seq [ 6; 8 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.splitWith 2`` () =
    let source = seq [ 0; 2; 5; 6; 8 ]
    let actual: seq<int> * seq<int> = source |> Seq.splitWith (fun x -> x % 2 = 1)
    let expected = (seq [ 0; 2 ], seq [ 5; 6; 8 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.splitWith 3`` () =
    let source = seq [ 0; 2; 5; 6; 8 ]
    let actual: seq<int> * seq<int> = source |> Seq.splitWith (fun x -> x % 2 = 2)
    let expected = (seq [ 0; 2; 5; 6; 8 ], seq [])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.padLeft 1`` () =
    let source = seq [ '2'; '4'; '6'; '8' ]
    let actual = source |> Seq.padLeft 8 '0'
    let expected = seq [ '0'; '0'; '0'; '0'; '2'; '4'; '6'; '8' ]
    Assert.Equal<seq<char>>(expected, actual)

[<Fact>]
let ``Seq.padRight 1`` () =
    let source = seq [ '2'; '4'; '6'; '8' ]
    let actual = source |> Seq.padRight 8 '0'
    let expected = seq [ '2'; '4'; '6'; '8'; '0'; '0'; '0'; '0' ]
    Assert.Equal<seq<char>>(expected, actual)
