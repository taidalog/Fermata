namespace Fermata
    
    [<RequireQualifiedAccess>]
    module List =
        
        /// <summary>Returns the list without the first element, or 
        /// returns <c>None</c> if the input list is empty.</summary>
        /// 
        /// <param name="list">The input list.</param>
        /// 
        /// <returns>The list without the first element, or 
        /// <c>None</c> if the input list is empty.</returns>
        /// 
        /// <example id="trytail-1">
        /// <code lang="fsharp">
        /// let inputs = [0; 1; 2]
        /// inputs |> List.tryTail
        /// </code>
        /// Evaluates to <c>Some [1; 2]</c>
        /// </example>
        /// 
        /// <example id="trytail-2">
        /// <code lang="fsharp">
        /// let inputs : int list = []
        /// inputs |> List.tryTail
        /// </code>
        /// Evaluates to <c>None</c>
        /// </example>
        val tryTail: list: 'T list -> 'T list option

