namespace Fermata
    
    [<RequireQualifiedAccess>]
    module String =
        
        /// <summary>Returns the first character of the string.</summary>
        /// 
        /// <param name="str">The input string.</param>
        /// 
        /// <returns>The first character of the string.</returns>
        val head: str: string -> string
        
        /// <summary>Returns the first character of the string, or
        /// returns <c>None</c> if the string is empty.</summary>
        /// 
        /// <param name="str">The input string.</param>
        /// 
        /// <returns>The first character of the string, or
        /// <c>None</c> if the string is empty.</returns>
        val tryHead: str: string -> string option
        
        /// <summary>Returns the string without the first character.</summary>
        /// 
        /// <param name="str">The input string.</param>
        /// 
        /// <returns>The string without the first character.</returns>
        val tail: str: string -> string
        
        /// <summary>Returns the string without the first character, or 
        /// returns <c>None</c> if the input string is empty.</summary>
        /// 
        /// <param name="str">The input string.</param>
        /// 
        /// <returns>The string without the first character, or 
        /// <c>None</c> if the input string is empty.</returns>
        val tryTail: str: string -> string option
        
        /// <summary>Returns the last character of the string.</summary>
        /// 
        /// <param name="str">The input string.</param>
        /// 
        /// <returns>The last character of the string.</returns>
        val last: str: string -> string
        
        /// <summary>Returns the last character of the string, or
        /// returns <c>None</c> if the input string is empty.</summary>
        /// 
        /// <param name="str">The input string.</param>
        /// 
        /// <returns>The last character of the string, or
        /// <c>None</c> if the input string is empty.</returns>
        val tryLast: str: string -> string option
        
        /// <summary>Returns the longest string.</summary>
        /// 
        /// <param name="strList">The input string list.</param>
        /// 
        /// <returns>The longest string.</returns>
        val max: strList: string list -> string
        
        /// <summary>Returns the shortest string.</summary>
        /// 
        /// <param name="strList">The input string list.</param>
        /// 
        /// <returns>The shortest string.</returns>
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
        
        /// <summary></summary>
        /// <param name="oldString"></param>
        /// <param name="newString"></param>
        /// <param name="str">The input string.</param>
        /// <returns>The result string.</returns>
        val replace:
          oldString: string -> newString: string -> str: string -> string
        
        /// <summary></summary>
        /// <param name="oldString"></param>
        /// <param name="newString"></param>
        /// <param name="str">The input string.</param>
        /// <returns></returns>
        val tryReplace:
          oldString: string -> newString: string -> str: string -> string option
        
        /// <summary></summary>
        /// <param name="totalWidth">The length of the resulting string.</param>
        /// <param name="paddingChar">A padding character.</param>
        /// <param name="str">The input string.</param>
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
        val padLeft:
          totalWidth: int -> paddingChar: char -> str: string -> string
        
        /// <summary></summary>
        /// <param name="totalWidth">The length of the resulting string.</param>
        /// <param name="paddingChar">A padding character.</param>
        /// <param name="str">The input string.</param>
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
        val padRight:
          totalWidth: int -> paddingChar: char -> str: string -> string
        
        /// <summary>Returns all leading and trailing white-space characters from the input string.</summary>
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
        
        /// <summary>Returns all trailing white-space characters from the input string.</summary>
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
        
        /// <summary>Returns all leading white-space characters from the input string.</summary>
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

