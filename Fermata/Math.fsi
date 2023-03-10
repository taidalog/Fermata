namespace Fermata
    
    module Math =
        
        /// <summary>
        /// Returns a tuple of <paramref name="value"/> clamped to the inclusive range of 
        /// <paramref name="min"/> and <paramref name="max"/>, 
        /// and the gap between <paramref name="value"/> and <paramref name="min"/> or <paramref name="max"/>.
        /// </summary>
        /// 
        /// <param name="min">The lower bound of the result.</param>
        /// 
        /// <param name="max">The upper bound of the result.</param>
        /// 
        /// <param name="value">The input value.</param>
        /// 
        /// <typeparam name="'a"></typeparam>
        /// 
        /// <returns>
        /// (<paramref name="min"/>, <paramref name="value"/> - <paramref name="min"/>)
        /// if <paramref name="value"/> is less than <paramref name="min"/>,
        /// (<paramref name="max"/>, <paramref name="value"/> - <paramref name="max"/>)
        /// if <paramref name="value"/> is greater than <paramref name="max"/>,
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
        val inline clampGap:
          min: ^a -> max: ^a -> value: ^a -> ^a * ^a
            when ^a: comparison and ^a: (static member (-) : ^a * ^a -> ^a) and
                 ^a: (static member Zero: ^a)