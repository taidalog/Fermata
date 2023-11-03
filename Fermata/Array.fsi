// Fermata Version 0.7.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

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

    /// <summary>Returns the array without the last element.</summary>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The array without the last element.</returns>
    ///
    /// <example id="Array.fore-1">
    /// <code lang="fsharp">
    /// let inputs = [| 0; 1; 2 |]
    /// inputs |> Array.fore
    /// </code>
    /// Evaluates to <c>[| 0; 1 |]</c>
    /// </example>
    val fore: array: 'T array -> 'T array

    /// <summary>Returns the array without the last element, or
    /// returns <c>None</c> if the input array is empty.</summary>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The array without the last element, or
    /// returns <c>None</c> if the input array is empty.</returns>
    ///
    /// <example id="Array.tryFore-1">
    /// <code lang="fsharp">
    /// let inputs = [| 0; 1; 2 |]
    /// inputs |> Array.tryFore
    /// </code>
    /// Evaluates to <c>Some [| 0; 1 |]</c>
    /// </example>
    ///
    /// <example id="Array.tryFore-2">
    /// <code lang="fsharp">
    /// let inputs: int[] = [||]
    /// inputs |> Array.tryFore
    /// </code>
    /// Evaluates to <c>None</c>
    /// </example>
    val tryFore: array: 'T array -> 'T array option

    /// <summary>Returns the number of elements of the array for which the given predicate returns true.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The number of elements of the array for which the given predicate returns true.</returns>
    ///
    /// <example id="countwith-1">
    /// <code lang="fsharp">
    /// let inputs = [|"Laziness"; "Impatience"; "Hubris"|]
    /// inputs |> Array.countWith (fun x -> String.length x > 6)
    /// </code>
    /// Evaluates to <c>2</c>
    /// </example>
    ///
    /// <example id="countwith-2">
    /// <code lang="fsharp">
    /// let inputs = [|"Laziness"; "Impatience"; "Hubris"|]
    /// inputs |> Array.countWith (fun x -> String.length x < 0)
    /// </code>
    /// Evaluates to <c>0</c>
    /// </example>
    val countWith: predicate: ('T -> bool) -> array: 'T array -> int

    /// <summary>Return the number of the occurrences of an item before itself in an array.</summary>
    ///
    /// <param name="index">The index of the item to count.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The number of the occurrences of an item before itself in an array.</returns>
    ///
    /// <example id="Array.countBefore-1">
    /// <code lang="fsharp">
    /// [| 'a'; 'b'; 'a'; 'c'; 'b'; 'a' |] |> Array.countBefore 0
    /// </code>
    /// Evaluates to <c>0</c>
    /// </example>
    ///
    /// <example id="Array.countBefore-2">
    /// <code lang="fsharp">
    /// [| 'a'; 'b'; 'a'; 'c'; 'b'; 'a' |] |> Array.countBefore 2
    /// </code>
    /// Evaluates to <c>1</c>
    /// </example>
    ///
    /// <example id="Array.countBefore-3">
    /// <code lang="fsharp">
    /// [| 'a'; 'b'; 'a'; 'c'; 'b'; 'a' |] |> Array.countBefore 5
    /// </code>
    /// Evaluates to <c>2</c>
    /// </example>
    val countBefore: index: int -> array: 'T array -> int when 'T: equality

    /// <summary>Return the number of the occurrences of an item after itself in an array.</summary>
    ///
    /// <param name="index">The index of the item to count.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The number of the occurrences of an item after itself in an array.</returns>
    ///
    /// <example id="Array.countAfter-1">
    /// <code lang="fsharp">
    /// [| 'a'; 'b'; 'a'; 'c'; 'b'; 'a' |] |> Array.countAfter 0
    /// </code>
    /// Evaluates to <c>2</c>
    /// </example>
    ///
    /// <example id="Array.countAfter-2">
    /// <code lang="fsharp">
    /// [| 'a'; 'b'; 'a'; 'c'; 'b'; 'a' |] |> Array.countAfter 2
    /// </code>
    /// Evaluates to <c>1</c>
    /// </example>
    ///
    /// <example id="Array.countAfter-3">
    /// <code lang="fsharp">
    /// [| 'a'; 'b'; 'a'; 'c'; 'b'; 'a' |] |> Array.countAfter 5
    /// </code>
    /// Evaluates to <c>0</c>
    /// </example>
    val countAfter: index: int -> array: 'T array -> int when 'T: equality

    /// <summary>Returns the array without the first N element, or
    /// returns <c>None</c> if the N exceeds the length of the input array.</summary>
    ///
    /// <param name="count">The number of elements to skip.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The array without the first N element, or
    /// <c>None</c> if the N exceeds the length of the input array.</returns>
    ///
    /// <example id="tryskip-1">
    /// <code lang="fsharp">
    /// let inputs = [|0; 1; 2; 3; 4; 5|]
    /// inputs |> Array.trySkip 3
    /// </code>
    /// Evaluates to <c>Some [|3; 4; 5|]</c>
    /// </example>
    ///
    /// <example id="tryskip-2">
    /// <code lang="fsharp">
    /// let inputs = [|0; 1|]
    /// inputs |> Array.trySkip 3
    /// </code>
    /// Evaluates to <c>None</c>
    /// </example>
    val trySkip: count: int -> array: 'T array -> 'T array option

    /// <summary>Returns a new collection containing only the elements of the collection for which the given predicate returns "true". The integer index passed to the function indicates the index (from 0) of element being filtered.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>An array containing only the elements that satisfy the predicate.</returns>
    ///
    /// <example id="Array.filteri-1">
    /// <code lang="fsharp">
    /// [| 0; 2; 6; 7; 9; 12 |] |> Array.filteri (fun i x -> (i * x) % 2 = 0)
    /// </code>
    /// Evaluates to <c>[| 0; 2; 6; 9; 12 |]</c>
    /// </example>
    ///
    /// <example id="Array.filteri-2">
    /// <code lang="fsharp">
    /// [| "hey"; "F#"; "" |] |> Array.filteri (fun i x -> (i * String.length x) < 0)
    /// </code>
    /// Evaluates to <c>[||]</c>
    /// </example>
    val filteri: predicate: (int -> 'T -> bool) -> array: 'T array -> 'T array

    /// <summary>Returns an array of integer indexes (from 0) of the elements of the array
    /// for which the given predicate returns true.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>An array of indexes of the elements that satisfy the predicate.</returns>
    ///
    /// <example id="filterindex-1">
    /// <code lang="fsharp">
    /// let inputs = [|"A"; "B"; "A"; "C"; "C"; "A"|]
    /// inputs |> Array.filterIndex (fun x -> x = "A")
    /// </code>
    /// Evaluates to <c>[|0; 2; 5|]</c>
    /// </example>
    ///
    /// <example id="filterindex-2">
    /// <code lang="fsharp">
    /// let inputs = [|"A"; "B"; "A"; "C"; "C"; "A"|]
    /// inputs |> Array.filterIndex (fun x -> x = "Z")
    /// </code>
    /// Evaluates to <c>[||]</c>
    /// </example>
    val filterIndex: predicate: ('T -> bool) -> array: 'T array -> int array

    /// <summary>Returns an array of pairs of integer indexes (from 0) and the elements
    /// for which the given predicate returns true.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>An array of pairs of indexes and the elements that satisfy the predicate.</returns>
    ///
    /// <example id="filterindexpair-1">
    /// <code lang="fsharp">
    /// let inputs = [| 42; 16; 8; 20; 120; 4 |]
    /// inputs |> Array.filterIndexPair (fun x -> x % 10 = 0)
    /// </code>
    /// Evaluates to <c>[| (3, 20); (4, 120) |]</c>
    /// </example>
    ///
    /// <example id="filterindexpair-2">
    /// <code lang="fsharp">
    /// let inputs = [| 42; 16; 8; 20; 120; 4 |]
    /// inputs |> Array.filterIndexPair (fun x -> x % 2 = 1)
    /// </code>
    /// Evaluates to <c>[||]</c>
    /// </example>
    val filterIndexPair: predicate: ('T -> bool) -> array: 'T array -> (int * 'T) array

    /// <summary>Returns a new array that contains the common elements to the two input arrays.</summary>
    ///
    /// <param name="array1">The first input array.</param>
    ///
    /// <param name="array2">The second input array.</param>
    ///
    /// <returns>The array of elements common to the two input arrays.</returns>
    ///
    /// <example id="intersect-1">
    /// <code lang="fsharp">
    /// let array1 = [|0; 1; 2; 3; 4|]
    /// let array2 = [|0; 2; 4; 6; 8|]
    /// Array.intersect array1 array2
    /// </code>
    /// Evaluates to <c>[|0; 2; 4|]</c>
    /// </example>
    ///
    /// <example id="intersect-2">
    /// <code lang="fsharp">
    /// let array1 = [| 0; 1; 2; 3; 4 |]
    /// let array2 = [| 5; 6; 7; 8; 9 |]
    /// Array.intersect array1 array2
    /// </code>
    /// Evaluates to <c>[||]</c>
    /// </example>
    ///
    /// <example id="intersect-3">
    /// <code lang="fsharp">
    /// let array1 = [| 0; 1; 2; 3; 4 |]
    /// let array2 = [||]
    /// Array.intersect array1 array2
    /// </code>
    /// Evaluates to <c>[||]</c>
    /// </example>
    val intersect: array1: 'T array -> array2: 'T array -> 'T array when 'T: equality

    /// <summary>Splits the array into two arrays before the first element for which the given predicate returns True.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The result two arrays.</returns>
    ///
    /// <example id="splitwith-1">
    /// <code lang="fsharp">
    /// let array = [|0; 2; 4; 6; 8|]
    /// array |> Array.splitWith (fun x -> x > 5)
    /// </code>
    /// Evaluates to <c>([|0; 2; 4|], [|6; 8|])</c>
    /// </example>
    ///
    /// <example id="splitwith-2">
    /// <code lang="fsharp">
    /// let array = [|0; 2; 5; 6; 8|]
    /// array |> Array.splitWith (fun x -> x % 2 = 1)
    /// </code>
    /// Evaluates to <c>([|0; 2|], [|5; 6; 8|])</c>
    /// </example>
    ///
    /// <example id="splitwith-3">
    /// <code lang="fsharp">
    /// let array = [|0; 2; 5; 6; 8|]
    /// array |> Array.splitWith (fun x -> x % 2 = 2)
    /// </code>
    /// Evaluates to <c>([|0; 2; 5; 6; 8|], [||]|])</c>
    /// </example>
    val splitWith: predicate: ('T -> bool) -> array: 'T[] -> ('T[] * 'T[])

    /// <summary>Returns a new array to which the specified value is prepended to be of the specified length.</summary>
    ///
    /// <param name="length">The length of the resulting array.</param>
    ///
    /// <param name="padding">The value to prepend to the array.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The resulting array.</returns>
    ///
    /// <example id="padleft-1">
    /// <code lang="fsharp">
    /// let array = [|'2'; '4'; '6'; '8'|]
    /// array |> Array.padLeft 8 '0'
    /// </code>
    /// Evaluates to <c>[|'0'; '0'; '0'; '0'; '2'; '4'; '6'; '8'|]</c>
    /// </example>
    ///
    /// <example id="padleft-2">
    /// <code lang="fsharp">
    /// let array = [||]
    /// array |> Array.padLeft 4 0
    /// </code>
    /// Evaluates to <c>[| 0; 0; 0; 0 |]</c>
    /// </example>
    val padLeft: length: int -> padding: 'T -> array: 'T[] -> 'T[]

    /// <summary>Returns a new array to which the specified value is appended to be of the specified length.</summary>
    ///
    /// <param name="length">The length of the resulting array.</param>
    ///
    /// <param name="padding">The value to append to the array.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The resulting array.</returns>
    ///
    /// <example id="padright-1">
    /// <code lang="fsharp">
    /// let array = [|'2'; '4'; '6'; '8'|]
    /// array |> Array.padRight 8 '0'
    /// </code>
    /// Evaluates to <c>[|'2'; '4'; '6'; '8'; '0'; '0'; '0'; '0'|]</c>
    /// </example>
    ///
    /// <example id="padright-2">
    /// <code lang="fsharp">
    /// let array = [||]
    /// array |> Array.padRight 4 0
    /// </code>
    /// Evaluates to <c>[| 0; 0; 0; 0 |]</c>
    /// </example>
    val padRight: length: int -> padding: 'T -> array: 'T[] -> 'T[]

    /// <summary>Returns a new array of arrays. The first array contains only the first element of the input array, and the last array contains all the original elements. If the elements are <c>[| i0..iN |]</c>, retuens <c>[| [| i0 |]; [| i0; i1 |]; ... [| i0; ... iN |] |]</c></summary>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>A new array of arrays. The first array contains only the first element of the input array, and the last array contains all the original elements. If the elements are <c>[| i0..iN |]</c>, retuens <c>[| [| i0 |]; [| i0; i1 |]; ... [| i0; ... iN |] |]</c></returns>
    ///
    /// <example id="Array.stairs-1">
    /// <code lang="fsharp">
    /// Array.stairs [| 0..4 |]
    /// </code>
    /// Evaluates to <c>[| [| 0 |]; [| 0; 1 |]; [| 0; 1; 2 |]; [| 0; 1; 2; 3 |]; [| 0; 1; 2; 3; 4 |] |]</c>
    /// </example>
    ///
    /// <example id="Array.stairs-2">
    /// <code lang="fsharp">
    /// let input: int[] = [||]
    /// input |> Array.stairs
    /// </code>
    /// Evaluates to <c>[||]</c>
    /// </example>
    val stairs: array: 'T array -> 'T array array

    /// <summary>Returns a new array of arrays. The first array contains only the last element of the input array, and the last array contains all the original elements. If the elements are <c>[| i0..iN |]</c>, retuens <c>[| [| iN |]; [| iN-1; iN |]; ... [| i0; ... iN |] |]</c></summary>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>A new array of arrays. The first array contains only the last element of the input array, and the last array contains all the original elements. If the elements are <c>[| i0..iN |]</c>, retuens <c>[| [| iN |]; [| iN-1; iN |]; ... [| i0; ... iN |] |]</c></returns>
    ///
    /// <example id="Array.stairsBack-1">
    /// <code lang="fsharp">
    /// Array.stairsBack [| 0..4 |]
    /// </code>
    /// Evaluates to <c>[| [| 4 |]; [| 3; 4 |]; [| 2; 3; 4 |]; [| 1; 2; 3; 4 |]; [| 0; 1; 2; 3; 4 |] |]</c>
    /// </example>
    ///
    /// <example id="Array.stairsBack-2">
    /// <code lang="fsharp">
    /// let input: int[] = [||]
    /// input |> Array.stairsBack
    /// </code>
    /// Evaluates to <c>[||]</c>
    /// </example>
    val stairsBack: array: 'T array -> 'T array array

    /// <summary>Splits the input array before the elements for which the given predicate returns True.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="array">The input array.</param>
    ///
    /// <returns>The input array before the elements for which the given predicate returns True.</returns>
    ///
    /// <example id="Array.splits-1">
    /// <code lang="fsharp">
    /// "AAAABBCDDCAA" |> Seq.toArray |> Array.splits (<>)
    /// </code>
    /// Evaluates to <c>[| [| 'A'; 'A'; 'A'; 'A' |]; [| 'B'; 'B' |]; [| 'C' |]; [| 'D'; 'D' |]; [| 'C' |]; [| 'A'; 'A' |] |]</c>
    /// </example>
    ///
    /// <example id="Array.splits-2">
    /// <code lang="fsharp">
    /// let digit value =
    ///     match value with
    ///     | 0 -> 1
    ///     | _ -> value |> abs |> float |> log10 |> int |> ((+) 1)
    /// let input = [| 0; 2; 12; 42; 128; 666; 6; 928; 1024 |]
    /// input |> Array.splits (fun x y -> digit x <> digit y)
    /// </code>
    /// Evaluates to <c>[| [| 0; 2 |]; [| 12; 42 |]; [| 128; 666 |]; [| 6 |]; [| 928 |]; [| 1024 |] |]</c>
    /// </example>
    ///
    /// <example id="Array.splits-3">
    /// <code lang="fsharp">
    /// let input = [| 0..9 |]
    /// input |> Array.splits (fun x y -> x > y)
    /// </code>
    /// Evaluates to <c>[| [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |] |]</c>
    /// </example>
    ///
    /// <example id="Array.splits-4">
    /// <code lang="fsharp">
    /// let input = [| 0..9 |]
    /// input |> Array.splits (fun x y -> x < y)
    /// </code>
    /// Evaluates to <c>[| [| 0 |]; [| 1 |]; [| 2 |]; [| 3 |]; [| 4 |]; [| 5 |]; [| 6 |]; [| 7 |]; [| 8 |]; [| 9 |] |]</c>
    /// </example>
    val splits: predicate: ('T -> 'T -> bool) -> array: 'T[] -> 'T[][]
