// Fermata Version 0.7.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Seq =

    /// <summary>Returns the sequence without the first element, or
    /// returns <c>None</c> if the input sequence is empty.</summary>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The sequence without the first element, or
    /// <c>None</c> if the input sequence is empty.</returns>
    ///
    /// <example id="Seq.tryTail-1">
    /// <code lang="fsharp">
    /// let source = seq {0; 1; 2}
    /// source |> Seq.tryTail
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Some(seq {1; 2})</c>
    /// </example>
    ///
    /// <example id="Seq.tryTail-2">
    /// <code lang="fsharp">
    /// let source: seq<int> = Seq.empty
    /// source |> Seq.tryTail
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>None</c>
    /// </example>
    val tryTail: source: seq<'T> -> seq<'T> option

    /// <summary>Returns the sequence without the last element.</summary>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The sequence without the last element.</returns>
    ///
    /// <example id="Seq.fore-1">
    /// <code lang="fsharp">
    /// let inputs = seq {0; 1; 2}
    /// inputs |> Seq.fore
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {0; 1}</c>
    /// </example>
    val fore: source: seq<'T> -> seq<'T>

    /// <summary>Returns the sequence without the last element, or
    /// returns <c>None</c> if the input array is empty.</summary>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The sequence without the last element.</returns>
    ///
    /// <example id="Seq.tryFore-1">
    /// <code lang="fsharp">
    /// let inputs = seq {0; 1; 2}
    /// inputs |> Seq.tryFore
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Some(seq {0; 1})</c>
    /// </example>
    ///
    /// <example id="Seq.tryFore-2">
    /// <code lang="fsharp">
    /// let inputs: seq<int> = Seq.empty
    /// inputs |> Seq.tryFore
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>None</c>
    /// </example>
    val tryFore: source: seq<'T> -> seq<'T> option

    /// <summary>Returns the number of elements of the sequence for which the given predicate returns true.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The number of elements of the sequence for which the given predicate returns true.</returns>
    ///
    /// <example id="Seq.countWith-1">
    /// <code lang="fsharp">
    /// let source = seq {"Laziness"; "Impatience"; "Hubris"}
    /// source |> Seq.countWith (fun x -> String.length x > 6)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>2</c>
    /// </example>
    ///
    /// <example id="Seq.countWith-2">
    /// <code lang="fsharp">
    /// let source = seq {"Laziness"; "Impatience"; "Hubris"}
    /// source |> Seq.countWith (fun x -> String.length x < 0)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>0</c>
    /// </example>
    val countWith: predicate: ('T -> bool) -> source: seq<'T> -> int

    /// <summary>Return the number of the occurrences of an item before itself in a sequence.</summary>
    ///
    /// <param name="index">The index of the item to count.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The number of the occurrences of an item before itself in a sequence.</returns>
    ///
    /// <example id="Seq.countBefore-1">
    /// <code lang="fsharp">
    /// seq {'a'; 'b'; 'a'; 'c'; 'b'; 'a'}
    /// |> Seq.countBefore 0
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>0</c>
    /// </example>
    ///
    /// <example id="Seq.countBefore-2">
    /// <code lang="fsharp">
    /// seq {'a'; 'b'; 'a'; 'c'; 'b'; 'a'}
    /// |> Seq.countBefore 2
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>1</c>
    /// </example>
    ///
    /// <example id="Seq.countBefore-3">
    /// <code lang="fsharp">
    /// seq {'a'; 'b'; 'a'; 'c'; 'b'; 'a'}
    /// |> Seq.countBefore 5
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>2</c>
    /// </example>
    val countBefore: index: int -> source: seq<'T> -> int when 'T: equality

    /// <summary>Return the number of the occurrences of an item after itself in a sequence.</summary>
    ///
    /// <param name="index">The index of the item to count.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The number of the occurrences of an item after itself in a sequence.</returns>
    ///
    /// <example id="Seq.countAfter-1">
    /// <code lang="fsharp">
    /// seq {'a'; 'b'; 'a'; 'c'; 'b'; 'a'}
    /// |> Seq.countAfter 0
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>2</c>
    /// </example>
    ///
    /// <example id="Seq.countAfter-2">
    /// <code lang="fsharp">
    /// seq {'a'; 'b'; 'a'; 'c'; 'b'; 'a'}
    /// |> Seq.countAfter 2
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>1</c>
    /// </example>
    ///
    /// <example id="Seq.countAfter-3">
    /// <code lang="fsharp">
    /// seq {'a'; 'b'; 'a'; 'c'; 'b'; 'a'}
    /// |> Seq.countAfter 5
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>0</c>
    /// </example>
    val countAfter: index: int -> source: seq<'T> -> int when 'T: equality

    /// <summary>Returns the sequence without the first N element, or
    /// returns <c>None</c> if the N exceeds the length of the input sequence.</summary>
    ///
    /// <param name="count">The number of elements to skip.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The sequence without the first N element, or
    /// <c>None</c> if the N exceeds the length of the input sequence.</returns>
    ///
    /// <example id="Seq.trySkip-1">
    /// <code lang="fsharp">
    /// let source = seq {0; 1; 2; 3; 4; 5}
    /// source |> Seq.trySkip 3
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Some(seq {3; 4; 5})</c>
    /// </example>
    ///
    /// <example id="Seq.trySkip-2">
    /// <code lang="fsharp">
    /// let source = seq {0; 1}
    /// source |> Seq.trySkip 3
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>None</c>
    /// </example>
    val trySkip: count: int -> source: seq<'T> -> seq<'T> option

    /// <summary>Returns a new collection containing only the elements of the collection for which the given predicate returns "true". The integer index passed to the function indicates the index (from 0) of element being filtered.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>A sequence containing only the elements that satisfy the predicate.</returns>
    ///
    /// <example id="Seq.filteri-1">
    /// <code lang="fsharp">
    /// seq {0; 2; 6; 7; 9; 12}
    /// |> Seq.filteri (fun i x -> (i * x) % 2 = 0)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {0; 2; 6; 9; 12}</c>
    /// </example>
    ///
    /// <example id="Seq.filteri-2">
    /// <code lang="fsharp">
    /// seq {"hey"; "F#"; ""}
    /// |> Seq.filteri (fun i x -> (i * String.length x) < 0)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Seq.empty</c>
    /// </example>
    val filteri: predicate: (int -> 'T -> bool) -> source: seq<'T> -> seq<'T>

    /// <summary>Returns a sequence of integer indexes (from 0) of the elements of the sequence
    /// for which the given predicate returns true.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>A sequence of indexes of the elements that satisfy the predicate.</returns>
    ///
    /// <example id="Seq.filterIndex-1">
    /// <code lang="fsharp">
    /// let source = seq {"A"; "B"; "A"; "C"; "C"; "A"}
    /// source |> Seq.filterIndex (fun x -> x = "A")
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {0; 2; 5}</c>
    /// </example>
    ///
    /// <example id="Seq.filterIndex-2">
    /// <code lang="fsharp">
    /// let source = seq {"A"; "B"; "A"; "C"; "C"; "A"}
    /// source |> Seq.filterIndex (fun x -> x = "Z")
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Seq.empty</c>
    /// </example>
    val filterIndex: predicate: ('T -> bool) -> source: seq<'T> -> seq<int>

    /// <summary>Returns a sequence of pairs of integer indexes (from 0) and the elements
    /// for which the given predicate returns true.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>A sequence of pairs of indexes and the elements that satisfy the predicate.</returns>
    ///
    /// <example id="Seq.filterIndexed-1">
    /// <code lang="fsharp">
    /// let source = seq {42; 16; 8; 20; 120; 4}
    /// source |> Seq.filterIndexed (fun x -> x % 10 = 0)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {(3, 20); (4, 120)}</c>
    /// </example>
    ///
    /// <example id="Seq.filterIndexed-2">
    /// <code lang="fsharp">
    /// let source = seq {42; 16; 8; 20; 120; 4}
    /// source |> Seq.filterIndexed (fun x -> x % 2 = 1)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Seq.empty</c>
    /// </example>
    val filterIndexed: predicate: ('T -> bool) -> source: seq<'T> -> seq<(int * 'T)>

    /// <summary>Returns a new sequence that contains the common elements to the two input sequences.</summary>
    ///
    /// <param name="source1">The first sequence.</param>
    ///
    /// <param name="source2">The second sequence.</param>
    ///
    /// <returns>The sequence of elements common to the two input sequences.</returns>
    ///
    /// <example id="Seq.intersect-1">
    /// <code lang="fsharp">
    /// let source1 = seq {0; 1; 2; 3; 4}
    /// let source2 = seq {0; 2; 4; 6; 8}
    /// Seq.intersect source1 source2
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {0; 2; 4}</c>
    /// </example>
    ///
    /// <example id="Seq.intersect-2">
    /// <code lang="fsharp">
    /// let source1 = seq {0; 1; 2; 3; 4}
    /// let source2 = seq {5; 6; 7; 8; 9}
    /// Seq.intersect source1 source2
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Seq.empty</c>
    /// </example>
    ///
    /// <example id="Seq.intersect-3">
    /// <code lang="fsharp">
    /// let source1 = seq {0; 1; 2; 3; 4}
    /// let source2 = Seq.empty
    /// Seq.intersect source1 source2
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Seq.empty</c>
    /// </example>
    val intersect: source1: seq<'T> -> source2: seq<'T> -> seq<'T> when 'T: equality

    /// <summary>Splits the sequence into two sequences before the first element for which the given predicate returns True.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The result two sequences.</returns>
    ///
    /// <example id="Seq.splitWith-1">
    /// <code lang="fsharp">
    /// let source = seq {0; 2; 4; 6; 8}
    /// let actual: seq<int> * seq<int> = source |> Seq.splitWith (fun x -> x > 5)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>(seq {0; 2; 4}, seq {6; 8})</c>
    /// </example>
    ///
    /// <example id="Seq.splitWith-2">
    /// <code lang="fsharp">
    /// let source = seq {0; 2; 5; 6; 8}
    /// let actual: seq<int> * seq<int> = source |> Seq.splitWith (fun x -> x % 2 = 1)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>(seq {0; 2}, seq {5; 6; 8})</c>
    /// </example>
    ///
    /// <example id="Seq.splitWith-3">
    /// <code lang="fsharp">
    /// let source = seq {0; 2; 5; 6; 8}
    /// let actual: seq<int> * seq<int> = source |> Seq.splitWith (fun x -> x % 2 = 2)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>(seq {0; 2; 5; 6; 8}, Seq.empty)</c>
    /// </example>
    val splitWith: predicate: ('T -> bool) -> source: seq<'T> -> (seq<'T> * seq<'T>)

    /// <summary>Returns a new sequence to which the specified value is prepended to be of the specified length.</summary>
    ///
    /// <param name="length">The length of the resulting sequnce.</param>
    ///
    /// <param name="padding">The value to prepend to the sequence.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The resulting sequence.</returns>
    ///
    /// <example id="Seq.padLeft-1">
    /// <code lang="fsharp">
    /// let source = seq {'2'; '4'; '6'; '8'}
    /// source |> Seq.padLeft 8 '0'
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {'0'; '0'; '0'; '0'; '2'; '4'; '6'; '8'}</c>
    /// </example>
    ///
    /// <example id="Seq.padLeft-2">
    /// <code lang="fsharp">
    /// let source = Seq.empty
    /// source |> Seq.padLeft 4 0
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {0; 0; 0; 0}</c>
    /// </example>
    val padLeft: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>

    /// <summary>Returns a new sequence to which the specified value is appended to be of the specified length.</summary>
    ///
    /// <param name="length">The length of the resulting sequnce.</param>
    ///
    /// <param name="padding">The value to append to the sequence.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The resulting sequence.</returns>
    ///
    /// <example id="Seq.padRight-1">
    /// <code lang="fsharp">
    /// let source = seq {'2'; '4'; '6'; '8'}
    /// source |> Seq.padRight 8 '0'
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {'2'; '4'; '6'; '8'; '0'; '0'; '0'; '0'}</c>
    /// </example>
    ///
    /// <example id="Seq.padRight-2">
    /// <code lang="fsharp">
    /// let source = Seq.empty
    /// source |> Seq.padRight 4 0
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {0; 0; 0; 0}</c>
    /// </example>
    val padRight: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>

    /// <summary>Returns a new sequence of sequences. The first sequence contains only the first element of the input sequence, and the last sequence contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ i0 ]; [ i0; i1 ]; ... [ i0; ... iN ] ]</c></summary>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>A new sequence of sequences. The first sequence contains only the first element of the input sequence, and the last sequence contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ i0 ]; [ i0; i1 ]; ... [ i0; ... iN ] ]</c></returns>
    ///
    /// <example id="Seq.stairs-1">
    /// <code lang="fsharp">
    /// Seq.stairs (seq { 0..4 })
    /// </code>
    /// Evaluates to a sequence yielding the same results as <code>
    /// seq {
    ///     seq {0}
    ///     seq {0; 1}
    ///     seq {0; 1; 2}
    ///     seq {0; 1; 2; 3}
    ///     seq {0; 1; 2; 3; 4}
    /// }
    /// </code>
    /// </example>
    ///
    /// <example id="Seq.stairs-2">
    /// <code lang="fsharp">
    /// let input: seq<int> = Seq.empty
    /// input |> Seq.stairs
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Seq.empty</c>
    /// </example>
    val stairs: source: seq<'T> -> seq<seq<'T>>

    /// <summary>Returns a new sequence of sequences. The first sequence contains only the last element of the input sequence, and the last sequence contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ iN ]; [ iN-1; iN ]; ... [ i0; ... iN ] ]</c></summary>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>A new sequence of sequences. The first sequence contains only the last element of the input sequence, and the last sequence contains all the original elements. If the elements are <c>i0..iN</c>, retuens <c>[ [ iN ]; [ iN-1; iN ]; ... [ i0; ... iN ] ]</c></returns>
    ///
    /// <example id="Seq.stairsBack-1">
    /// <code lang="fsharp">
    /// Seq.stairsBack (seq { 0..4 })
    /// </code>
    /// Evaluates to a sequence yielding the same results as <code>
    /// seq {
    ///     seq {4}
    ///     seq {3; 4}
    ///     seq {2; 3; 4}
    ///     seq {1; 2; 3; 4}
    ///     seq {0; 1; 2; 3; 4}
    /// }
    /// </code>
    /// </example>
    ///
    /// <example id="Seq.stairsBack-2">
    /// <code lang="fsharp">
    /// let input: seq<int> = Seq.empty
    /// input |> Seq.stairsBack
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>Seq.empty</c>
    /// </example>
    val stairsBack: source: seq<'T> -> seq<seq<'T>>

    /// <summary>Splits the input sequence before the elements for which the given predicate returns True.</summary>
    ///
    /// <param name="predicate">The function to test the input elements.</param>
    ///
    /// <param name="source">The input sequence.</param>
    ///
    /// <returns>The input sequence before the elements for which the given predicate returns True.</returns>
    ///
    /// <example id="Seq.splits-1">
    /// <code lang="fsharp">
    /// "AAAABBCDDCAA" |> Seq.splits (<>)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>
    /// seq {
    ///     seq {'A'; 'A'; 'A'; 'A'}
    ///     seq {'B'; 'B'}
    ///     seq {'C'}
    ///     seq {'D'; 'D'}
    ///     seq {'C'}
    ///     seq {'A'; 'A'}
    /// }
    /// </c>
    /// </example>
    ///
    /// <example id="Seq.splits-2">
    /// <code lang="fsharp">
    /// let digit value =
    ///     match value with
    ///     | 0 -> 1
    ///     | _ -> value |> abs |> float |> log10 |> int |> ((+) 1)
    /// let input = seq {0; 2; 12; 42; 128; 666; 6; 928; 1024 }
    /// input |> Seq.splits (fun x y -> digit x <> digit y)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <code>
    /// seq {
    ///     seq {0; 2}
    ///     seq {12; 42}
    ///     seq {128; 666}
    ///     seq {6}
    ///     seq {928}
    ///     seq {1024}
    /// }
    /// </code>
    /// </example>
    ///
    /// <example id="Seq.splits-3">
    /// <code lang="fsharp">
    /// let input = seq { 0..9 }
    /// input |> Seq.splits (fun x y -> x > y)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq { seq {0; 1; 2; 3; 4; 5; 6; 7; 8; 9} }</c>
    /// </example>
    ///
    /// <example id="Seq.splits-4">
    /// <code lang="fsharp">
    /// let input = seq { 0..9 }
    /// input |> Seq.splits (fun x y -> x < y)
    /// </code>
    /// Evaluates to a sequence yielding the same results as <code>
    /// seq {
    ///     seq {0}
    ///     seq {1}
    ///     seq {2}
    ///     seq {3}
    ///     seq {4}
    ///     seq {5}
    ///     seq {6}
    ///     seq {7}
    ///     seq {8}
    ///     seq {9}
    /// }
    /// </code>
    /// </example>
    val splits: predicate: ('T -> 'T -> bool) -> source: seq<'T> -> seq<seq<'T>>
