// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

module Bound =

    /// <summary>
    /// Returns a tuple of <paramref name="value"/> clamped to the inclusive range of
    /// <paramref name="lower"/> and <paramref name="upper"/>,
    /// and the gap between <paramref name="value"/> and <paramref name="lower"/> or <paramref name="upper"/>.
    /// </summary>
    ///
    /// <param name="lower">The lower bound of the result.</param>
    ///
    /// <param name="upper">The upper bound of the result.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <typeparam name="'a"></typeparam>
    ///
    /// <returns>
    /// (<paramref name="lower"/>, <paramref name="value"/> - <paramref name="lower"/>)
    /// if <paramref name="value"/> is less than <paramref name="lower"/>,
    /// (<paramref name="upper"/>, <paramref name="value"/> - <paramref name="upper"/>)
    /// if <paramref name="value"/> is greater than <paramref name="upper"/>,
    /// (<paramref name="value"/>, 0) otherwise (0 is of the type of <paramref name="value"/>)
    /// </returns>
    ///
    /// <example id="clampgap-1">
    /// <code lang="fsharp">
    /// 80 |> clampGap 0 100
    /// </code>
    /// Evaluates to <c>(80, 0)</c>
    /// </example>
    ///
    /// <example id="clampgap-2">
    /// <code lang="fsharp">
    /// 120. |> clampGap -30. 100.
    /// </code>
    /// Evaluates to <c>(100.0, 20.0)</c>
    /// </example>
    ///
    /// <example id="clampgap-3">
    /// <code lang="fsharp">
    /// -120L |> clampGap -100L -20L
    /// </code>
    /// Evaluates to <c>(-100L, -20L)</c>
    /// </example>
    val inline clampGap:
        lower: ^a -> upper: ^a -> value: ^a -> ^a * ^a
            when ^a: comparison and ^a: (static member (-): ^a * ^a -> ^a) and ^a: (static member Zero: ^a)

    /// <summary>Returns <paramref name="value"/> clamped to the inclusive range of <paramref name="lower"/> and <paramref name="upper"/></summary>
    ///
    /// <param name="lower">The lower bound of the result.</param>
    ///
    /// <param name="upper">The upper bound of the result.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <returns>The clamped value.</returns>
    ///
    /// <example id="clamp-1">
    /// <code lang="fsharp">
    /// 80 |> clamp 0 100
    /// </code>
    /// Evaluates to <c>80</c>
    /// </example>
    ///
    /// <example id="clamp-2">
    /// <code lang="fsharp">
    /// 120. |> clamp -30. 100.
    /// </code>
    /// Evaluates to <c>100.</c>
    /// </example>
    ///
    /// <example id="clamp-3">
    /// <code lang="fsharp">
    /// -120L |> clamp -100L -20L
    /// </code>
    /// Evaluates to <c>-100L</c>
    /// </example>
    val inline clamp: lower: ^a -> upper: ^a -> value: ^a -> ^a when ^a: comparison

    /// <summary>Returns a gap between <paramref name="value"/> and <paramref name="lower"/> or <paramref name="value"/> and <paramref name="upper"/></summary>
    ///
    /// <param name="lower">The lower bound of the result.</param>
    ///
    /// <param name="upper">The upper bound of the result.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <returns>Returns a gap between <paramref name="value"/> and <paramref name="lower"/> if <paramref name="value"/> is less than <paramref name="lower"/>,
    /// or a gap between <paramref name="value"/> and <paramref name="upper"/> if <paramref name="value"/> is greater than <paramref name="upper"/>,
    /// otherwise <c>0</c></returns>
    ///
    /// <example id="gap-1">
    /// <code lang="fsharp">
    /// 80 |> gap 0 100
    /// </code>
    /// Evaluates to <c>0</c>
    /// </example>
    ///
    /// <example id="gap-2">
    /// <code lang="fsharp">
    /// 120. |> gap -30. 100.
    /// </code>
    /// Evaluates to <c>20.</c>
    /// </example>
    ///
    /// <example id="gap-3">
    /// <code lang="fsharp">
    /// -120L |> gap -100L -40L
    /// </code>
    /// Evaluates to <c>-20L</c>
    /// </example>
    val inline gap:
        lower: ^a -> upper: ^a -> value: ^a -> ^a
            when ^a: comparison and ^a: (static member (-): ^a * ^a -> ^a) and ^a: (static member Zero: ^a)

    /// <summary>Returns true if the input value is between <paramref name="lower"/> and <paramref name="upper"/>, otherwise false.</summary>
    ///
    /// <param name="lower">The lower bound of the result.</param>
    ///
    /// <param name="upper">The upper bound of the result.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <returns>True if the input value is between <paramref name="lower"/> and <paramref name="upper"/>, otherwise false</returns>
    ///
    /// <example id="between-1">
    /// <code lang="fsharp">
    /// 80 |> between 0 100
    /// </code>
    /// Evaluates to <c>true</c>
    /// </example>
    ///
    /// <example id="between-2">
    /// <code lang="fsharp">
    /// 120. |> between -30. 100.
    /// </code>
    /// Evaluates to <c>false</c>
    /// </example>
    ///
    /// <example id="between-3">
    /// <code lang="fsharp">
    /// -60L |> between -100L -40L
    /// </code>
    /// Evaluates to <c>true</c>
    /// </example>
    val inline between: lower: ^a -> upper: ^a -> value: ^a -> bool when ^a: comparison

    /// <summary>Returns true if <paramref name="value"/> is within <paramref name="distance"/> from <paramref name="center"/>, otherwise false.</summary>
    ///
    /// <param name="center">The center of the range.</param>
    ///
    /// <param name="distance">The distance from <paramref name="center"/>.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <returns>True if <paramref name="value"/> is within <paramref name="distance"/> from <paramref name="center"/>, otherwise false.</returns>
    ///
    /// <example id="within-1">
    /// <code lang="fsharp">
    /// 80 |> within 0 100
    /// </code>
    /// Evaluates to <c>true</c>
    /// </example>
    ///
    /// <example id="within-2">
    /// <code lang="fsharp">
    /// 70. |> within 60. 10.
    /// </code>
    /// Evaluates to <c>true</c>
    /// </example>
    ///
    /// <example id="within-3">
    /// <code lang="fsharp">
    /// -21L |> within 20L 40L
    /// </code>
    /// Evaluates to <c>false</c>
    /// </example>
    val inline within:
        center: ^a -> distance: ^a -> value: ^a -> bool
            when ^a: (static member (-): ^a * ^a -> ^a) and ^a: (static member (+): ^a * ^a -> ^a) and ^a: comparison

    /// <summary>
    /// Returns <paramref name="value"/> the **rebounded** within the inclusive range of <paramref name="lower"/> and <paramref name="upper"/>.
    /// The **rebounded** value is (<paramref name="lower"/> - (<paramref name="lower"/> - <paramref name="value"/>)) if <paramref name="value"/> is less than <paramref name="lower"/>.
    /// The **rebounded** value is (<paramref name="upper"/> - (<paramref name="value"/> - <paramref name="upper"/>)) if <paramref name="value"/> is greater than <paramref name="upper"/>.
    /// Computation is done recursively if the result is still out of bounds.
    /// </summary>
    ///
    /// <param name="lower">The lower bound of the result.</param>
    ///
    /// <param name="upper">The upper bound of the result.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <returns>The resulting value.</returns>
    ///
    /// <example id="rebound-1">
    /// <code lang="fsharp">
    /// 120 |> rebound 0 100
    /// </code>
    /// Evaluates to <c>80</c>
    /// </example>
    ///
    /// <example id="rebound-2">
    /// <code lang="fsharp">
    /// -70. |> rebound 0. 100.
    /// </code>
    /// Evaluates to <c>70.</c>
    /// </example>
    ///
    /// <example id="rebound-3">
    /// <code lang="fsharp">
    /// 120 |> rebound -50 50
    /// </code>
    /// Evaluates to <c>-20</c>
    /// </example>
    ///
    /// <example id="rebound-4">
    /// <code lang="fsharp">
    /// -260L |> rebound -50L 50L
    /// </code>
    /// Evaluates to <c>-40L</c>
    /// </example>
    val inline rebound:
        lower: ^a -> upper: ^a -> value: ^a -> ^a
            when ^a: comparison and ^a: (static member Zero: ^a) and ^a: (static member (-): ^a * ^a -> ^a)

    /// <summary>
    /// Returns <paramref name="value"/> the **warped** within the inclusive range of <paramref name="lower"/> and <paramref name="upper"/>.
    /// The **warped** value is (<paramref name="upper"/> + (<paramref name="lower"/> - <paramref name="value"/>)) if <paramref name="value"/> is less than <paramref name="lower"/>.
    /// The **warped** value is (<paramref name="lower"/> + (<paramref name="value"/> - <paramref name="upper"/>)) if <paramref name="value"/> is greater than <paramref name="upper"/>.
    /// Computation is done recursively if the result is still out of bounds.
    /// </summary>
    ///
    /// <param name="lower">The lower bound of the result.</param>
    ///
    /// <param name="upper">The upper bound of the result.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <returns>The resulting value.</returns>
    ///
    /// <example id="warp-1">
    /// <code lang="fsharp">
    /// 120 |> warp 0 100
    /// </code>
    /// Evaluates to <c>20</c>
    /// </example>
    ///
    /// <example id="warp-2">
    /// <code lang="fsharp">
    /// -70. |> warp 0. 100.
    /// </code>
    /// Evaluates to <c>30.</c>
    /// </example>
    ///
    /// <example id="warp-3">
    /// <code lang="fsharp">
    /// 120 |> warp -50 50
    /// </code>
    /// Evaluates to <c>20</c>
    /// </example>
    ///
    /// <example id="rebound-4">
    /// <code lang="fsharp">
    /// -260L |> warp -50L 50L
    /// </code>
    /// Evaluates to <c>40L</c>
    /// </example>
    val inline warp:
        lower: ^a -> upper: ^a -> value: ^a -> ^a
            when ^a: comparison
            and ^a: (static member (-): ^a * ^a -> ^a)
            and ^a: (static member Zero: ^a)
            and ^a: (static member (+): ^a * ^a -> ^a)
