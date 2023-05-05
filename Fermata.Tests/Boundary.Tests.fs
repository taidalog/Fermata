module Boundary.Tests

open Xunit
open Fermata.Bound

[<Fact>]
let ``Test Boundary.clampGap`` () =
    [
        (80, 0), clampGap 0 100 80
        (100, 20), clampGap 0 100 120
        (0, -80), clampGap 0 100 -80
        (0, -80), clampGap 0 100 -80
        (0, -80), clampGap 0 100 -80
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

    [
        (80., 0.), clampGap 0. 100. 80.
        (100., 20.), clampGap 0. 100. 120.
        (0., -80.), clampGap 0. 100. -80.
        (0., -80.), clampGap 0. 100. -80.
        (0., -80.), clampGap 0. 100. -80.
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

[<Fact>]
let ``Test Boundary.clamp`` () =
    [
        80, clamp 0 100 80
        100, clamp 0 100 120
        0, clamp 0 100 -80
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

    [
        80., clamp 0. 100. 80.
        100., clamp 0. 100. 120.
        0., clamp 0. 100. -80.
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))
    
    [
        80L, clamp 0L 100L 80L
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

[<Fact>]
let ``Test Boundary.gap`` () =
    [
        0, gap 0 100 80
        20, gap 0 100 120
        -80, gap 0 100 -80
        -80, gap 0 100 -80
        -80, gap 0 100 -80
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

    [
        0., gap 0. 100. 80.
        20., gap 0. 100. 120.
        -80., gap 0. 100. -80.
        -80., gap 0. 100. -80.
        -80., gap 0. 100. -80.
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

[<Fact>]
let ``Test Boundary.between`` () =
    [
        true, between 0 100 80
        false, between 0 100 120
        false, between 0 100 -80
        false, between 0 100 -80
        false, between 0 100 -80
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

    [
        true, between 0. 100. 80.
        false, between 0. 100. 120.
        false, between 0. 100. -80.
        false, between 0. 100. -80.
        false, between 0. 100. -80.
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

[<Fact>]
let ``Test Boundary.within`` () =
    [
        true, within 0 100 80
        false, within 0 100 120
        true, within 0 100 -80
        true, within 0 100 -80
        true, within 0 100 -80
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

    [
        true, within 0. 100. 80.
        false, within 0. 100. 120.
        true, within 0. 100. -80.
        true, within 0. 100. -80.
        true, within 0. 100. -80.
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

[<Fact>]
let ``Test Boundary.rebound`` () =
    [
        80, rebound 0 100 80
        80, rebound 0 100 120
        70, rebound 0 100 -70
        60, rebound 50 100 -160
        160, rebound -100 200 240
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))
    
    [
        80., rebound 0. 100. 80.
        80., rebound 0. 100. 120.
        70., rebound 0. 100. -70.
        60., rebound 50. 100. -160.
        160., rebound -100. 200. 240.
    ]
    |> List.iter (fun (expected, actual) -> Assert.Equal(expected, actual))

[<Fact>]
let ``Test Boundary.warp`` () =
    [
        80, warp 0 100 80
        20, warp 0 100 120
        30, warp 0 100 -70
        90, warp 50 100 -160
        -60, warp -100 200 240
    ]
    |> List.iter (fun (expected: int, actual: int) -> Assert.Equal(expected, actual))
    
    [
        80., warp 0. 100. 80.
        20., warp 0. 100. 120.
        30., warp 0. 100. -70.
        90., warp 50. 100. -160.
        -60., warp -100. 200. 240.
    ]
    |> List.iter (fun (expected: float, actual: float) -> Assert.Equal(expected, actual))
