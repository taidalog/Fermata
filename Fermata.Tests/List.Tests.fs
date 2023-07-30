module List.Tests

open Xunit
open Fermata

[<Fact>]
let ``List.filteri 1`` () =
    let inputs = [ 42; 16; 8; 20; 120; 4 ]
    let actual = inputs |> List.filteri (fun x -> x % 10 = 0)
    let expected = [ (3, 20); (4, 120) ]
    Assert.Equal<(int * int) list>(expected, actual)

[<Fact>]
let ``List.filteri 2`` () =
    let inputs = [ 42; 16; 8; 20; 120; 4 ]
    let actual = inputs |> List.filteri (fun x -> x % 2 = 1)
    let expected = []
    Assert.Equal<(int * int) list>(expected, actual)
