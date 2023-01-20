namespace Fermata

[<RequireQualifiedAccess>]
module List =
    let tryTail (list : 'T list) : 'T list option =
        match list with
        | [] -> None
        | _ -> List.tail list |> Some

    let countWith (projection : 'T -> bool) (list : 'T list) : int =
        list
        |> List.filter projection
        |> List.length
    
    let trySkip (count : int) (list : 'T list) : 'T list option =
        if count > (list |> List.length) then
            None
        else
            list |> List.skip count |> Some
    
    let filterIndex (projection : 'T -> bool) (list : 'T list) : int list =
        list
        |> List.indexed
        |> List.filter (fun (_, x) -> projection x)
        |> List.map (fun (i, _) -> i)
