namespace Fermata
    
    [<RequireQualifiedAccess>]
    module Seq =
        
        val tryTail: source: seq<'T> -> seq<'T> option

