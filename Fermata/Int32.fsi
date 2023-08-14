// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Int32 =
    /// <summary>Returns <c>Ok</c> if the input string can be parsed as a decimal number, otherwise <c>Error</c>. A wrapper function for <c>System.Int32.Parse(String)</c>.</summary>
    ///
    /// <param name="value">The input string.</param>
    ///
    /// <returns><c>Ok</c> if the input string can be parsed as a decimal number, otherwise <c>Error</c> wrapping an exception from <c>System.Int32.Parse</c>.</returns>
    ///
    /// <example id="Int32.validate-1">
    /// <code lang="fsharp">
    /// Int32.validate "42"
    /// </code>
    /// Evaluates to <c>Ok 42</c>
    /// </example>
    ///
    /// <example id="Int32.validate-2">
    /// <code lang="fsharp">
    /// Int32.validate "42."
    /// </code>
    /// Evaluates to <c>Error(Exceptions.Format "The input string '42.' was not in a correct format.")</c>
    /// </example>
    ///
    /// <example id="Int32.validate-3">
    /// <code lang="fsharp">
    /// Int32.validate null
    /// </code>
    /// Evaluates to <c>Error(Exceptions.ArgumentNull "Value cannot be null. (Parameter 's')")</c>
    /// </example>
    ///
    /// <example id="Int32.validate-4">
    /// <code lang="fsharp">
    /// Int32.validate ""
    /// </code>
    /// Evaluates to <c>Error(Exceptions.EmptyString "Value cannot be empty string.")</c>
    /// </example>
    ///
    /// <example id="Int32.validate-5">
    /// <code lang="fsharp">
    /// Int32.validate "2147483648" // System.Int32.MaxValue + 1
    /// </code>
    /// Evaluates to <c>Error(Exceptions.Overflow "Value was either too large or too small for an Int32.")</c>
    /// </example>
    ///
    /// <example id="Int32.validate-6">
    /// <code lang="fsharp">
    /// Int32.validate "-2147483649" // System.Int32.MinValue - 1
    /// </code>
    /// Evaluates to <c>Error(Exceptions.Overflow "Value was either too large or too small for an Int32.")</c>
    /// </example>
    val validate: value: string -> Result<int, exn>
