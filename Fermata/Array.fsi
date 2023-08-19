// Fermata Version 0.6.0
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
    val padRight: length: int -> padding: 'T -> array: 'T[] -> 'T[]
