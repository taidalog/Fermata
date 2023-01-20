namespace Fermata
    
    [<RequireQualifiedAccess>]
    module Seq =
        
        val tryTail: source: seq<'T> -> seq<'T> option

        val countWith: projection: ('T -> bool) -> source: seq<'T> -> int

        val trySkip: count: int -> source: seq<'T> -> seq<'T> option

        val filterIndex: projection: ('T -> bool) -> source: seq<'T> -> seq<int>

