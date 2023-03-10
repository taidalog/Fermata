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

        /// <summary>Returns the number of elements of the list for which the given predicate returns true.</summary>
        /// 
        /// <param name="predicate">The function to test the input elements.</param>
        /// 
        /// <param name="list">The input list.</param>
        /// 
        /// <returns>The number of elements of the list for which the given predicate returns true.</returns>
        /// 
        /// <example id="countwith-1">
        /// <code lang="fsharp">
        /// let inputs = ["Laziness"; "Impatience"; "Hubris"]
        /// inputs |> List.countWith (fun x -> String.length x > 6)
        /// </code>
        /// Evaluates to <c>2</c>
        /// </example>
        /// 
        /// <example id="countwith-2">
        /// <code lang="fsharp">
        /// let inputs = ["Laziness"; "Impatience"; "Hubris"]
        /// inputs |> List.countWith (fun x -> String.length x < 0)
        /// </code>
        /// Evaluates to <c>0</c>
        /// </example>
        val countWith: predicate: ('T -> bool) -> list: 'T list -> int

        /// <summary>Returns the list without the first N element, or 
        /// returns <c>None</c> if the N exceeds the length of the input list.</summary>
        /// 
        /// <param name="count">The number of elements to skip.</param>
        /// 
        /// <param name="list">The input list.</param>
        /// 
        /// <returns>The list without the first N element, or 
        /// <c>None</c> if the N exceeds the length of the input list.</returns>
        /// 
        /// <example id="tryskip-1">
        /// <code lang="fsharp">
        /// let inputs = [0; 1; 2; 3; 4; 5]
        /// inputs |> List.trySkip 3
        /// </code>
        /// Evaluates to <c>Some [3; 4; 5]</c>
        /// </example>
        /// 
        /// <example id="tryskip-2">
        /// <code lang="fsharp">
        /// let inputs = [0; 1]
        /// inputs |> List.trySkip 3
        /// </code>
        /// Evaluates to <c>None</c>
        /// </example>
        val trySkip: count: int -> list: 'T list -> 'T list option

        /// <summary>Returns a list of integer indexes (from 0) of the elements of the list
        /// for which the given predicate returns true.</summary>
        /// 
        /// <param name="predicate">The function to test the input elements.</param>
        /// 
        /// <param name="list">The input list.</param>
        /// 
        /// <returns>A list of indexes of the elements that satisfy the predicate.</returns>
        /// 
        /// <example id="filterindex-1">
        /// <code lang="fsharp">
        /// let inputs = ["A"; "B"; "A"; "C"; "C"; "A"]
        /// inputs |> List.filterIndex (fun x -> x = "A")
        /// </code>
        /// Evaluates to <c>[0; 2; 5]</c>
        /// </example>
        /// 
        /// <example id="filterindex-2">
        /// <code lang="fsharp">
        /// let inputs = ["A"; "B"; "A"; "C"; "C"; "A"]
        /// inputs |> List.filterIndex (fun x -> x = "Z")
        /// </code>
        /// Evaluates to <c>[]</c>
        /// </example>
        val filterIndex: predicate: ('T -> bool) -> list: 'T list -> int list

