module Boundary.Tests

open Xunit
open Fermata.Bound

[<Fact>]
let ``Boundary.clampGap 1`` () =
    let actual = clampGap 0 100 80
    let expected = (80, 0)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 2`` () =
    let actual = clampGap 0 100 120
    let expected = (100, 20)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 3`` () =
    let actual = clampGap 0 100 -60
    let expected = (0, -60)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 4`` () =
    let actual = clampGap 60 100 40
    let expected = (60, -20)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 5`` () =
    let actual = clampGap -30. 100. -10.
    let expected = (-10., 0.)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 6`` () =
    let actual = clampGap -30. 100. 120.
    let expected = (100., 20.)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 7`` () =
    let actual = clampGap -30. 100. -50.
    let expected = (-30., -20.)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 8`` () =
    let actual = clampGap -100L -40L -60L
    let expected = (-60L, 0L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 9`` () =
    let actual = clampGap -100L -40L -20L
    let expected = (-40L, 20L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clampGap 10`` () =
    let actual = clampGap -100L -40L -120L
    let expected = (-100L, -20L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 1`` () =
    let actual = clamp 0 100 80
    let expected = 80
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 2`` () =
    let actual = clamp 0 100 120
    let expected = 100
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 3`` () =
    let actual = clamp 0 100 -60
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 4`` () =
    let actual = clamp 60 100 40
    let expected = 60
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 5`` () =
    let actual = clamp -30. 100. -10.
    let expected = -10.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 6`` () =
    let actual = clamp -30. 100. 120.
    let expected = 100.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 7`` () =
    let actual = clamp -30. 100. -50.
    let expected = -30.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 8`` () =
    let actual = clamp -100L -40L -60L
    let expected = -60L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 9`` () =
    let actual = clamp -100L -40L -20L
    let expected = -40L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.clamp 10`` () =
    let actual = clamp -100L -40L -120L
    let expected = -100L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 1`` () =
    let actual = gap 0 100 80
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 2`` () =
    let actual = gap 0 100 120
    let expected = 20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 3`` () =
    let actual = gap 0 100 -60
    let expected = -60
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 4`` () =
    let actual = gap 60 100 40
    let expected = -20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 5`` () =
    let actual = gap -30. 100. -10.
    let expected = 0.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 6`` () =
    let actual = gap -30. 100. 120.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 7`` () =
    let actual = gap -30. 100. -50.
    let expected = -20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 8`` () =
    let actual = gap -100L -40L -60L
    let expected = 0L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 9`` () =
    let actual = gap -100L -40L -20L
    let expected = 20L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.gap 10`` () =
    let actual = gap -100L -40L -120L
    let expected = -20L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 1`` () =
    let actual = between 0 100 80
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 2`` () =
    let actual = between 0 100 120
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 3`` () =
    let actual = between 0 100 -60
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 4`` () =
    let actual = between 60 100 40
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 5`` () =
    let actual = between -30. 100. -10.
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 6`` () =
    let actual = between -30. 100. 120.
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 7`` () =
    let actual = between -30. 100. -50.
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 8`` () =
    let actual = between -100L -40L -60L
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 9`` () =
    let actual = between -100L -40L -20L
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.between 10`` () =
    let actual = between -100L -40L -120L
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 1`` () =
    let actual = within 0 100 80
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 2`` () =
    let actual = within 0 100 100
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 3`` () =
    let actual = within 0 100 120
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 4`` () =
    let actual = within 0 100 -80
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 5`` () =
    let actual = within 60. 10. 70.
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 6`` () =
    let actual = within 60. 10. 70.1
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 7`` () =
    let actual = within 20L 40L -20L
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Boundary.within 8`` () =
    let actual = within 20L 40L -21L
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.rebound 1`` () =
    let actual = rebound 0 100 80
    let expected = 80
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.rebound 2`` () =
    let actual = rebound 0. 100. 120.
    let expected = 80.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.rebound 3`` () =
    let actual = rebound 0L 100L -70L
    let expected = 70L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.rebound 4`` () =
    let actual = rebound -50 50 120
    let expected = -20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.rebound 5`` () =
    let actual = rebound -50. 50. 220.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.rebound 6`` () =
    let actual = rebound -50L 50L -260L
    let expected = -40L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.warp 1`` () =
    let actual = warp 0 100 80
    let expected = 80
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.warp 2`` () =
    let actual = warp 0. 100. 120.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.warp 3`` () =
    let actual = warp 0L 100L -70L
    let expected = 30L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.warp 4`` () =
    let actual = warp -50 50 120
    let expected = 20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.warp 5`` () =
    let actual = warp -50. 50. 220.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Boundary.warp 6`` () =
    let actual = warp -50L 50L -260L
    let expected = 40L
    Assert.Equal(expected, actual)
