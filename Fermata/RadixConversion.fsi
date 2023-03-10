namespace Fermata
    
    module RadixConversion =
        
        [<RequireQualifiedAccess>]
        module Dec =
            
            /// <summary>Returns true if the input string can be parsed as a decimal number, otherwise false.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>True if the input string can be parsed as a decimal number, otherwise false.</returns>
            /// 
            /// <example id="decvalidate-1">
            /// <code lang="fsharp">
            /// let input = "42"
            /// input |> Dec.validate
            /// </code>
            /// Evaluates to <c>true</c>
            /// </example>
            /// 
            /// <example id="decvalidate-2">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Dec.validate
            /// </code>
            /// Evaluates to <c>false</c>
            /// </example>
            val validate: input: string -> bool
            
            /// <summary>Returns the equivalent binary representation of the input int value.</summary>
            /// 
            /// <param name="input">The input int value.</param>
            /// 
            /// <returns>The equivalent binary representation of the input int value.</returns>
            /// 
            /// <example id="tobin-1">
            /// <code lang="fsharp">
            /// let input = 42
            /// input |> Dec.toBin
            /// </code>
            /// Evaluates to <c>"101010"</c>
            /// </example>
            val toBin: input: int -> string
            
            /// <summary>Returns the equivalent binary representation of the input int value, or
            /// returns <c>None</c> if the string can not be parsed as a decimal number.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>The equivalent binary representation of the input int value, or
            /// <c>None</c> if the string can not be parsed as a decimal number.</returns>
            /// 
            /// <example id="trytobin-1">
            /// <code lang="fsharp">
            /// let input = "42"
            /// input |> Dec.tryToBin
            /// </code>
            /// Evaluates to <c>Some "101010"</c>
            /// </example>
            /// 
            /// <example id="trytobin-2">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Dec.tryToBin
            /// </code>
            /// Evaluates to <c>None</c>
            /// </example>
            val tryToBin: input: string -> string option
            
            /// <summary>Returns the equivalent hexadecimal representation of the input int value.</summary>
            /// 
            /// <param name="input">The input int value.</param>
            /// 
            /// <returns>The equivalent hexadecimal representation of the input int value.</returns>
            /// 
            /// <example id="tohex-1">
            /// <code lang="fsharp">
            /// let input = 42
            /// input |> Dec.toHex
            /// </code>
            /// Evaluates to <c>"2a"</c>
            /// </example>
            val toHex: input: int -> string
            
            /// <summary>Returns the equivalent hexadecimal representation of the input int value, or
            /// returns <c>None</c> if the string can not be parsed as a decimal number.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>The equivalent hexadecimal representation of the input int value, or
            /// returns <c>None</c> if the string can not be parsed as a decimal number.</returns>
            /// 
            /// <example id="trytohex-1">
            /// <code lang="fsharp">
            /// let input = "42"
            /// input |> Dec.tryToBin
            /// </code>
            /// Evaluates to <c>Some "2a"</c>
            /// </example>
            /// 
            /// <example id="trytohex-2">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Dec.tryToBin
            /// </code>
            /// Evaluates to <c>None</c>
            /// </example>
            val tryToHex: input: string -> string option
        
        [<RequireQualifiedAccess>]
        module Bin =
            
            /// <summary>Returns true if the input string can be parsed as a binary number, otherwise false.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>True if the input string can be parsed as a binary number, otherwise false.</returns>
            /// 
            /// <example id="binvalidate-1">
            /// <code lang="fsharp">
            /// let input = "101010"
            /// input |> Bin.validate
            /// </code>
            /// Evaluates to <c>true</c>
            /// </example>
            /// 
            /// <example id="binvalidate-2">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Bin.validate
            /// </code>
            /// Evaluates to <c>false</c>
            /// </example>
            val validate: input: string -> bool
            
            /// <summary>Returns the equivalent decimal representation of the input string representation of a binary number.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>The equivalent decimal representation of the input string representation of a binary number.</returns>
            /// 
            /// <example id="bintodec-1">
            /// <code lang="fsharp">
            /// let input = "101010"
            /// input |> Bin.toDec
            /// </code>
            /// Evaluates to <c>42</c>
            /// </example>
            val toDec: input: string -> int
            
            /// <summary>Returns the equivalent decimal representation of the input string representation of a binary number, or
            /// returns <c>None</c> if the string can not be parsed as a binary number.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>The equivalent decimal representation of the input string representation of a binary number, or
            /// <c>None</c> if the string can not be parsed as a binary number.</returns>
            /// 
            /// <example id="bintrytodec-1">
            /// <code lang="fsharp">
            /// let input = "101010"
            /// input |> Bin.tryToDec
            /// </code>
            /// Evaluates to <c>Some 42</c>
            /// </example>
            /// 
            /// <example id="bintrytodec-2">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Bin.tryToDec
            /// </code>
            /// Evaluates to <c>None</c>
            /// </example>
            val tryToDec: input: string -> int option
        
        [<RequireQualifiedAccess>]
        module Hex =
            
            /// <summary>Returns true if the input string can be parsed as a hexadecimal number, otherwise false.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>True if the input string can be parsed as a hexadecimal number, otherwise false.</returns>
            /// 
            /// <example id="hexvalidate-1">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Hex.validate
            /// </code>
            /// Evaluates to <c>true</c>
            /// </example>
            /// 
            /// <example id="hexvalidate-2">
            /// <code lang="fsharp">
            /// let input = "XX"
            /// input |> Hex.validate
            /// </code>
            /// Evaluates to <c>false</c>
            /// </example>
            val validate: input: string -> bool
            
            /// <summary>Returns the equivalent decimal representation of the input string representation of a hexadecimal number.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>The equivalent decimal representation of the input string representation of a hexadecimal number.</returns>
            /// 
            /// <example id="hextrytodec-1">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Hex.tryToDec
            /// </code>
            /// Evaluates to <c>Some 255</c>
            /// </example>
            val toDec: input: string -> int
            
            /// <summary>Returns the equivalent decimal representation of the input string representation of a hexadecimal number, or
            /// returns <c>None</c> if the string can not be parsed as a hexadecimal number.</summary>
            /// 
            /// <param name="input">The input string.</param>
            /// 
            /// <returns>The equivalent decimal representation of the input string representation of a hexadecimal number, or
            /// <c>None</c> if the string can not be parsed as a hexadecimal number.</returns>
            /// 
            /// <example id="hextrytodec-1">
            /// <code lang="fsharp">
            /// let input = "FF"
            /// input |> Hex.tryToDec
            /// </code>
            /// Evaluates to <c>Some 255</c>
            /// </example>
            /// 
            /// <example id="hextrytodec-2">
            /// <code lang="fsharp">
            /// let input = "XX"
            /// input |> Hex.tryToDec
            /// </code>
            /// Evaluates to <c>None</c>
            /// </example>
            val tryToDec: input: string -> int option

