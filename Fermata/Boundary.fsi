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
        val inline clampGap:
          lower: ^a -> upper: ^a -> value: ^a -> ^a * ^a
            when ^a: comparison and ^a: (static member (-) : ^a * ^a -> ^a) and
                 ^a: (static member Zero: ^a)
        
        val inline clamp: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison
        
        val inline gap: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison and ^a: (static member (-) : ^a * ^a -> ^a) and
               ^a: (static member Zero: ^a)
        
        val inline between: earlier: ^a -> later: ^a -> value: ^a -> bool
          when ^a: comparison
        
        val inline within: center: ^a -> distance: ^a -> value: ^a -> bool
          when ^a: (static member (-) : ^a * ^a -> ^a) and
               ^a: (static member (+) : ^a * ^a -> ^a) and
               ^a: comparison
        
        val inline rebound: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison and ^a: (static member Zero : ^a) and
               ^a: (static member (-) : ^a * ^a -> ^a)
        
        val inline warp: lower: ^a -> upper: ^a -> value: ^a -> ^a
          when ^a: comparison and ^a: (static member (-) : ^a * ^a -> ^a) and
               ^a: (static member Zero : ^a) and
               ^a: (static member (+) : ^a * ^a -> ^a)

