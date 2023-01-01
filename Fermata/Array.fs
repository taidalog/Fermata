namespace Fermata

[<RequireQualifiedAccess>]
module Array =
    let tryTail (array : 'T[]) : 'T[] option =
        match array with
        | [||] -> None
        | _ -> Array.tail array |> Some
