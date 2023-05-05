namespace Fermata
    
    module Boundary =
        
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
        /// 100 |> Math.clampGap 60 140
        /// </code>
        /// Evaluates to <c>(100, 0)</c>
        /// </example>
        /// 
        /// <example id="clampgap-2">
        /// <code lang="fsharp">
        /// 220. |> Math.clampGap 60. 140.
        /// </code>
        /// Evaluates to <c>(140.0, 80.0)</c>
        /// </example>
        /// 
        /// <example id="clampgap-3">
        /// <code lang="fsharp">
        /// -120L |> Math.clampGap -100L -20L
        /// </code>
        /// Evaluates to <c>(-100L, -20L)</c>
        /// </example>
        val inline clampGap: lower: ^a -> upper: ^a -> value: ^a -> ^a * ^a
            when ^a: comparison and ^a: (static member (-) : ^a * ^a -> ^a) and
                 ^a: (static member Zero: ^a)
        
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
        /// let value = 80
        /// value |> clamp 0 100
        /// </code>
        /// Evaluates to <c>80</c>
        /// </example>
        /// 
        /// <example id="clamp-2">
        /// <code lang="fsharp">
        /// let value = 120.
        /// value |> clamp 0. 100.
        /// </code>
        /// Evaluates to <c>100.</c>
        /// </example>
        /// 
        /// <example id="clamp-3">
        /// <code lang="fsharp">
        /// let value = -80L
        /// value |> clamp 0L 100L
        /// </code>
        /// Evaluates to <c>0L</c>
        /// </example>
        val inline clamp: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison
        
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
        /// let value = 80
        /// value |> gap 0 100
        /// </code>
        /// Evaluates to <c>0</c>
        /// </example>
        /// 
        /// <example id="gap-2">
        /// <code lang="fsharp">
        /// let value = 120.
        /// value |> gap 0. 100.
        /// </code>
        /// Evaluates to <c>20.</c>
        /// </example>
        /// 
        /// <example id="gap-3">
        /// <code lang="fsharp">
        /// let value = -80L
        /// value |> gap 0L 100L
        /// </code>
        /// Evaluates to <c>-80L</c>
        /// </example>
        val inline gap: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison and ^a: (static member (-) : ^a * ^a -> ^a) and
               ^a: (static member Zero: ^a)
        
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
        /// let value = 2
        /// value |> between 0 9
        /// </code>
        /// Evaluates to <c>true</c>
        /// </example>
        /// 
        /// <example id="between-2">
        /// <code lang="fsharp">
        /// let value = 0.8
        /// value |> between 5. 10.
        /// </code>
        /// Evaluates to <c>false</c>
        /// </example>
        val inline between: lower: ^a -> upper: ^a -> value: ^a -> bool
          when ^a: comparison
        
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
        /// let value = 2
        /// value |> within 0 5
        /// </code>
        /// Evaluates to <c>true</c>
        /// </example>
        /// 
        /// <example id="within-2">
        /// <code lang="fsharp">
        /// let value = 0.8
        /// value |> within 5. 10.
        /// </code>
        /// Evaluates to <c>true</c>
        /// </example>
        /// 
        /// <example id="within-3">
        /// <code lang="fsharp">
        /// let value = 3000L
        /// value |> within 10000L 5000L
        /// </code>
        /// Evaluates to <c>false</c>
        /// </example>
        val inline within: center: ^a -> distance: ^a -> value: ^a -> bool
          when ^a: (static member (-) : ^a * ^a -> ^a) and
               ^a: (static member (+) : ^a * ^a -> ^a) and
               ^a: comparison
        
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
        /// let value = 120
        /// value |> rebound 0 100
        /// </code>
        /// Evaluates to <c>80</c>
        /// </example>
        /// 
        /// <example id="rebound-2">
        /// <code lang="fsharp">
        /// let value = -70.
        /// value |> rebound 0. 100.
        /// </code>
        /// Evaluates to <c>70.</c>
        /// </example>
        /// 
        /// <example id="rebound-3">
        /// <code lang="fsharp">
        /// let value = 240L
        /// value |> rebound -100L 200L
        /// </code>
        /// Evaluates to <c>160L</c>
        /// </example>
        val inline rebound: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison and ^a: (static member Zero : ^a) and
               ^a: (static member (-) : ^a * ^a -> ^a)
        
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
        /// let value = 120
        /// value |> warp 0 100
        /// </code>
        /// Evaluates to <c>20</c>
        /// </example>
        /// 
        /// <example id="warp-2">
        /// <code lang="fsharp">
        /// let value = -70.
        /// value |> warp 0. 100.
        /// </code>
        /// Evaluates to <c>30.</c>
        /// </example>
        /// 
        /// <example id="warp-3">
        /// <code lang="fsharp">
        /// let value = 240L
        /// value |> warp -100L 200L
        /// </code>
        /// Evaluates to <c>-60L</c>
        /// </example>
        val inline warp: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison and ^a: (static member (-) : ^a * ^a -> ^a) and
               ^a: (static member Zero : ^a) and
               ^a: (static member (+) : ^a * ^a -> ^a)

