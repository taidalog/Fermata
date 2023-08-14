module Bound.Tests

open Xunit
open Fermata.Bound

[<Fact>]
let ``Bound.clampGap 1`` () =
    let actual = clampGap 0 100 80
    let expected = (80, 0)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 2`` () =
    let actual = clampGap 0 100 120
    let expected = (100, 20)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 3`` () =
    let actual = clampGap 0 100 -60
    let expected = (0, -60)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 4`` () =
    let actual = clampGap 60 100 40
    let expected = (60, -20)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 5`` () =
    let actual = clampGap -30. 100. -10.
    let expected = (-10., 0.)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 6`` () =
    let actual = clampGap -30. 100. 120.
    let expected = (100., 20.)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 7`` () =
    let actual = clampGap -30. 100. -50.
    let expected = (-30., -20.)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 8`` () =
    let actual = clampGap -100L -40L -60L
    let expected = (-60L, 0L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 9`` () =
    let actual = clampGap -100L -40L -20L
    let expected = (-40L, 20L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clampGap 10`` () =
    let actual = clampGap -100L -40L -120L
    let expected = (-100L, -20L)
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 1`` () =
    let actual = clamp 0 100 80
    let expected = 80
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 2`` () =
    let actual = clamp 0 100 120
    let expected = 100
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 3`` () =
    let actual = clamp 0 100 -60
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 4`` () =
    let actual = clamp 60 100 40
    let expected = 60
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 5`` () =
    let actual = clamp -30. 100. -10.
    let expected = -10.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 6`` () =
    let actual = clamp -30. 100. 120.
    let expected = 100.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 7`` () =
    let actual = clamp -30. 100. -50.
    let expected = -30.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 8`` () =
    let actual = clamp -100L -40L -60L
    let expected = -60L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 9`` () =
    let actual = clamp -100L -40L -20L
    let expected = -40L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.clamp 10`` () =
    let actual = clamp -100L -40L -120L
    let expected = -100L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 1`` () =
    let actual = gap 0 100 80
    let expected = 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 2`` () =
    let actual = gap 0 100 120
    let expected = 20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 3`` () =
    let actual = gap 0 100 -60
    let expected = -60
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 4`` () =
    let actual = gap 60 100 40
    let expected = -20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 5`` () =
    let actual = gap -30. 100. -10.
    let expected = 0.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 6`` () =
    let actual = gap -30. 100. 120.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 7`` () =
    let actual = gap -30. 100. -50.
    let expected = -20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 8`` () =
    let actual = gap -100L -40L -60L
    let expected = 0L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 9`` () =
    let actual = gap -100L -40L -20L
    let expected = 20L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.gap 10`` () =
    let actual = gap -100L -40L -120L
    let expected = -20L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 1`` () =
    let actual = between 0 100 80
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 2`` () =
    let actual = between 0 100 120
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 3`` () =
    let actual = between 0 100 -60
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 4`` () =
    let actual = between 60 100 40
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 5`` () =
    let actual = between -30. 100. -10.
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 6`` () =
    let actual = between -30. 100. 120.
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 7`` () =
    let actual = between -30. 100. -50.
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 8`` () =
    let actual = between -100L -40L -60L
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 9`` () =
    let actual = between -100L -40L -20L
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.between 10`` () =
    let actual = between -100L -40L -120L
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 1`` () =
    let actual = within 0 100 80
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 2`` () =
    let actual = within 0 100 100
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 3`` () =
    let actual = within 0 100 120
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 4`` () =
    let actual = within 0 100 -80
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 5`` () =
    let actual = within 60. 10. 70.
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 6`` () =
    let actual = within 60. 10. 70.1
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 7`` () =
    let actual = within 20L 40L -20L
    let expected = true
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test Bound.within 8`` () =
    let actual = within 20L 40L -21L
    let expected = false
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.rebound 1`` () =
    let actual = rebound 0 100 80
    let expected = 80
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.rebound 2`` () =
    let actual = rebound 0. 100. 120.
    let expected = 80.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.rebound 3`` () =
    let actual = rebound 0L 100L -70L
    let expected = 70L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.rebound 4`` () =
    let actual = rebound -50 50 120
    let expected = -20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.rebound 5`` () =
    let actual = rebound -50. 50. 220.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.rebound 6`` () =
    let actual = rebound -50L 50L -260L
    let expected = -40L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.warp 1`` () =
    let actual = warp 0 100 80
    let expected = 80
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.warp 2`` () =
    let actual = warp 0. 100. 120.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.warp 3`` () =
    let actual = warp 0L 100L -70L
    let expected = 30L
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.warp 4`` () =
    let actual = warp -50 50 120
    let expected = 20
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.warp 5`` () =
    let actual = warp -50. 50. 220.
    let expected = 20.
    Assert.Equal(expected, actual)

[<Fact>]
let ``Bound.warp 6`` () =
    let actual = warp -50L 50L -260L
    let expected = 40L
    Assert.Equal(expected, actual)
