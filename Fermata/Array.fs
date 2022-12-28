namespace Fermata

module Array =
    let tryTail array =
        match array with
        | [||] -> None
        | _ -> Array.tail array |> Some
