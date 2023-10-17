// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Tuple =

    /// <summary>Returns the tuple of transformed elements.</summary>
    ///
    /// <param name="mapping">The function to transform elements from the input tuple.</param>
    ///
    /// <param name="x">The first element of the input tuple.</param>
    ///
    /// <param name="y">The second element of the input tuple.</param>
    ///
    /// <returns>The tuple of transformed elements.</returns>
    ///
    /// <example id="Tuple.map-1">
    /// <code lang="fsharp">
    /// Tuple.map int ("0", "1")
    /// </code>
    /// Evaluates to <c>(0, 1)</c>
    /// </example>
    ///
    /// <example id="Tuple.map-2">
    /// <code lang="fsharp">
    /// Tuple.map List.rev ([ 0; 1; 2; 3; 4 ], [ 5; 6; 7; 8; 9 ])
    /// </code>
    /// Evaluates to <c>([ 4; 3; 2; 1; 0 ], [ 9; 8; 7; 6; 5 ])</c>
    /// </example>
    val map: mapping: ('T -> 'U) -> x: 'T * y: 'T -> 'U * 'U

    /// <summary>Returns the tuple of transformed elements.</summary>
    ///
    /// <param name="mapping">The function to transform elements from the input tuple.</param>
    ///
    /// <param name="x">The first element of the input tuple.</param>
    ///
    /// <param name="y">The second element of the input tuple.</param>
    ///
    /// <param name="z">The third element of the input tuple.</param>
    ///
    /// <returns>The tuple of transformed elements.</returns>
    ///
    /// <example id="Tuple.map3-1">
    /// <code lang="fsharp">
    /// Tuple.map3 int ("0", "1", "2")
    /// </code>
    /// Evaluates to <c>(0, 1, 2)</c>
    /// </example>
    ///
    /// <example id="Tuple.map3-2">
    /// <code lang="fsharp">
    /// Tuple.map3 List.length ([], [ 0 ], [ 1; 2 ])
    /// </code>
    /// Evaluates to <c>(0, 1, 2)</c>
    /// </example>
    val map3: mapping: ('T -> 'U) -> x: 'T * y: 'T * z: 'T -> 'U * 'U * 'U

    /// <summary>Returns the tuple of transformed elements.</summary>
    ///
    /// <param name="mapping">The function to transform elements from the input tuple.</param>
    ///
    /// <param name="x1">The first element of the input tuple.</param>
    ///
    /// <param name="x2">The second element of the input tuple.</param>
    ///
    /// <param name="x3">The third element of the input tuple.</param>
    ///
    /// <param name="x4">The fourth element of the input tuple.</param>
    ///
    /// <returns>The tuple of transformed elements.</returns>
    ///
    /// <example id="Tuple.map4-1">
    /// <code lang="fsharp">
    /// Tuple.map4 int ("0", "1", "2", "3")
    /// </code>
    /// Evaluates to <c>(0, 1, 2, 3)</c>
    /// </example>
    ///
    /// <example id="Tuple.map4-2">
    /// <code lang="fsharp">
    /// Tuple.map4 ((+) "U+") ("0000", "1000", "2000", "3000")
    /// </code>
    /// Evaluates to <c>("U+0000", "U+1000", "U+2000", "U+3000")</c>
    /// </example>
    val map4: mapping: ('T -> 'U) -> x1: 'T * x2: 'T * x3: 'T * x4: 'T -> 'U * 'U * 'U * 'U

    /// <summary>Returns the tuple of transformed elements.</summary>
    ///
    /// <param name="mapping1">The function to transform the first element from the input tuple.</param>
    ///
    /// <param name="mapping2">The function to transform the second element from the input tuple.</param>
    ///
    /// <param name="x">The first element of the input tuple.</param>
    ///
    /// <param name="y">The second element of the input tuple.</param>
    ///
    /// <returns>The tuple of transformed elements.</returns>
    ///
    /// <example id="Tuple.mapWith-1">
    /// <code lang="fsharp">
    /// Tuple.mapWith (int, float) ("0", "1")
    /// </code>
    /// Evaluates to <c>(0, 1.0)</c>
    /// </example>
    ///
    /// <example id="Tuple.mapWith-2">
    /// <code lang="fsharp">
    /// Tuple.mapWith (List.rev, List.length) ([ 0; 1; 2; 3; 4 ], [ 5; 6; 7; 8; 9 ])
    /// </code>
    /// Evaluates to <c>([ 4; 3; 2; 1; 0 ], 5)</c>
    /// </example>
    val mapWith: mapping1: ('T1 -> 'U1) * mapping2: ('T2 -> 'U2) -> x: 'T1 * y: 'T2 -> 'U1 * 'U2

    /// <summary>Returns the tuple of transformed elements.</summary>
    ///
    /// <param name="mapping1">The function to transform the first element from the input tuple.</param>
    ///
    /// <param name="mapping2">The function to transform the second element from the input tuple.</param>
    ///
    /// <param name="mapping3">The function to transform the third element from the input tuple.</param>
    ///
    /// <param name="x">The first element of the input tuple.</param>
    ///
    /// <param name="y">The second element of the input tuple.</param>
    ///
    /// <param name="z">The third element of the input tuple.</param>
    ///
    /// <returns>The tuple of transformed elements.</returns>
    ///
    /// <example id="Tuple.mapWith3-1">
    /// <code lang="fsharp">
    /// Tuple.mapWith3 (int, float, int64) ("0", "1", "2")
    /// </code>
    /// Evaluates to <c>(0, 1.0, 2L)</c>
    /// </example>
    ///
    /// <example id="Tuple.mapWith3-2">
    /// <code lang="fsharp">
    /// Tuple.mapWith3 (List.length, List.rev, List.map ((*) 2)) ([ 0 ], [ 1; 2 ], [ 3; 4; 5 ])
    /// </code>
    /// Evaluates to <c>(1, [ 2; 1 ], [ 6; 8; 10 ])</c>
    /// </example>
    val mapWith3:
        mapping1: ('T1 -> 'U1) * mapping2: ('T2 -> 'U2) * mapping3: ('T3 -> 'U3) ->
            x: 'T1 * y: 'T2 * z: 'T3 ->
                'U1 * 'U2 * 'U3

    /// <summary>Returns the tuple of transformed elements.</summary>
    ///
    /// <param name="mapping1">The function to transform the first element from the input tuple.</param>
    ///
    /// <param name="mapping2">The function to transform the second element from the input tuple.</param>
    ///
    /// <param name="mapping3">The function to transform the third element from the input tuple.</param>
    ///
    /// <param name="mapping4">The function to transform the fourth element from the input tuple.</param>
    ///
    /// <param name="x1">The first element of the input tuple.</param>
    ///
    /// <param name="x2">The second element of the input tuple.</param>
    ///
    /// <param name="x3">The third element of the input tuple.</param>
    ///
    /// <param name="x4">The fourth element of the input tuple.</param>
    ///
    /// <returns>The tuple of transformed elements.</returns>
    ///
    /// <example id="Tuple.mapWith4-1">
    /// <code lang="fsharp">
    /// Tuple.mapWith4 (int, float, int64, byte) ("0", "1", "2", "3")
    /// </code>
    /// Evaluates to <c>(0, 1.0, 2L, 3uy)</c>
    /// </example>
    ///
    /// <example id="Tuple.mapWith4-2">
    /// <code lang="fsharp">
    /// Tuple.mapWith4 (((+) 2), ((-) 2), ((*) 2), ((/) 2)) (1, 1, 1, 1)
    /// </code>
    /// Evaluates to <c>(3, 1, 2, 2)</c>
    /// </example>
    val mapWith4:
        mapping1: ('T1 -> 'U1) * mapping2: ('T2 -> 'U2) * mapping3: ('T3 -> 'U3) * mapping4: ('T4 -> 'U4) ->
            x1: 'T1 * x2: 'T2 * x3: 'T3 * x4: 'T4 ->
                'U1 * 'U2 * 'U3 * 'U4
