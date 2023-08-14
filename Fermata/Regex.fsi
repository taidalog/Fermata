// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Regex =

    /// <summary>A wrapper function for <c>System.Text.RegularExpressions.Match(String, String)</c>.</summary>
    ///
    /// <param name="pattern">The regular expression pattern to match.</param>
    ///
    /// <param name="input">The string to search for a match.</param>
    ///
    /// <returns>System.Text.RegularExpressions.Match</returns>
    ///
    /// <example id="match-1">
    /// <code lang="fsharp">
    /// let m = "F#" |> Regex.match' "^[A-Z]#$"
    /// m.Success
    /// </code>
    /// Evaluates to <c>True</c>
    /// </example>
    val match': pattern: string -> input: string -> System.Text.RegularExpressions.Match

    /// <summary>A wrapper function for <c>System.Text.RegularExpressions.Matches(String, String)</c>.</summary>
    ///
    /// <param name="pattern">The regular expression pattern to match.</param>
    ///
    /// <param name="input">The string to search for a match.</param>
    ///
    /// <returns>System.Text.RegularExpressions.MatchCollection</returns>
    ///
    /// <example id="matches-1">
    /// <code lang="fsharp">
    /// let ms = "Shinkansen" |> Regex.matches "[aeiou]n"
    /// ms |> Seq.map (fun x -> x.Value)
    /// </code>
    /// Evaluates to <c>seq ["in"; "an"; "en"]</c>
    /// </example>
    val matches: pattern: string -> input: string -> System.Text.RegularExpressions.MatchCollection

    /// <summary>A wrapper function for <c>System.Text.RegularExpressions.IsMatch(String, String)</c>.</summary>
    ///
    /// <param name="pattern">The regular expression pattern to match.</param>
    ///
    /// <param name="input">The string to search for a match.</param>
    ///
    /// <returns>True if the regular expression finds a match, otherwise false.</returns>
    ///
    /// <example id="functionname-1">
    /// <code lang="fsharp">
    /// "F#" |> Regex.isMatch "^[A-Z]#$"
    /// </code>
    /// Evaluates to <c>true</c>
    /// </example>
    val isMatch: pattern: string -> input: string -> bool

    /// <summary>A wrapper function for <c>System.Text.RegularExpressions.Replace(String, String, String)</c>.</summary>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <param name="replacement">The string to replace <paramref name="input"/>.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <returns>The result string.</returns>
    ///
    /// <example id="functionname-1">
    /// <code lang="fsharp">
    /// "C#" |> Regex.replace "^[A-Z](?=#$)" "F"
    /// </code>
    /// Evaluates to <c>"F#"</c>
    /// </example>
    val replace: pattern: string -> replacement: string -> input: string -> string
