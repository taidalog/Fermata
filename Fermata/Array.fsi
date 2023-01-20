namespace Fermata
    
    [<RequireQualifiedAccess>]
    module Array =
        
        /// <summary>Returns the array without the first element, or 
        /// returns <c>None</c> if the input array is empty.</summary>
        /// 
        /// <param name="array">The input array.</param>
        /// 
        /// <returns>The array without the first element, or 
        /// <c>None</c> if the input array is empty.</returns>
        /// 
        /// <example id="trytail-1">
        /// <code lang="fsharp">
        /// let inputs = [|0; 1; 2|]
        /// inputs |> Array.tryTail
        /// </code>
        /// Evaluates to <c>Some [|1; 2|]</c>
        /// </example>
        /// 
        /// <example id="trytail-2">
        /// <code lang="fsharp">
        /// let inputs : int[] = [||]
        /// inputs |> Array.tryTail
        /// </code>
        /// Evaluates to <c>None</c>
        /// </example>
        val tryTail: array: 'T array -> 'T array option

        val countWith: projection: ('T -> bool) -> array: 'T array -> int

        val trySkip: count: int -> array: 'T array -> 'T array option

        val filterIndex: projection: ('T -> bool) -> array: 'T array -> int array

