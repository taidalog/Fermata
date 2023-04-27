namespace Fermata

[<RequireQualifiedAccess>]
module Seq =
    let tryTail (source : seq<'T>) : seq<'T> option =
        match source |> Seq.isEmpty with
        | true -> None
        | false -> Seq.tail source |> Some

    let countWith (predicate : 'T -> bool) (source : seq<'T>) : int =
        source
        |> Seq.filter predicate
        |> Seq.length
    
    let trySkip (count : int) (source : seq<'T>) : seq<'T> option =
        if count > (source |> Seq.length) then
            None
        else
            source |> Seq.skip count |> Some
    
    let filterIndex (predicate : 'T -> bool) (source : seq<'T>) : seq<int> =
        source
        |> Seq.indexed
        |> Seq.filter (fun (_, x) -> predicate x)
        |> Seq.map (fun (i, _) -> i)
    
    let intersection (source1 : seq<'T>) (source2 : seq<'T>) : seq<'T> =
        Seq.filter (fun x -> Seq.contains x source2) source1
    
    let splitWith (predicate : 'T -> bool) (source : seq<'T>) : seq<'T> * seq<'T> =
        source |> Seq.takeWhile (predicate >> not),
        source |> Seq.skipWhile (predicate >> not)
