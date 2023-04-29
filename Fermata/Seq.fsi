namespace Fermata
    
    [<RequireQualifiedAccess>]
    module Seq =
        
        val tryTail: source: seq<'T> -> seq<'T> option

        val countWith: predicate: ('T -> bool) -> source: seq<'T> -> int

        val trySkip: count: int -> source: seq<'T> -> seq<'T> option

        val filterIndex: predicate: ('T -> bool) -> source: seq<'T> -> seq<int>

        val intersection: source1: seq<'T> -> source2: seq<'T> -> seq<'T> when 'T: equality

        val splitWith: predicate: ('T -> bool) -> source: seq<'T> -> (seq<'T> * seq<'T>)

        val padLeft: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>

        val padRight: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>

