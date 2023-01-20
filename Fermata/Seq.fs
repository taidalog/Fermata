namespace Fermata

[<RequireQualifiedAccess>]
module Seq =
    let tryTail (source : seq<'T>) : seq<'T> option =
        match source |> Seq.isEmpty with
        | true -> None
        | false -> Seq.tail source |> Some

    let countWith (projection : 'T -> bool) (source : seq<'T>) : int =
        source
        |> Seq.filter projection
        |> Seq.length
    
    let trySkip (count : int) (source : seq<'T>) : seq<'T> option =
        if count > (source |> Seq.length) then
            None
        else
            source |> Seq.skip count |> Some
    
    let filterIndex (projection : 'T -> bool) (source : seq<'T>) : seq<int> =
        source
        |> Seq.indexed
        |> Seq.filter (fun (_, x) -> projection x)
        |> Seq.map (fun (i, _) -> i)
