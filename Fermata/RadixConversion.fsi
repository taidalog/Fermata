namespace Fermata

module RadixConversion =

    type Dec = Dec of int
    type Bin = Bin of string
    type Hex = Hex of string
    type Arb = Arb of radix: int * symbols: seq<char> * value: string

    [<RequireQualifiedAccess>]
    module Dec =

        /// <summary>Returns Ok if the input string can be parsed as a decimal number, otherwise Error.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns>Ok if the input string can be parsed as a decimal number, otherwise Error.</returns>
        ///
        /// <example id="decvalidate-1">
        /// <code lang="fsharp">
        /// let input = "42"
        /// input |> Dec.validate
        /// </code>
        /// Evaluates to <c>Ok (Dec 42)</c>
        /// </example>
        ///
        /// <example id="decvalidate-2">
        /// <code lang="fsharp">
        /// let input = "FF"
        /// input |> Dec.validate
        /// </code>
        /// Evaluates to <c>Error (Exceptions.Format "The input string 'FF' was not in a correct format.")</c>
        /// </example>
        ///
        /// <example id="decvalidate-3">
        /// <code lang="fsharp">
        /// let input = "2147483648"
        /// input |> Dec.validate
        /// </code>
        /// Evaluates to <c>Error (Exceptions.Overflow "Value was either too large or too small for an Int32.")</c>
        /// </example>
        val validate: input: string -> Result<Dec, exn>

        /// <summary>Returns the equivalent binary representation of the input int value.</summary>
        ///
        /// <param name="dec">The input int value.</param>
        ///
        /// <returns>The equivalent binary representation of the input int value.</returns>
        ///
        /// <example id="tobin-1">
        /// <code lang="fsharp">
        /// let input = Dec 42
        /// input |> Dec.toBin
        /// </code>
        /// Evaluates to <c>Bin "101010"</c>
        /// </example>
        val toBin: dec: Dec -> Bin

        /// <summary>Returns the equivalent hexadecimal representation of the input int value.</summary>
        ///
        /// <param name="dec">The input int value.</param>
        ///
        /// <returns>The equivalent hexadecimal representation of the input int value.</returns>
        ///
        /// <example id="tohex-1">
        /// <code lang="fsharp">
        /// let input = Dec 42
        /// input |> Dec.toHex
        /// </code>
        /// Evaluates to <c>Hex "2a"</c>
        /// </example>
        val toHex: dec: Dec -> Hex

    [<RequireQualifiedAccess>]
    module Bin =

        /// <summary>Returns Ok if the input string can be parsed as a binary number, otherwise Error.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns>Ok if the input string can be parsed as a binary number, otherwise Error.</returns>
        ///
        /// <example id="binvalidate-1">
        /// <code lang="fsharp">
        /// let input = "101010"
        /// input |> Bin.validate
        /// </code>
        /// Evaluates to <c>Ok (Bin "101010")</c>
        /// </example>
        ///
        /// <example id="binvalidate-2">
        /// <code lang="fsharp">
        /// let input = "FF"
        /// input |> Bin.validate
        /// </code>
        /// Evaluates to <c>Error (Exceptions.Format "The input string 'FF' was not in a correct format.")</c>
        /// </example>
        ///
        /// <example id="binvalidate-3">
        /// <code lang="fsharp">
        /// let input = "100000000000000000000000000000000"
        /// input |> Bin.validate
        /// </code>
        /// Evaluates to <c>Error (Exceptions.Overflow "Value is too long. Value must be shorter or equal to 32")</c>
        /// </example>
        val validate: input: string -> Result<Bin, exn>

        /// <summary>Returns the equivalent decimal representation of the input string representation of a binary number.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns>The equivalent decimal representation of the input string representation of a binary number.</returns>
        ///
        /// <example id="bintodec-1">
        /// <code lang="fsharp">
        /// let input = Bin "101010"
        /// input |> Bin.toDec
        /// </code>
        /// Evaluates to <c>Dec 42</c>
        /// </example>
        val toDec: bin: Bin -> Dec

    [<RequireQualifiedAccess>]
    module Hex =

        /// <summary>Returns Ok if the input string can be parsed as a hexadecimal number, otherwise Error.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns>Ok if the input string can be parsed as a hexadecimal number, otherwise Error.</returns>
        ///
        /// <example id="hexvalidate-1">
        /// <code lang="fsharp">
        /// let input = "FF"
        /// input |> Hex.validate
        /// </code>
        /// Evaluates to <c>Ok (Hex "FF")</c>
        /// </example>
        ///
        /// <example id="hexvalidate-2">
        /// <code lang="fsharp">
        /// let input = "XX"
        /// input |> Hex.validate
        /// </code>
        /// Evaluates to <c>Error (Exceptions.Format "The input string 'XX' was not in a correct format.")</c>
        /// </example>
        ///
        /// <example id="hexvalidate-3">
        /// <code lang="fsharp">
        /// let input = "FFFFFFFFF"
        /// input |> Hex.validate
        /// </code>
        /// Evaluates to <c>Error (Exceptions.Overflow "Value is too long. Value must be shorter or equal to 8")</c>
        /// </example>
        val validate: input: string -> Result<Hex, exn>

        /// <summary>Returns the equivalent decimal representation of the input string representation of a hexadecimal number.</summary>
        ///
        /// <param name="input">The input string.</param>
        ///
        /// <returns>The equivalent decimal representation of the input string representation of a hexadecimal number.</returns>
        ///
        /// <example id="hextrytodec-1">
        /// <code lang="fsharp">
        /// let input = Hex "FF"
        /// input |> Hex.toDec
        /// </code>
        /// Evaluates to <c>Dec 255</c>
        /// </example>
        val toDec: hex: Hex -> Dec

    [<RequireQualifiedAccess>]
    module Arb =
        /// <summary>Returns <c>(Ok Arb)</c> if the radix converstion succeeded, otherwise <c>Error</c>.
        /// <c>Arb</c> is a single case discriminated union that conatins radix, symbols to represent a number with, and the result value.</summary>
        ///
        /// <param name="radix">The radix to convert the number with.</param>
        ///
        /// <param name="symbols">The symbols to represent a number with.</param>
        ///
        /// <param name="number">The input number to convert.</param>
        ///
        /// <returns><c>(Ok Arb)</c> if the radix converstion succeeded, otherwise <c>Error</c>.</returns>
        ///
        /// <example id="arbofint-1">
        /// <code lang="fsharp">
        /// Arb.ofInt 2 "01" 42
        /// </code>
        /// Evaluates to <c>Ok(Arb(2, "01", "101010"))</c>
        /// </example>
        ///
        /// <example id="arbofint-2">
        /// <code lang="fsharp">
        /// Arb.ofInt 5 "01234" 42
        /// </code>
        /// Evaluates to <c>Ok(Arb(5, "01234", "132"))</c>
        /// </example>
        ///
        /// <example id="arbofint-3">
        /// <code lang="fsharp">
        /// Arb.ofInt 5 "HMNPY" 42
        /// </code>
        /// Evaluates to <c>Ok(Arb(5, "HMNPY", "MPN"))</c>
        /// </example>
        ///
        /// <example id="arbofint-4">
        /// <code lang="fsharp">
        /// Arb.ofInt 1 "0" 42
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "Radix must be greater than 1.")</c>
        /// </example>
        ///
        /// <example id="arbofint-5">
        /// <code lang="fsharp">
        /// Arb.ofInt 16 "" 42
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "Symbols were not specified.")</c>
        /// </example>
        ///
        /// <example id="arbofint-6">
        /// <code lang="fsharp">
        /// Arb.ofInt 16 "01" 42
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")</c>
        /// </example>
        val ofInt: radix: int -> symbols: seq<char> -> number: int -> Result<Arb, exn>

        /// <summary>Returns <c>(Ok int)</c> if the radix converstion succeeded, otherwise <c>Error</c>.
        /// <c>Arb</c> is a single case discriminated union that conatins radix, symbols to represent a number, and the result value.</summary>
        ///
        /// <param name="arb">The input <c>Arb</c>.</param>
        ///
        /// <returns><c>(Ok int)</c> if the radix converstion succeeded, otherwise <c>Error</c>.</returns>
        ///
        /// <example id="arbtoint-1">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb(2, "01", "101010"))
        /// </code>
        /// Evaluates to <c>Ok 42</c>
        /// </example>
        ///
        /// <example id="arbtoint-2">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb(5, "01234", "132"))
        /// </code>
        /// Evaluates to <c>Ok 42</c>
        /// </example>
        ///
        /// <example id="arbtoint-3">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb(5, "HMNPY", "MPN"))
        /// </code>
        /// Evaluates to <c>Ok 42</c>
        /// </example>
        ///
        /// <example id="arbtoint-4">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb(1, "0", "0"))
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "Radix must be greater than 1.")</c>
        /// </example>
        ///
        /// <example id="arbtoint-5">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb(16, "", "2a"))
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "Symbols were not specified.")</c>
        /// </example>
        ///
        /// <example id="arbtoint-6">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb(16, "01", "2a"))
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Argument "The number of the symbols and the radix didn't match.")</c>
        /// </example>
        ///
        /// <example id="arbtoint-7">
        /// <code lang="fsharp">
        /// Arb.toInt (Arb(16, "0123456789abcdef", "7ffffffff")) // over `Int32.MaxValue`.
        /// </code>
        /// Evaluates to <c>Error(Exceptions.Overflow "Arithmetic operation resulted in an overflow.")</c>
        /// </example>
        val toInt: arb: Arb -> Result<int, exn>
