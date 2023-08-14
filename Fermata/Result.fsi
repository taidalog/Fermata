// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Result =

    /// <summary>Converts the option to a result.</summary>
    ///
    /// <param name="error">The error value for <c>None</c></param>
    ///
    /// <param name="option">The input option.</param>
    ///
    /// <returns>The result converted from the option.</returns>
    ///
    /// <example id="ofoption-1">
    /// <code lang="fsharp">
    /// let input = Some 42
    /// let msg = "The input is not a number."
    /// Result.ofOption msg input
    /// </code>
    /// Evaluates to <c>Ok 42</c>
    /// </example>
    ///
    /// <example id="decvalidate-2">
    /// <code lang="fsharp">
    /// let input : int option = None
    /// let msg = "The input is not a number."
    /// Result.ofOption msg input
    /// </code>
    /// Evaluates to <c>Error "The input is not a number."</c>
    /// </example>
    val ofOption: error: 'Error -> option: 'T option -> Result<'T, 'Error>
