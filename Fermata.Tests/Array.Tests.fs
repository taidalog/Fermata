module Array.Tests

open System.Collections.Generic
open Xunit
open Fermata

[<Fact>]
let ``Array.filteri 1`` () =
    let inputs = [| 42; 16; 8; 20; 120; 4 |]
    let actual: (int * int) array = inputs |> Array.filteri (fun x -> x % 10 = 0)
    let expected: (int * int) array = [| (3, 20); (4, 120) |]
    Assert.Equal<(int * int) array>(expected, actual)

[<Fact>]
let ``Array.filteri 2`` () =
    let inputs = [| 42; 16; 8; 20; 120; 4 |]
    let actual: (int * int)[] = inputs |> Array.filteri (fun x -> x % 2 = 1)
    let expected: (int * int)[] = [||]
    Assert.Equal<(int * int) array>(expected, actual)
