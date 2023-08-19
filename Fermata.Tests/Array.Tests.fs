// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Array.Tests

open Xunit
open Fermata

[<Fact>]
let ``Array.tryTail 1`` () =
    let inputs = [| 0; 1; 2 |]
    let actual = inputs |> Array.tryTail
    let expected = Some [| 1; 2 |]
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.tryTail 2`` () =
    let inputs: int[] = [||]
    let actual = inputs |> Array.tryTail
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.fore 1`` () =
    let inputs = [| 0; 1; 2 |]
    let actual = inputs |> Array.fore
    let expected = [| 0; 1 |]
    Assert.Equal<int array>(expected, actual)

[<Fact>]
let ``Array.tryFore 1`` () =
    let inputs = [| 0; 1; 2 |]
    let actual = inputs |> Array.tryFore
    let expected = Some [| 0; 1 |]
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.tryFore 2`` () =
    let inputs: int[] = [||]
    let actual = inputs |> Array.tryFore
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.countWith 1`` () =
    let inputs = [| "Laziness"; "Impatience"; "Hubris" |]
    let actual = inputs |> Array.countWith (fun x -> String.length x > 6)
    let expected = 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.countWith 2`` () =
    let inputs = [| "Laziness"; "Impatience"; "Hubris" |]
    let actual = inputs |> Array.countWith (fun x -> String.length x < 0)
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.trySkip 1`` () =
    let inputs = [| 0; 1; 2; 3; 4; 5 |]
    let actual = inputs |> Array.trySkip 3
    let expected = Some [| 3; 4; 5 |]
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.trySkip 2`` () =
    let inputs = [| 0; 1 |]
    let actual = inputs |> Array.trySkip 3
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.filteri 1`` () =
    let actual = [| 0; 2; 6; 7; 9; 12 |] |> Array.filteri (fun i x -> (i * x) % 2 = 0)
    let expected = [| 0; 2; 6; 9; 12 |]
    Assert.Equal<int[]>(expected, actual)

[<Fact>]
let ``Array.filteri 2`` () =
    let actual =
        [| "hey"; "F#"; "" |] |> Array.filteri (fun i x -> (i * String.length x) < 0)

    let expected = [||]
    Assert.Equal<string[]>(expected, actual)

[<Fact>]
let ``Array.filterIndex 1`` () =
    let inputs = [| "A"; "B"; "A"; "C"; "C"; "A" |]
    let actual = inputs |> Array.filterIndex (fun x -> x = "A")
    let expected = [| 0; 2; 5 |]
    Assert.Equal<int array>(expected, actual)

[<Fact>]
let ``Array.filterIndex 2`` () =
    let inputs = [| "A"; "B"; "A"; "C"; "C"; "A" |]
    let actual = inputs |> Array.filterIndex (fun x -> x = "Z")
    let expected = [||]
    Assert.Equal<int array>(expected, actual)

[<Fact>]
let ``Array.filterIndexPair 1`` () =
    let inputs = [| 42; 16; 8; 20; 120; 4 |]

    let actual: (int * int) array =
        inputs |> Array.filterIndexPair (fun x -> x % 10 = 0)

    let expected = [| (3, 20); (4, 120) |]
    Assert.Equal<(int * int) array>(expected, actual)

[<Fact>]
let ``Array.filterIndexPair 2`` () =
    let inputs = [| 42; 16; 8; 20; 120; 4 |]
    let actual: (int * int) array = inputs |> Array.filterIndexPair (fun x -> x % 2 = 1)
    let expected = [||]
    Assert.Equal<(int * int) array>(expected, actual)

[<Fact>]
let ``Array.intersect 1`` () =
    let array1 = [| 0; 1; 2; 3; 4 |]
    let array2 = [| 0; 2; 4; 6; 8 |]
    let actual = Array.intersect array1 array2
    let expected = [| 0; 2; 4 |]
    Assert.Equal<int array>(expected, actual)

[<Fact>]
let ``Array.splitWith 1`` () =
    let array = [| 0; 2; 4; 6; 8 |]
    let actual: int array * int array = array |> Array.splitWith (fun x -> x > 5)
    let expected = ([| 0; 2; 4 |], [| 6; 8 |])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.splitWith 2`` () =
    let array = [| 0; 2; 5; 6; 8 |]
    let actual = array |> Array.splitWith (fun x -> x % 2 = 1)
    let expected = ([| 0; 2 |], [| 5; 6; 8 |])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.splitWith 3`` () =
    let array = [| 0; 2; 5; 6; 8 |]
    let actual: int array * int array = array |> Array.splitWith (fun x -> x % 2 = 2)
    let expected = ([| 0; 2; 5; 6; 8 |], [||])
    Assert.Equal(expected, actual)

[<Fact>]
let ``Array.padLeft 1`` () =
    let array = [| '2'; '4'; '6'; '8' |]
    let actual = array |> Array.padLeft 8 '0'
    let expected = [| '0'; '0'; '0'; '0'; '2'; '4'; '6'; '8' |]
    Assert.Equal<char array>(expected, actual)

[<Fact>]
let ``Array.padRight 1`` () =
    let array = [| '2'; '4'; '6'; '8' |]
    let actual = array |> Array.padRight 8 '0'
    let expected = [| '2'; '4'; '6'; '8'; '0'; '0'; '0'; '0' |]
    Assert.Equal<char array>(expected, actual)

[<Fact>]
let ``Array.stairs 1`` () =
    let actual = Array.stairs [| 0..4 |]

    let expected =
        [| [| 0 |]; [| 0; 1 |]; [| 0; 1; 2 |]; [| 0; 1; 2; 3 |]; [| 0; 1; 2; 3; 4 |] |]

    Assert.Equal<int[][]>(expected, actual)

[<Fact>]
let ``Array.stairs 2`` () =
    let input: int[] = [||]
    let actual = input |> Array.stairs
    let expected = [||]
    Assert.Equal<int[][]>(expected, actual)

[<Fact>]
let ``Array.stairsBack 1`` () =
    let actual = Array.stairsBack [| 0..4 |]

    let expected =
        [| [| 4 |]; [| 3; 4 |]; [| 2; 3; 4 |]; [| 1; 2; 3; 4 |]; [| 0; 1; 2; 3; 4 |] |]

    Assert.Equal<int[][]>(expected, actual)

[<Fact>]
let ``Array.stairsBack 2`` () =
    let input: int[] = [||]
    let actual = input |> Array.stairsBack
    let expected = [||]
    Assert.Equal<int[][]>(expected, actual)
