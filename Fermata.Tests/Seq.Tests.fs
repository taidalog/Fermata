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
let ``Seq.fore 1`` () =
    let inputs = seq [ 0; 1; 2 ]
    let actual = inputs |> Seq.fore
    let expected = seq [ 0; 1 ]
    Assert.Equal<seq<int>>(expected, actual)

[<Fact>]
let ``Seq.tryFore 1`` () =
    let inputs = seq [ 0; 1; 2 ]
    let actual = inputs |> Seq.tryFore |> Option.map Seq.toList
    let expected = Some(seq [ 0; 1 ] |> Seq.toList)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.tryFore 2`` () =
    let inputs: seq<int> = seq []
    let actual = inputs |> Seq.tryFore
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
let ``Seq.countBefore 1`` () =
    let actual = seq [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> Seq.countBefore 0
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.countBefore 2`` () =
    let actual = seq [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> Seq.countBefore 2
    let expected = 1
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.countBefore 3`` () =
    let actual = seq [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> Seq.countBefore 5
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.countAfter 1`` () =
    let actual = seq [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> Seq.countAfter 0
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.countAfter 2`` () =
    let actual = seq [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> Seq.countAfter 2
    let expected = 1
    Assert.Equal(expected, actual)

[<Fact>]
let ``Seq.countAfter 3`` () =
    let actual = seq [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> Seq.countAfter 5
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
let ``Seq.filteri 1`` () =
    let actual = seq [ 0; 2; 6; 7; 9; 12 ] |> Seq.filteri (fun i x -> (i * x) % 2 = 0)
    let expected = seq [ 0; 2; 6; 9; 12 ]
    Assert.Equal<seq<int>>(expected, actual)

[<Fact>]
let ``Seq.filteri 2`` () =
    let actual =
        seq [ "hey"; "F#"; "" ] |> Seq.filteri (fun i x -> (i * String.length x) < 0)

    let expected = seq []
    Assert.Equal<seq<string>>(expected, actual)

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
let ``Seq.filterIndexPair 1`` () =
    let source = seq [ 42; 16; 8; 20; 120; 4 ]
    let actual = source |> Seq.filterIndexPair (fun x -> x % 10 = 0)
    let expected = seq [ (3, 20); (4, 120) ]
    Assert.Equal<seq<(int * int)>>(expected, actual)

[<Fact>]
let ``Seq.filterIndexPair 2`` () =
    let source = seq [ 42; 16; 8; 20; 120; 4 ]
    let actual = source |> Seq.filterIndexPair (fun x -> x % 2 = 1)
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

[<Fact>]
let ``Seq.stairs 1`` () =
    let actual = Seq.stairs (seq [ 0..4 ])

    let expected =
        seq
            [ seq [ 0 ]
              seq [ 0; 1 ]
              seq [ 0; 1; 2 ]
              seq [ 0; 1; 2; 3 ]
              seq [ 0; 1; 2; 3; 4 ] ]

    Assert.Equal<seq<seq<int>>>(expected, actual)

[<Fact>]
let ``Seq.stairs 2`` () =
    let input: seq<int> = seq []
    let actual = input |> Seq.stairs
    let expected = seq []
    Assert.Equal<seq<seq<int>>>(expected, actual)

[<Fact>]
let ``Seq.stairsBack 1`` () =
    let actual = Seq.stairsBack (seq [ 0..4 ])

    let expected =
        seq
            [ seq [ 4 ]
              seq [ 3; 4 ]
              seq [ 2; 3; 4 ]
              seq [ 1; 2; 3; 4 ]
              seq [ 0; 1; 2; 3; 4 ] ]

    Assert.Equal<seq<seq<int>>>(expected, actual)

[<Fact>]
let ``Seq.stairsBack 2`` () =
    let input: seq<int> = seq []
    let actual = input |> Seq.stairsBack
    let expected = seq []
    Assert.Equal<seq<seq<int>>>(expected, actual)
