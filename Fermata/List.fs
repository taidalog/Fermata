namespace Fermata

module List =
    let tryTail list =
        match list with
        | [] -> None
        | _ -> List.tail list |> Some
