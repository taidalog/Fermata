module Seq.Tests

open Xunit
open Fermata

[<Fact>]
let ``Seq.filteri 1`` () =
    let inputs = seq [ 42; 16; 8; 20; 120; 4 ]
    let actual = inputs |> Seq.filteri (fun x -> x % 10 = 0)
    let expected = seq [ (3, 20); (4, 120) ]
    Assert.Equal<seq<(int * int)>>(expected, actual)

[<Fact>]
let ``Seq.filteri 2`` () =
    let inputs = seq [ 42; 16; 8; 20; 120; 4 ]
    let actual = inputs |> Seq.filteri (fun x -> x % 2 = 1)
    let expected = seq []
    Assert.Equal<seq<(int * int)>>(expected, actual)
