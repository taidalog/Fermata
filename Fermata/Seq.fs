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
