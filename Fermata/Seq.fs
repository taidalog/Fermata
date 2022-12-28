namespace Fermata

module Seq =
    let tryTail source =
        match source |> Seq.isEmpty with
        | true -> None
        | false -> Seq.tail source |> Some
