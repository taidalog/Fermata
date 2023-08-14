// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
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
let ``List.countWith 1`` () =
    let inputs = [ "Laziness"; "Impatience"; "Hubris" ]
    let actual = inputs |> List.countWith (fun x -> String.length x > 6)
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.countWith 2`` () =
    let inputs = [ "Laziness"; "Impatience"; "Hubris" ]
    let actual = inputs |> List.countWith (fun x -> String.length x < 0)
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
let ``List.filteri 1`` () =
    let inputs = [ 42; 16; 8; 20; 120; 4 ]
    let actual: (int * int) list = inputs |> List.filteri (fun x -> x % 10 = 0)
    let expected = [ (3, 20); (4, 120) ]
    Assert.Equal<(int * int) list>(expected, actual)

[<Fact>]
let ``List.filteri 2`` () =
    let inputs = [ 42; 16; 8; 20; 120; 4 ]
    let actual: (int * int) list = inputs |> List.filteri (fun x -> x % 2 = 1)
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
let ``List.splitWith 1`` () =
    let list = [ 0; 2; 4; 6; 8 ]
    let actual: int list * int list = list |> List.splitWith (fun x -> x > 5)
    let expected = ([ 0; 2; 4 ], [ 6; 8 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.splitWith 2`` () =
    let list = [ 0; 2; 5; 6; 8 ]
    let actual: int list * int list = list |> List.splitWith (fun x -> x % 2 = 1)
    let expected = ([ 0; 2 ], [ 5; 6; 8 ])
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.splitWith 3`` () =
    let list = [ 0; 2; 5; 6; 8 ]
    let actual: int list * int list = list |> List.splitWith (fun x -> x % 2 = 2)
    let expected = ([ 0; 2; 5; 6; 8 ], [])
    Assert.Equal(expected, actual)

[<Fact>]
let ``List.padLeft 1`` () =
    let list = [ '2'; '4'; '6'; '8' ]
    let actual = list |> List.padLeft 8 '0'
    let expected = [ '0'; '0'; '0'; '0'; '2'; '4'; '6'; '8' ]
    Assert.Equal<char list>(expected, actual)

[<Fact>]
let ``List.padRight 1`` () =
    let list = [ '2'; '4'; '6'; '8' ]
    let actual = list |> List.padRight 8 '0'
    let expected = [ '2'; '4'; '6'; '8'; '0'; '0'; '0'; '0' ]
    Assert.Equal<char list>(expected, actual)
