namespace Fermata

[<RequireQualifiedAccess>]
module String =

    /// <summary>Returns the first character of the string.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The first character of the string.</returns>
    ///
    /// <example id="head-1">
    /// <code lang="fsharp">
    /// "Cheshire Cat" |> String.head
    /// </code>
    /// Evaluates to <c>"C"</c>
    /// </example>
    val head: str: string -> string

    /// <summary>Returns the first character of the string, or
    /// returns <c>None</c> if the string is empty.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The first character of the string, or
    /// <c>None</c> if the string is empty.</returns>
    ///
    /// <example id="tryhead-1">
    /// <code lang="fsharp">
    /// "Cheshire Cat" |> String.tryHead
    /// </code>
    /// Evaluates to <c>Some "C"</c>
    /// </example>
    ///
    /// <example id="tryhead-2">
    /// <code lang="fsharp">
    /// "" |> String.tryHead
    /// </code>
    /// Evaluates to <c>None</c>
    /// </example>
    val tryHead: str: string -> string option

    /// <summary>Returns the string without the first character.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The string without the first character.</returns>
    ///
    /// <example id="tail-1">
    /// <code lang="fsharp">
    /// "cat" |> String.tail
    /// </code>
    /// Evaluates to <c>"at"</c>
    /// </example>
    val tail: str: string -> string

    /// <summary>Returns the string without the first character, or
    /// returns <c>None</c> if the input string is empty.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The string without the first character, or
    /// <c>None</c> if the input string is empty.</returns>
    ///
    /// <example id="trytail-1">
    /// <code lang="fsharp">
    /// "cat" |> String.tryTail
    /// </code>
    /// Evaluates to <c>Some "at"</c>
    /// </example>
    ///
    /// <example id="trytail-2">
    /// <code lang="fsharp">
    /// "" |> String.tryTail
    /// </code>
    /// Evaluates to <c>None</c>
    /// </example>
    ///
    /// <example id="trytail-3">
    /// <code lang="fsharp">
    /// "c" |> String.tryTail
    /// </code>
    /// Evaluates to <c>Some ""</c>
    /// </example>
    val tryTail: str: string -> string option

    /// <summary>Returns the last character of the string.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The last character of the string.</returns>
    ///
    /// <example id="last-1">
    /// <code lang="fsharp">
    /// "The" |> String.last
    /// </code>
    /// Evaluates to <c>"e"</c>
    /// </example>
    val last: str: string -> string

    /// <summary>Returns the last character of the string, or
    /// returns <c>None</c> if the input string is empty.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The last character of the string, or
    /// <c>None</c> if the input string is empty.</returns>
    ///
    /// <example id="trylast-1">
    /// <code lang="fsharp">
    /// "The" |> String.tryLast
    /// </code>
    /// Evaluates to <c>Some "e"</c>
    /// </example>
    ///
    /// <example id="trylast-2">
    /// <code lang="fsharp">
    /// "" |> String.tryLast
    /// </code>
    /// Evaluates to <c>None</c>
    /// </example>
    val tryLast: str: string -> string option

    /// <summary>Returns the longest string.</summary>
    ///
    /// <param name="strList">The input string list.</param>
    ///
    /// <returns>The longest string.</returns>
    ///
    /// <example id="max-1">
    /// <code lang="fsharp">
    /// ["The"; "quick"; "brown"; "fox"; "jumped"] |> String.max
    /// </code>
    /// Evaluates to <c>"jumped"</c>
    /// </example>
    ///
    /// <example id="max-2">
    /// <code lang="fsharp">
    /// ["The"; "quick"; "brown"] |> String.max
    /// </code>
    /// Evaluates to <c>"quick"</c>
    /// </example>
    val max: strList: string list -> string

    /// <summary>Returns the shortest string.</summary>
    ///
    /// <param name="strList">The input string list.</param>
    ///
    /// <returns>The shortest string.</returns>
    ///
    /// <example id="min-1">
    /// <code lang="fsharp">
    /// ["The"; "quick"; "brown"] |> String.min
    /// </code>
    /// Evaluates to <c>"The"</c>
    /// </example>
    ///
    /// <example id="min-2">
    /// <code lang="fsharp">
    /// ["The"; "quick"; "brown"; "fox"; "jumped"] |> String.min
    /// </code>
    /// Evaluates to <c>"The"</c>
    /// </example>
    ///
    /// <example id="min-3">
    /// <code lang="fsharp">
    /// ["The"; "quick"; "brown"; "fox"; ""] |> String.min
    /// </code>
    /// Evaluates to <c>""</c>
    /// </example>
    val min: strList: string list -> string

    /// <summary>Returns a new string,
    /// removing the first N characters,
    /// at most M characters long.</summary>
    ///
    /// <param name="start">The number of characters to skip.</param>
    ///
    /// <param name="len">The number of characters to return.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string.</returns>
    ///
    /// <example id="mid-1">
    /// <code lang="fsharp">
    /// let input = "abcdefg"
    /// input |> String.mid 2 4
    /// </code>
    /// Evaluates to <c>"cdef"</c>
    /// </example>
    ///
    /// <example id="mid-2">
    /// <code lang="fsharp">
    /// let input = "abcdefg"
    /// input |> String.mid 5 4
    /// </code>
    /// Evaluates to <c>"fg"</c>
    /// </example>
    ///
    /// <example id="mid-3">
    /// <code lang="fsharp">
    /// let input = "abcdefg"
    /// input |> String.mid -1 4
    /// </code>
    /// Evaluates to <c>"abcd"</c>
    /// </example>
    val mid: start: int -> len: int -> str: string -> string

    /// <summary>Returns a new string in which all <paramref name="oldString"/> are replaced with <paramref name="newString"/>.
    /// A wrapper function for <c>System.String.Replace(String, String)</c>.</summary>
    ///
    /// <param name="oldString">The string to be replaced.</param>
    ///
    /// <param name="newString">The string to replace <paramref name="oldString"/>.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string.</returns>
    ///
    /// <example id="replace-1">
    /// <code lang="fsharp">
    /// "The quick brown fox jumps..."
    /// |> String.replace "quick" "lazy"
    /// </code>
    /// Evaluates to <c>"The lazy brown fox jumps..."</c>
    /// </example>
    val replace: oldString: string -> newString: string -> str: string -> string

    /// <summary>Returns a new string in which all <paramref name="oldString"/> are replaced with <paramref name="newString"/>, or
    /// returns <c>None</c> if <paramref name="oldString"/> is the empty string ("").
    /// A wrapper function for <c>System.String.Replace(String, String)</c>.</summary>
    ///
    /// <param name="oldString">The string to be replaced.</param>
    ///
    /// <param name="newString">The string to replace <paramref name="oldString"/>.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string, or
    /// <c>None</c> if <paramref name="oldString"/> is the empty string ("").</returns>
    ///
    /// <example id="tryreplace-1">
    /// <code lang="fsharp">
    /// "The quick brown fox jumps..."
    /// |> String.tryReplace "quick" "lazy"
    /// </code>
    /// Evaluates to <c>Some "The lazy brown fox jumps..."</c>
    /// </example>
    ///
    /// <example id="tryreplace-2">
    /// <code lang="fsharp">
    /// "The quick brown fox jumps..."
    /// |> String.tryReplace "" "lazy"
    /// </code>
    /// Evaluates to <c>None</c>
    /// </example>
    ///
    /// <example id="tryreplace-2">
    /// <code lang="fsharp">
    /// "" |> String.tryReplace "quick" "lazy"
    /// </code>
    /// Evaluates to <c>Some ""</c>
    /// </example>
    val tryReplace: oldString: string -> newString: string -> str: string -> string option

    /// <summary>A wrapper function for <c>System.String.PadLeft(Int32, Char)</c>.</summary>
    ///
    /// <param name="totalWidth">The length of the resulting string.</param>
    ///
    /// <param name="paddingChar">A padding character.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string.</returns>
    ///
    /// <example id="padleft-1">
    /// <code lang="fsharp">
    /// String.padLeft 3 '0' "A"
    /// </code>
    /// Evaluates to <c>"00A"</c>
    /// </example>
    ///
    /// <example id="padleft-2">
    /// <code lang="fsharp">
    /// String.padLeft 3 '0' "AAAA"
    /// </code>
    /// Evaluates to <c>"AAAA"</c>
    /// </example>
    val padLeft: totalWidth: int -> paddingChar: char -> str: string -> string

    ///
    /// <summary>A wrapper function for <c>System.String.PadRight(Int32, Char)</c>.</summary>
    ///
    /// <param name="totalWidth">The length of the resulting string.</param>
    ///
    /// <param name="paddingChar">A padding character.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string.</returns>
    ///
    /// <example id="padright-1">
    /// <code lang="fsharp">
    /// String.padRight 3 '0' "A"
    /// </code>
    /// Evaluates to <c>"A00"</c>
    /// </example>
    ///
    /// <example id="padright-2">
    /// <code lang="fsharp">
    /// String.padRight 3 '0' "AAAA"
    /// </code>
    /// Evaluates to <c>"AAAA"</c>
    /// </example>
    ///
    /// <example id="padright-3">
    /// <code lang="fsharp">
    /// String.padRight 6 'o' "bamb"
    /// </code>
    /// Evaluates to <c>"bamboo"</c>
    /// </example>
    val padRight: totalWidth: int -> paddingChar: char -> str: string -> string

    /// <summary>Returns all leading and trailing white-space characters from the input string.
    /// A wrapper function for <c>System.String.Trim(String)</c>.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string.</returns>
    ///
    /// <example id="trim-1">
    /// <code lang="fsharp">
    /// String.trim "  A  "
    /// </code>
    /// Evaluates to <c>"A"</c>
    /// </example>
    val trim: str: string -> string

    /// <summary>Returns all trailing white-space characters from the input string.
    /// A wrapper function for <c>System.String.TrimEnd(String)</c>.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string.</returns>
    ///
    /// <example id="trimend-1">
    /// <code lang="fsharp">
    /// String.trimEnd "  A  "
    /// </code>
    /// Evaluates to <c>"  A"</c>
    /// </example>
    val trimEnd: str: string -> string

    /// <summary>Returns all leading white-space characters from the input string.
    /// A wrapper function for <c>System.String.TrimStart(String)</c>.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result string.</returns>
    ///
    /// <example id="trimstart-1">
    /// <code lang="fsharp">
    /// String.trimStart "  A  "
    /// </code>
    /// Evaluates to <c>"A  "</c>
    /// </example>
    val trimStart: str: string -> string

    /// <summary>Returns a new string with the characters in reverse order.</summary>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The reversed string.</returns>
    ///
    /// <example id="rev-1">
    /// <code lang="fsharp">
    /// "ABC" |> String.rev
    /// </code>
    /// Evaluates to <c>"CBA"</c>
    /// </example>
    val rev: str: string -> string

    /// <summary>Divides the input string into chunks of length at most <paramref name="chunkSize"/>.</summary>
    ///
    /// <param name="chunkSize">The maximum length of each chunk.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The sequence of the string divided into chunks.</returns>
    ///
    /// <example id="chunkbysize-1">
    /// <code lang="fsharp">
    /// "abcdefghijk" |> String.chunkBySize 4
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {"abcd"; "efgh"; "ijk"}</c>
    /// </example>
    val chunkBySize: chunkSize: int -> str: string -> seq<string>

    /// <summary>Divides the input string into chunks of length at most <paramref name="chunkSize"/>.
    /// The first chunk will be shorter than <paramref name="chunkSize"/> if the length of the string can not be divided by <paramref name="chunkSize"/>.</summary>
    ///
    /// <param name="chunkSize">The maximun length of each chunk.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The sequence of the string divided into chunks.</returns>
    ///
    /// <example id="chunkbysize-right-1">
    /// <code lang="fsharp">
    /// "abcdefghijk" |> String.chunkBySizeRight 4
    /// </code>
    /// Evaluates to a sequence yielding the same results as <c>seq {"abc"; "defg"; "hijk"}</c>
    /// </example>
    val chunkBySizeRight: chunkSize: int -> str: string -> seq<string>

    /// <summary>Returns a new list of substrings of the input string, split by a specified character.</summary>
    ///
    /// <param name="separator">The character to split the input string by.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The list of split substrings.</returns>
    ///
    /// <example id="split-1">
    /// <code lang="fsharp">
    /// "127.0.0.1" |> String.split '.'
    /// </code>
    /// Evaluates to <c>["127"; "0"; "0"; "1"]</c>
    /// </example>
    val split: separator: char -> str: string -> string list

    /// <summary>Splits the string into two strings before the first character for which the given predicate returns True.</summary>
    ///
    /// <param name="predicate">The function to test the characters of the input string.</param>
    ///
    /// <param name="str">The input string.</param>
    ///
    /// <returns>The result two strings.</returns>
    ///
    /// <example id="splitwith-1">
    /// <code lang="fsharp">
    /// let str = "00001010"
    /// str |> String.splitWith (fun c -> c = '1')
    /// </code>
    /// Evaluates to <c>("0000", "1010")</c>
    /// </example>
    ///
    /// <example id="splitwith-2">
    /// <code lang="fsharp">
    /// let str = "taidalog"
    /// str |> String.splitWith ((=) 'l')
    /// </code>
    /// Evaluates to <c>("taida", "log")</c>
    /// </example>
    ///
    /// <example id="splitwith-3">
    /// <code lang="fsharp">
    /// let str = "taidalog"
    /// str |> String.splitWith ((=) 'z')
    /// </code>
    /// Evaluates to <c>("taidalog", "")</c>
    /// </example>
    val splitWith: predicate: (char -> bool) -> str: string -> string * string
