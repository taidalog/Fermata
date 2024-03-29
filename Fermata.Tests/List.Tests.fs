// Fermata Version 1.0.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2024 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module List.Tests

open Xunit
open Fermata

[<Fact>]
let ``List.tryTail 1`` () =
    let inputs = [ 0; 1; 2 ]
    let actual = inputs |> List.tryTail
    let expected = Some [ 1; 2 ]
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.tryTail 2`` () =
    let inputs: int list = []
    let actual = inputs |> List.tryTail
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.fore 1`` () =
    let inputs = [ 0; 1; 2 ]
    let actual = inputs |> List.fore
    let expected = [ 0; 1 ]
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.tryFore 1`` () =
    let inputs = [ 0; 1; 2 ]
    let actual = inputs |> List.tryFore
    let expected = Some [ 0; 1 ]
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.tryFore 2`` () =
    let inputs: int list = []
    let actual = inputs |> List.tryFore
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.count 1`` () =
    let inputs = [ "Laziness"; "Impatience"; "Hubris" ]
    let actual = inputs |> List.count (fun x -> String.length x > 6)
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.count 2`` () =
    let inputs = [ "Laziness"; "Impatience"; "Hubris" ]
    let actual = inputs |> List.count (fun x -> String.length x < 0)
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.countBefore 1`` () =
    let actual = [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countBefore 0
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.countBefore 2`` () =
    let actual = [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countBefore 2
    let expected = 1
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.countBefore 3`` () =
    let actual = [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countBefore 5
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.countAfter 1`` () =
    let actual = [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countAfter 0
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.countAfter 2`` () =
    let actual = [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countAfter 2
    let expected = 1
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.countAfter 3`` () =
    let actual = [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countAfter 5
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.trySkip 1`` () =
    let inputs = [ 0; 1; 2; 3; 4; 5 ]
    let actual = inputs |> List.trySkip 3
    let expected = Some [ 3; 4; 5 ]
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.trySkip 2`` () =
    let inputs = [ 0; 1 ]
    let actual = inputs |> List.trySkip 3
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.filteri 1`` () =
    let actual = [ 0; 2; 6; 7; 9; 12 ] |> List.filteri (fun i x -> (i * x) % 2 = 0)
    let expected = [ 0; 2; 6; 9; 12 ]
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.filteri 2`` () =
    let actual =
        [ "hey"; "F#"; "" ] |> List.filteri (fun i x -> (i * String.length x) < 0)

    let expected = []
    Assert.Equal<string list>(expected, actual)

[<Fact>]
let ``List.filterIndex 1`` () =
    let inputs = [ "A"; "B"; "A"; "C"; "C"; "A" ]
    let actual = inputs |> List.filterIndex (fun x -> x = "A")
    let expected = [ 0; 2; 5 ]
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.filterIndex 2`` () =
    let inputs = [ "A"; "B"; "A"; "C"; "C"; "A" ]
    let actual = inputs |> List.filterIndex (fun x -> x = "Z")
    let expected = []
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.filterIndexed 1`` () =
    let inputs = [ 42; 16; 8; 20; 120; 4 ]
    let actual: (int * int) list = inputs |> List.filterIndexed (fun x -> x % 10 = 0)
    let expected = [ (3, 20); (4, 120) ]
    Assert.Equal<(int * int) list>(expected, actual)

[<Fact>]
let ``List.filterIndexed 2`` () =
    let inputs = [ 42; 16; 8; 20; 120; 4 ]
    let actual: (int * int) list = inputs |> List.filterIndexed (fun x -> x % 2 = 1)
    let expected = []
    Assert.Equal<(int * int) list>(expected, actual)

[<Fact>]
let ``List.intersect 1`` () =
    let list1 = [ 0; 1; 2; 3; 4 ]
    let list2 = [ 0; 2; 4; 6; 8 ]
    let actual = List.intersect list1 list2
    let expected = [ 0; 2; 4 ]
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.intersect 2`` () =
    let list1 = [ 0; 1; 2; 3; 4 ]
    let list2 = [ 5; 6; 7; 8; 9 ]
    let actual = List.intersect list1 list2
    let expected = []
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.intersect 3`` () =
    let list1 = [ 0; 1; 2; 3; 4 ]
    let list2 = []
    let actual = List.intersect list1 list2
    let expected = []
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.splitFind 1`` () =
    let list = [ 0; 2; 4; 6; 8 ]
    let actual: int list * int list = list |> List.splitFind (fun x -> x > 5)
    let expected = ([ 0; 2; 4 ], [ 6; 8 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.splitFind 2`` () =
    let list = [ 0; 2; 5; 6; 8 ]
    let actual: int list * int list = list |> List.splitFind (fun x -> x % 2 = 1)
    let expected = ([ 0; 2 ], [ 5; 6; 8 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.splitFind 3`` () =
    let list = [ 0; 2; 5; 6; 8 ]
    let actual: int list * int list = list |> List.splitFind (fun x -> x % 2 = 2)
    let expected = ([ 0; 2; 5; 6; 8 ], [])
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.padLeft 1`` () =
    let list = [ '2'; '4'; '6'; '8' ]
    let actual = list |> List.padLeft 8 '0'
    let expected = [ '0'; '0'; '0'; '0'; '2'; '4'; '6'; '8' ]
    Assert.Equal<char list>(expected, actual)

[<Fact>]
let ``List.padLeft 2`` () =
    let list = []
    let actual = list |> List.padLeft 4 0
    let expected = [ 0; 0; 0; 0 ]
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.padRight 1`` () =
    let list = [ '2'; '4'; '6'; '8' ]
    let actual = list |> List.padRight 8 '0'
    let expected = [ '2'; '4'; '6'; '8'; '0'; '0'; '0'; '0' ]
    Assert.Equal<char list>(expected, actual)

[<Fact>]
let ``List.padRight 2`` () =
    let list = []
    let actual = list |> List.padRight 4 0
    let expected = [ 0; 0; 0; 0 ]
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``List.stairs 1`` () =
    let actual = List.stairs [ 0..4 ]
    let expected = [ [ 0 ]; [ 0; 1 ]; [ 0; 1; 2 ]; [ 0; 1; 2; 3 ]; [ 0; 1; 2; 3; 4 ] ]
    Assert.Equal<int list list>(expected, actual)

[<Fact>]
let ``List.stairs 2`` () =
    let input: int list = []
    let actual = input |> List.stairs
    let expected = []
    Assert.Equal<int list list>(expected, actual)

[<Fact>]
let ``List.stairsBack 1`` () =
    let actual = List.stairsBack [ 0..4 ]
    let expected = [ [ 4 ]; [ 3; 4 ]; [ 2; 3; 4 ]; [ 1; 2; 3; 4 ]; [ 0; 1; 2; 3; 4 ] ]
    Assert.Equal<int list list>(expected, actual)

[<Fact>]
let ``List.stairsBack 2`` () =
    let input: int list = []
    let actual = input |> List.stairsBack
    let expected = []
    Assert.Equal<int list list>(expected, actual)

[<Fact>]
let ``List.splitWith 1`` () =
    let actual = "AAAABBCDDCAA" |> Seq.toList |> List.splitWith (<>)

    let expected =
        [ [ 'A'; 'A'; 'A'; 'A' ]
          [ 'B'; 'B' ]
          [ 'C' ]
          [ 'D'; 'D' ]
          [ 'C' ]
          [ 'A'; 'A' ] ]

    Assert.Equal<char list list>(expected, actual)

[<Fact>]
let ``List.splitWith 2`` () =
    let digit value =
        match value with
        | 0 -> 1
        | _ -> value |> abs |> float |> log10 |> int |> ((+) 1)

    let input = [ 0; 2; 12; 42; 128; 666; 6; 928; 1024 ]

    let actual = input |> List.splitWith (fun x y -> digit x <> digit y)

    let expected = [ [ 0; 2 ]; [ 12; 42 ]; [ 128; 666 ]; [ 6 ]; [ 928 ]; [ 1024 ] ]
    Assert.Equal<int list list>(expected, actual)

[<Fact>]
let ``List.splitWith 3`` () =
    let input = [ 0..9 ]

    let actual = input |> List.splitWith (fun x y -> x > y)

    let expected = [ [ 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 ] ]
    Assert.Equal<int list list>(expected, actual)

[<Fact>]
let ``List.splitWith 4`` () =
    let input = [ 0..9 ]

    let actual = input |> List.splitWith (fun x y -> x < y)

    let expected =
        [ [ 0 ]; [ 1 ]; [ 2 ]; [ 3 ]; [ 4 ]; [ 5 ]; [ 6 ]; [ 7 ]; [ 8 ]; [ 9 ] ]

    Assert.Equal<int list list>(expected, actual)
