// Fermata Version 0.7.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

module RadixConversion =

    type Dec =
        | Valid of int
        | Invalid of exn

    type Bin =
        | Valid of string
        | Invalid of exn

    type Hex =
        | Valid of string
        | Invalid of exn

    type Arb =
        | Valid of radix: int * symbols: seq<char> * value: string
        | Invalid of exn

    [<RequireQualifiedAccess>]
    module Dec =

        /// <summary>Returns <c>Dec.Valid</c> if the input string can be parsed as a decimal number, otherwise <c>Dec.Invalid</c>.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns><c>Dec.Valid</c> if the input string can be parsed as a decimal number, otherwise <c>Dec.Invalid</c>.</returns>
        ///
        /// <example id="Dec.validate-1">
        /// <code lang="fsharp">
        /// "42" |> Dec.validate
        /// </code>
        /// Evaluates to <c>Dec.Valid 42</c>
        /// </example>
        ///
        /// <example id="Dec.validate-2">
        /// <code lang="fsharp">
        /// "FF" |> Dec.validate
        /// </code>
        /// Evaluates to <c>Dec.Invalid(Exceptions.Format "Input string was not in a correct format.")</c>
        /// </example>
        ///
        /// <example id="Dec.validate-3">
        /// <code lang="fsharp">
        /// "2147483648" |> Dec.validate
        /// </code>
        /// Evaluates to <c>Dec.Invalid(Exceptions.Overflow "Value was either too large or too small for an Int32.")</c>
        /// </example>
        val validate: input: string -> Dec

        /// <summary>Returns the equivalent <c>Bin</c> representation of the input <c>Dec</c> value if it is valid, otherwise <c>Bin.Invalid</c>.</summary>
        ///
        /// <param name="dec">The input <c>Dec</c>.</param>
        ///
        /// <returns>The equivalent <c>Bin</c> representation of the input <c>Dec</c> value if it is valid, otherwise <c>Bin.Invalid</c>.</returns>
        ///
        /// <example id="Dec.toBin-1">
        /// <code lang="fsharp">
        /// "42" |> Dec.validate |> Dec.toBin
        /// </code>
        /// Evaluates to <c>Bin.Valid "101010"</c>
        /// </example>
        ///
        /// <example id="Dec.toBin-2">
        /// <code lang="fsharp">
        /// "42." |> Dec.validate |> Dec.toBin
        /// </code>
        /// Evaluates to <c>Bin.Invalid(Exceptions.Format "Input string was not in a correct format.")</c>
        /// </example>
        val toBin: dec: Dec -> Bin

        /// <summary>Returns the equivalent <c>Hex</c> representation of the input <c>Dec</c> value if it is valid, otherwise <c>Hex.Invalid</c>.</summary>
        ///
        /// <param name="dec">The input <c>Dec</c>.</param>
        ///
        /// <returns>The equivalent <c>Hex</c> representation of the input <c>Dec</c> value if it is valid, otherwise <c>Hex.Invalid</c>.</returns>
        ///
        /// <example id="Dec.toHex-1">
        /// <code lang="fsharp">
        /// "42" |> Dec.validate |> Dec.toHex
        /// </code>
        /// Evaluates to <c>Hex.Valid "2a"</c>
        /// </example>
        ///
        /// <example id="Dec.toHex-2">
        /// <code lang="fsharp">
        /// "42." |> Dec.validate |> Dec.toHex
        /// </code>
        /// Evaluates to <c>Hex.Invalid(Exceptions.Format "Input string was not in a correct format.")</c>
        /// </example>
        val toHex: dec: Dec -> Hex

    [<RequireQualifiedAccess>]
    module Bin =

        /// <summary>Returns <c>Bin.Valid</c> if the input string can be parsed as a binary number, otherwise <c>Bin.Invalid</c>.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns><c>Bin.Valid</c> if the input string can be parsed as a binary number, otherwise <c>Bin.Invalid</c>.</returns>
        ///
        /// <example id="Bin.validate-1">
        /// <code lang="fsharp">
        /// "101010" |> Bin.validate
        /// </code>
        /// Evaluates to <c>Bin.Valid "101010"</c>
        /// </example>
        ///
        /// <example id="Bin.validate-2">
        /// <code lang="fsharp">
        /// "FF" |> Bin.validate
        /// </code>
        /// Evaluates to <c>Bin.Invalid(Exceptions.Format "The input string 'FF' was not in a correct format.")</c>
        /// </example>
        ///
        /// <example id="Bin.validate-3">
        /// <code lang="fsharp">
        /// "100000000000000000000000000000000" |> Bin.validate
        /// </code>
        /// Evaluates to <c>Bin.Invalid(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 32")</c>
        /// </example>
        val validate: input: string -> Bin

        /// <summary>Returns the equivalent <c>Dec</c> representation of the input <c>Bin</c> value if it is valid, otherwise <c>Dec.Invalid</c>.</summary>
        ///
        /// <param name="bin">The input <c>Bin</c>.</param>
        ///
        /// <returns>The equivalent <c>Dec</c> representation of the input <c>Bin</c> value if it is valid, otherwise <c>Dec.Invalid</c>.</returns>
        ///
        /// <example id="Bin.toDec-1">
        /// <code lang="fsharp">
        /// "101010" |> Bin.validate |> Bin.toDec
        /// </code>
        /// Evaluates to <c>Dec.Valid 42</c>
        /// </example>
        ///
        /// <example id="Bin.toDec-2">
        /// <code lang="fsharp">
        /// "XX" |> Bin.validate |> Bin.toDec
        /// </code>
        /// Evaluates to <c>Dec.Invalid(Exceptions.Format "The input string 'XX' was not in a correct format.")</c>
        /// </example>
        val toDec: bin: Bin -> Dec

    [<RequireQualifiedAccess>]
    module Hex =

        /// <summary>Returns <c>Hex.Valid</c> if the input string can be parsed as a hexadecimal number, otherwise <c>Hex.Invalid</c>.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns><c>Hex.Valid</c> if the input string can be parsed as a hexadecimal number, otherwise <c>Hex.Invalid</c>.</returns>
        ///
        /// <example id="Hex.validate-1">
        /// <code lang="fsharp">
        /// "FF" |> Hex.validate
        /// </code>
        /// Evaluates to <c>Hex.Valid "FF"</c>
        /// </example>
        ///
        /// <example id="Hex.validate-2">
        /// <code lang="fsharp">
        /// "XX" |> Hex.validate
        /// </code>
        /// Evaluates to <c>Hex.Invalid(Exceptions.Format "The input string 'XX' was not in a correct format.")</c>
        /// </example>
        ///
        /// <example id="Hex.validate-3">
        /// <code lang="fsharp">
        /// "FFFFFFFFF" |> Hex.validate
        /// </code>
        /// Evaluates to <c>Hex.Invalid(Exceptions.Overflow "Value is too long. Value must be shorter or equal to 8")</c>
        val validate: input: string -> Hex

        /// <summary>Returns the equivalent <c>Dec</c> representation of the input <c>Hex</c> value if it is valid, otherwise <c>Dec.Invalid</c>.</summary>
        ///
        /// <param name="hex">The input <c>Hex</c>.</param>
        ///
        /// <returns>The equivalent <c>Dec</c> representation of the input <c>Hex</c> value if it is valid, otherwise <c>Dec.Invalid</c>.</returns>
        ///
        /// <example id="Hex.toDec-1">
        /// <code lang="fsharp">
        /// "ff" |> Hex.validate |> Hex.toDec
        /// </code>
        /// Evaluates to <c>Dec.Valid 255</c>
        /// </example>
        ///
        /// <example id="Hex.toDec-2">
        /// <code lang="fsharp">
        /// "XX" |> Hex.validate |> Hex.toDec
        /// </code>
        /// Evaluates to <c>Dec.Invalid(Exceptions.Format "The input string 'XX' was not in a correct format.")</c>
        /// </example>
        val toDec: hex: Hex -> Dec

    [<RequireQualifiedAccess>]
    module Arb =
        /// <summary>Returns <c>Arb.Valid</c> if the radix converstion succeeded, otherwise <c>Arb.Invalid</c>.
        /// <c>Arb</c> is two-case discriminated union that conatins Valid(radix, symbols to represent a number, and the result value), or Invalid.</summary>
        ///
        /// <param name="radix">The radix to convert the number with.</param>
        ///
        /// <param name="symbols">The symbols to represent a number with.</param>
        ///
        /// <param name="number">The input number to convert.</param>
        ///
        /// <returns><c>Arb.Valid</c> if the radix converstion succeeded, otherwise <c>Arb.Invalid</c>.</returns>
        ///
        /// <example id="Arb.ofInt-1">
        /// <code lang="fsharp">
        /// Arb.ofInt 2 "01" 42
        /// </code>
        /// Evaluates to <c>Arb.Valid(2, "01", "101010")</c>
        /// </example>
        ///
        /// <example id="Arb.ofInt-2">
        /// <code lang="fsharp">
        /// Arb.ofInt 5 "01234" 42
        /// </code>
        /// Evaluates to <c>Arb.Valid(5, "01234", "132")</c>
        /// </example>
        ///
        /// <example id="Arb.ofInt-3">
        /// <code lang="fsharp">
        /// Arb.ofInt 5 "HMNPY" 42
        /// </code>
        /// Evaluates to <c>Arb.Valid(5, "HMNPY", "MPN")</c>
        /// </example>
        ///
        /// <example id="Arb.ofInt-4">
        /// <code lang="fsharp">
        /// Arb.ofInt 1 "0" 42
        /// </code>
        /// Evaluates to <c>Arb.Invalid(Exceptions.Argument "Radix must be greater than 1.")</c>
        /// </example>
        ///
        /// <example id="Arb.ofInt-5">
        /// <code lang="fsharp">
        /// Arb.ofInt 16 "" 42
        /// </code>
        /// Evaluates to <c>Arb.Invalid(Exceptions.Argument "Symbols were not specified.")</c>
        /// </example>
        ///
        /// <example id="Arb.ofInt-6">
        /// <code lang="fsharp">
        /// Arb.ofInt 16 "01" 42
        /// </code>
        /// Evaluates to <c>Arb.Invalid(Exceptions.Argument "The number of the symbols and the radix didn't match.")</c>
        /// </example>
        val ofInt: radix: int -> symbols: seq<char> -> number: int -> Arb

        /// <summary>Returns <c>Ok</c> if the radix converstion succeeded, otherwise <c>Error</c>.
        /// <c>Arb</c> is two-case discriminated union that conatins Valid(radix, symbols to represent a number, and the result value), or Invalid.</summary>
        ///
        /// <param name="arb">The input <c>Arb</c>.</param>
        ///
        /// <returns><c>Ok</c> if the radix converstion succeeded, otherwise <c>Error</c>.</returns>
        ///
        /// <example id="Arb.toInt-1">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb.Valid(2, "01", "101010"))
        /// </code>
        /// Evaluates to <c>Ok 42</c>
        /// </example>
        ///
        /// <example id="Arb.toInt-2">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb.Valid(5, "01234", "132"))
        /// </code>
        /// Evaluates to <c>Ok 42</c>
        /// </example>
        ///
        /// <example id="Arb.toInt-3">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb.Valid(5, "HMNPY", "MPN"))
        /// </code>
        /// Evaluates to <c>Ok 42</c>
        /// </example>
        ///
        /// <example id="Arb.toInt-4">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb.Valid(1, "0", "0"))
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "Radix must be greater than 1.")</c>
        /// </example>
        ///
        /// <example id="Arb.toInt-5">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb.Valid(16, "", "2a"))
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "Symbols were not specified.")</c>
        /// </example>
        ///
        /// <example id="Arb.toInt-6">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb.Valid(16, "01", "2a"))
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")</c>
        /// </example>
        ///
        /// <example id="Arb.toInt-7">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb.Valid(16, "0123456789abcdef", "7ffffffff")) // over `Int32.MaxValue`.
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Overflow "Arithmetic operation resulted in an overflow.")</c>
        /// </example>
        val toInt: arb: Arb -> Result<int, exn>
