namespace Fermata

[<RequireQualifiedAccess>]
module List =
    let tryTail list =
        match list with
        | [] -> None
        | _ -> List.tail list |> Some
