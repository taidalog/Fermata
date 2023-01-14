namespace Fermata
    
    [<RequireQualifiedAccess>]
    module Regex =
        
        val match':
          pattern: string ->
            input: string -> System.Text.RegularExpressions.Match
        
        val matches:
          pattern: string ->
            input: string -> System.Text.RegularExpressions.MatchCollection
        
        val isMatch: pattern: string -> input: string -> bool
        
        val replace:
          pattern: string -> replacement: string -> input: string -> string

