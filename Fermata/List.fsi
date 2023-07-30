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

    /// <summary>Returns a list of pairs of integer indexes (from 0) and the elements
    /// for which the given predicate returns true.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>A list of pairs of indexes and the elements that satisfy the predicate.</returns>
    ///
    /// <example id="filteri-1">
    /// <code lang="fsharp">
    /// let inputs = [ 42; 16; 8; 20; 120; 4 ]
    /// inputs |> List.filteri (fun x -> x % 10 = 0)
    /// </code>
    /// Evaluates to <c>[ (3, 20); (4, 120) ]</c>
    /// </example>
    val filteri: predicate: ('T -> bool) -> list: 'T list -> (int * 'T) list

    /// <summary>Returns a new list that contains the common elements to the two input lists.</summary>
    ///
    /// <param name="list1">The first input list.</param>
    ///
    /// <param name="list2">The second input list.</param>
    ///
    /// <returns>The list of elements common to the two input lists.</returns>
    ///
    /// <example id="intersect-1">
    /// <code lang="fsharp">
    /// let list1 = [0; 1; 2; 3; 4]
    /// let list2 = [0; 2; 4; 6; 8]
    /// List.intersect list1 list2
    /// </code>
    /// Evaluates to <c>[0; 2; 4]</c>
    /// </example>
    val intersect: list1: 'T list -> list2: 'T list -> 'T list when 'T: equality

    /// <summary>Splits the list into two lists before the first element for which the given predicate returns True.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>The result two lists.</returns>
    ///
    /// <example id="splitwith-1">
    /// <code lang="fsharp">
    /// let list = [0; 2; 4; 6; 8]
    /// list |> List.splitWith (fun x -> x > 5)
    /// </code>
    /// Evaluates to <c>([0; 2; 4], [6; 8])</c>
    /// </example>
    ///
    /// <example id="splitwith-2">
    /// <code lang="fsharp">
    /// let list = [0; 2; 5; 6; 8]
    /// list |> List.splitWith (fun x -> x % 2 = 1)
    /// </code>
    /// Evaluates to <c>([0; 2], [5; 6; 8])</c>
    /// </example>
    ///
    /// <example id="splitwith-3">
    /// <code lang="fsharp">
    /// let list = [0; 2; 5; 6; 8]
    /// list |> List.splitWith (fun x -> x % 2 = 2)
    /// </code>
    /// Evaluates to <c>([0; 2; 5; 6; 8], [])</c>
    /// </example>
    val splitWith: predicate: ('T -> bool) -> list: 'T list -> ('T list * 'T list)

    /// <summary>Returns a new list to which the specified value is prepended to be of the specified length.</summary>
    ///
    /// <param name="length">The length of the resulting list.</param>
    ///
    /// <param name="padding">The value to prepend to the list.</param>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>The resulting list.</returns>
    ///
    /// <example id="padleft-1">
    /// <code lang="fsharp">
    /// let list = ['2'; '4'; '6'; '8']
    /// list |> List.padLeft 8 '0'
    /// </code>
    /// Evaluates to <c>['0'; '0'; '0'; '0'; '2'; '4'; '6'; '8']</c>
    /// </example>
    val padLeft: length: int -> padding: 'T -> list: 'T list -> 'T list

    /// <summary>Returns a new list to which the specified value is appended to be of the specified length.</summary>
    ///
    /// <param name="length">The length of the resulting list.</param>
    ///
    /// <param name="padding">The value to append to the list.</param>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>The resulting list.</returns>
    ///
    /// <example id="padright-1">
    /// <code lang="fsharp">
    /// let list = ['2'; '4'; '6'; '8']
    /// list |> List.padRight 8 '0'
    /// </code>
    /// Evaluates to <c>['2'; '4'; '6'; '8'; '0'; '0'; '0'; '0']</c>
    /// </example>
    val padRight: length: int -> padding: 'T -> list: 'T list -> 'T list
