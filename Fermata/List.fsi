// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

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

    /// <summary>Returns the list without the last element.</summary>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>The list without the last element.</returns>
    ///
    /// <example id="List.fore-1">
    /// <code lang="fsharp">
    /// let inputs = [ 0; 1; 2 ]
    /// inputs |> List.fore
    /// </code>
    /// Evaluates to <c>[ 0; 1 ]</c>
    /// </example>
    val fore: list: 'T list -> 'T list

    /// <summary>Returns the list without the last element, or
    /// returns <c>None</c> if the input array is empty.</summary>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>The list without the last element, or
    /// returns <c>None</c> if the input array is empty.</returns>
    ///
    /// <example id="List.tryFore-1">
    /// <code lang="fsharp">
    /// let inputs = [ 0; 1; 2 ]
    /// inputs |> List.tryFore
    /// </code>
    /// Evaluates to <c>Some [ 0; 1 ]</c>
    /// </example>
    ///
    /// <example id="List.tryFore-2">
    /// <code lang="fsharp">
    /// let inputs: int list = []
    /// inputs |> List.tryFore
    /// </code>
    /// Evaluates to <c>None</c>
    /// </example>
    val tryFore: list: 'T list -> 'T list option

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

    /// <summary>Return the number of the occurrences of an item before itself in a list.</summary>
    ///
    /// <param name="index">The index of the item to count.</param>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>The number of the occurrences of an item before itself in a list.</returns>
    ///
    /// <example id="List.countBefore-1">
    /// <code lang="fsharp">
    /// [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countBefore 0
    /// </code>
    /// Evaluates to <c>0</c>
    /// </example>
    ///
    /// <example id="List.countBefore-2">
    /// <code lang="fsharp">
    /// [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countBefore 2
    /// </code>
    /// Evaluates to <c>1</c>
    /// </example>
    ///
    /// <example id="List.countBefore-3">
    /// <code lang="fsharp">
    /// [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countBefore 5
    /// </code>
    /// Evaluates to <c>2</c>
    /// </example>
    val countBefore: index: int -> list: 'T list -> int when 'T: equality

    /// <summary>Return the number of the occurrences of an item after itself in a list.</summary>
    ///
    /// <param name="index">The index of the item to count.</param>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>The number of the occurrences of an item after itself in a list.</returns>
    ///
    /// <example id="List.countAfter-1">
    /// <code lang="fsharp">
    /// [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countAfter 0
    /// </code>
    /// Evaluates to <c>2</c>
    /// </example>
    ///
    /// <example id="List.countAfter-2">
    /// <code lang="fsharp">
    /// [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countAfter 2
    /// </code>
    /// Evaluates to <c>1</c>
    /// </example>
    ///
    /// <example id="List.countAfter-3">
    /// <code lang="fsharp">
    /// [ 'a'; 'b'; 'a'; 'c'; 'b'; 'a' ] |> List.countAfter 5
    /// </code>
    /// Evaluates to <c>0</c>
    /// </example>
    val countAfter: index: int -> list: 'T list -> int when 'T: equality

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

    /// <summary>Returns a new collection containing only the elements of the collection for which the given predicate returns "true". The integer index passed to the function indicates the index (from 0) of element being filtered.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="list">The input list.</param>
    ///
    /// <returns>A list containing only the elements that satisfy the predicate.</returns>
    ///
    /// <example id="List.filteri-1">
    /// <code lang="fsharp">
    /// [ 0; 2; 6; 7; 9; 12 ] |> List.filteri (fun i x -> (i * x) % 2 = 0)
    /// </code>
    /// Evaluates to <c>[ 0; 2; 6; 9; 12 ]</c>
    /// </example>
    ///
    /// <example id="List.filteri-2">
    /// <code lang="fsharp">
    /// [ "hey"; "F#"; "" ] |> List.filteri (fun i x -> (i * String.length x) < 0)
    /// </code>
    /// Evaluates to <c>[]</c>
    /// </example>
    val filteri: predicate: (int -> 'T -> bool) -> list: 'T list -> 'T list

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
    /// <example id="filterindexpair-1">
    /// <code lang="fsharp">
    /// let inputs = [ 42; 16; 8; 20; 120; 4 ]
    /// inputs |> List.filterIndexPair (fun x -> x % 10 = 0)
    /// </code>
    /// Evaluates to <c>[ (3, 20); (4, 120) ]</c>
    /// </example>
    ///
    /// <example id="filterindexpair-2">
    /// <code lang="fsharp">
    /// let inputs = [ 42; 16; 8; 20; 120; 4 ]
    /// inputs |> List.filterIndexPair (fun x -> x % 2 = 1)
    /// </code>
    /// Evaluates to <c>[]</c>
    /// </example>
    val filterIndexPair: predicate: ('T -> bool) -> list: 'T list -> (int * 'T) list

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

    /// <summary>Returns a new list of lists. The first list contains only the first element of the input list, and the last list contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ i0 ]; [ i0; i1 ]; ... [ i0; ... iN ] ]</c></summary>
    ///
    /// <param name="list"></param>
    ///
    /// <returns>A new list of lists. The first list contains only the first element of the input list, and the last list contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ i0 ]; [ i0; i1 ]; ... [ i0; ... iN ] ]</c></returns>
    ///
    /// <example id="List.stairs-1">
    /// <code lang="fsharp">
    /// List.stairs [ 0..4 ]
    /// </code>
    /// Evaluates to <c>[ [ 0 ]; [ 0; 1 ]; [ 0; 1; 2 ]; [ 0; 1; 2; 3 ]; [ 0; 1; 2; 3; 4 ] ]</c>
    /// </example>
    ///
    /// <example id="List.stairs-2">
    /// <code lang="fsharp">
    /// let input: int list = []
    /// input |> List.stairs
    /// </code>
    /// Evaluates to <c>[]</c>
    /// </example>
    val stairs: list: 'T list -> 'T list list

    /// <summary>Returns a new list of lists. The first list contains only the last element of the input list, and the last list contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ iN ]; [ iN-1; iN ]; ... [ i0; ... iN ] ]</c></summary>
    ///
    /// <param name="list"></param>
    ///
    /// <returns>A new list of lists. The first list contains only the last element of the input list, and the last list contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ iN ]; [ iN-1; iN ]; ... [ i0; ... iN ] ]</c></returns>
    ///
    /// <example id="List.stairsBack-1">
    /// <code lang="fsharp">
    /// List.stairsBack [ 0..4 ]
    /// </code>
    /// Evaluates to <c>[ [ 4 ]; [ 3; 4 ]; [ 2; 3; 4 ]; [ 1; 2; 3; 4 ]; [ 0; 1; 2; 3; 4 ] ]</c>
    /// </example>
    ///
    /// <example id="List.stairsBack-2">
    /// <code lang="fsharp">
    /// let input: int list = []
    /// input |> List.stairsBack
    /// </code>
    /// Evaluates to <c>[]</c>
    /// </example>
    val stairsBack: list: 'T list -> 'T list list
