namespace Fermata

[<RequireQualifiedAccess>]
module List =
    let tryTail (list : 'T list) : 'T list option =
        match list with
        | [] -> None
        | _ -> List.tail list |> Some
