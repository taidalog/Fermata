namespace Fermata

[<RequireQualifiedAccess>]
module Seq =
    let tryTail (source : seq<'T>) : seq<'T> option =
        match source |> Seq.isEmpty with
        | true -> None
        | false -> Seq.tail source |> Some
