namespace Fermata
    
    [<RequireQualifiedAccess>]
    module Seq =
        
        val tryTail: source: seq<'T> -> seq<'T> option

        val countWith: predicate: ('T -> bool) -> source: seq<'T> -> int

        val trySkip: count: int -> source: seq<'T> -> seq<'T> option

        val filterIndex: predicate: ('T -> bool) -> source: seq<'T> -> seq<int>

