// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Bool =

    /// <summary>Returns 1 if the input boolean value is true, otherwise 0.</summary>
    ///
    /// <param name="b">The input boolean value.</param>
    ///
    /// <returns>1 if <paramref name="b"/> is true, otherwise 0.</returns>
    ///
    /// <example id="toint-1">
    /// <code lang="fsharp">
    /// let input = true
    /// input |> Bool.toInt
    /// </code>
    /// Evaluates to <c>1</c>
    /// </example>
    ///
    /// <example id="toint-2">
    /// <code lang="fsharp">
    /// let input = false
    /// input |> Bool.toInt
    /// </code>
    /// Evaluates to <c>false</c>
    /// </example>
    val toInt: b: bool -> int

    /// <summary>Returns true if the input int value is not 0, otherwise false.</summary>
    ///
    /// <param name="i">The input int value.</param>
    ///
    /// <returns>True if <paramref name="i"/> is not 0, otherwise false.</returns>
    ///
    /// <example id="ofint-1">
    /// <code lang="fsharp">
    /// let input = 42
    /// input |> Bool.ofInt
    /// </code>
    /// Evaluates to <c>true</c>
    /// </example>
    ///
    /// <example id="ofint-2">
    /// <code lang="fsharp">
    /// let input = 0
    /// input |> Bool.ofInt
    /// </code>
    /// Evaluates to <c>false</c>
    /// </example>
    ///
    /// <example id="ofint-3">
    /// <code lang="fsharp">
    /// let input = -192
    /// input |> Bool.ofInt
    /// </code>
    /// Evaluates to <c>true</c>
    /// </example>
    val ofInt: i: int -> bool
