namespace Fermata

module Validators =

    /// <summary>Returns Ok if the input is not <c>null</c> or an empty string, otherwise Error.</summary>
    ///
    /// <param name="input">The input string.</param>
    ///
    /// <returns>Ok if the input is not <c>null</c> or an empty string, otherwise Error.</returns>
    ///
    /// <example id="validatenotnullorempty-1">
    /// <code lang="fsharp">
    /// let input = "hey"
    /// input |> validateNotNullOrEmpty
    /// </code>
    /// Evaluates to <c>Ok "hey"</c>
    /// </example>
    ///
    /// <example id="validatenotnullorempty-2">
    /// <code lang="fsharp">
    /// let input = null
    /// input |> validateNotNullOrEmpty
    /// </code>
    /// Evaluates to <c>Error (NullOrEmpty null)</c>
    /// </example>
    ///
    /// <example id="validatenotnullorempty-3">
    /// <code lang="fsharp">
    /// let input = ""
    /// input |> validateNotNullOrEmpty
    /// </code>
    /// Evaluates to <c>Error (NullOrEmpty "")</c>
    /// </example>
    val validateNotNullOrEmpty: input: string -> Result<string, exn>

    /// <summary>Returns Ok if the input is not an empty string, otherwise Error.</summary>
    ///
    /// <param name="input">The input string.</param>
    ///
    /// <returns>Ok if the input is not an empty string, otherwise Error.</returns>
    ///
    /// <example id="validatenotemptystring-1">
    /// <code lang="fsharp">
    /// let input = "hey"
    /// input |> validateNotEmptyString
    /// </code>
    /// Evaluates to <c>Ok "hey"</c>
    /// </example>
    ///
    /// <example id="validatenotemptystring-2">
    /// <code lang="fsharp">
    /// let input = ""
    /// input |> validateNotEmptyString
    /// </code>
    /// Evaluates to <c>Error (EmptyString "")</c>
    /// </example>
    val validateNotEmptyString: input: string -> Result<string, exn>

    /// <summary>Returns Ok if the input is not an empty string, otherwise Error.</summary>
    ///
    /// <param name="pattern">The Regular Expression pattern to test the input with.</param>
    /// <param name="input">The input string.</param>
    ///
    /// <returns>Ok if the input matches to the pattern, otherwise Error.</returns>
    ///
    /// <example id="validateformat-1">
    /// <code lang="fsharp">
    /// let input = "42"
    /// input |> validateFormat "^[0-9]+$"
    /// </code>
    /// Evaluates to <c>Ok "42"</c>
    /// </example>
    ///
    /// <example id="validateformat-2">
    /// <code lang="fsharp">
    /// let input = "4a"
    /// input |> validateFormat "^[0-9]+$"
    /// </code>
    /// Evaluates to <c>Error (WrongFormat "4a")</c>
    /// </example>
    val validateFormat: pattern: string -> input: string -> Result<string, exn>

    /// <summary>Returns Ok if the input is within the range, otherwise Error.</summary>
    ///
    /// <param name="min">The minimum value or the lower boundary of the range.</param>
    /// <param name="max">The maximum value or the upper boundary of the range.</param>
    /// <param name="input">The input value.</param>
    ///
    /// <returns>Ok if the input is within the range, otherwise Error.</returns>
    ///
    /// <example id="validaterange-1">
    /// <code lang="fsharp">
    /// let input = 42
    /// input |> validateRange 0 255
    /// </code>
    /// Evaluates to <c>Ok 42</c>
    /// </example>
    ///
    /// <example id="validaterange-2">
    /// <code lang="fsharp">
    /// let input = 512
    /// input |> validateRange 0 255
    /// </code>
    /// Evaluates to <c>Error (OutOfRange 512)</c>
    /// </example>
    ///
    /// <example id="validaterange-3">
    /// <code lang="fsharp">
    /// let input = 'f'
    /// input |> validateRange 'a' 'z'
    /// </code>
    /// Evaluates to <c>Ok 'f'</c>
    /// </example>
    ///
    /// <example id="validaterange-4">
    /// <code lang="fsharp">
    /// let input = 'A'
    /// input |> validateRange '0' '9'
    /// </code>
    /// Evaluates to <c>Error (OutOfRange 'A')</c>
    /// </example>
    val validateRange: min: 'T -> max: 'T -> input: 'T -> Result<'T, exn> when 'T: comparison

    /// <summary>Returns Ok if the length of the <paramref name="value"/> is shroter or equal to <paramref name="max"/>, otherwise Error.</summary>
    ///
    /// <param name="measurer">The function to get the length of the input value.</param>
    ///
    /// <param name="max">The max length.</param>
    ///
    /// <param name="value">The input value.</param>
    ///
    /// <returns>Ok if the length of the <paramref name="value"/> is shroter or equal to <paramref name="max"/>, otherwise Error.</returns>
    ///
    /// <example id="Validators.validateMaxLength-1">
    /// <code lang="fsharp">
    /// "101010" |> validateMaxLength String.length 32
    /// </code>
    /// Evaluates to <c>Ok "101010"</c>
    /// </example>
    ///
    /// <example id="Validators.validateMaxLength-2">
    /// <code lang="fsharp">
    /// "100000000000000000000000000000000" |> validateMaxLength String.length 32
    /// </code>
    /// Evaluates to <c>Error (Exceptions.Overflow "Value is too long. Value must be shorter or equal to 32")</c>
    /// </example>
    ///
    /// <example id="Validators.validateMaxLength-3">
    /// <code lang="fsharp">
    /// [ 0; 1; 2; 3; 4 ] |> validateMaxLength List.length 10
    /// </code>
    /// Evaluates to <c>Ok [ 0; 1; 2; 3; 4 ]</c>
    /// </example>
    ///
    /// <example id="Validators.validateMaxLength-4">
    /// <code lang="fsharp">
    /// [ 0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10 ] |> validateMaxLength List.length 10
    /// </code>
    /// Evaluates to <c>Error (Exceptions.Overflow "Value is too long. Value must be shorter or equal to 10")</c>
    /// </example>
    val validateMaxLength: measurer: ('T -> int) -> max: int -> value: 'T -> Result<'T, exn>
