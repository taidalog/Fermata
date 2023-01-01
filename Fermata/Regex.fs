namespace Fermata

open System.Text.RegularExpressions

[<RequireQualifiedAccess>]
module Regex =
    let match' pattern input : Match =
        Regex.Match(input, pattern)
    
    let matches pattern input : MatchCollection =
        Regex.Matches(input, pattern)
    
    let isMatch pattern input : bool =
        Regex.IsMatch(input, pattern)
    
    let replace (pattern : string) (replacement : string) (input : string) : string=
        Regex.Replace(input, pattern, replacement)
