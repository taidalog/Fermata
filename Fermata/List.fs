namespace Fermata

[<RequireQualifiedAccess>]
module List =
    let tryTail (list : 'T list) : 'T list option =
        match list with
        | [] -> None
        | _ -> List.tail list |> Some

    let countWith (predicate : 'T -> bool) (list : 'T list) : int =
        list
        |> List.filter predicate
        |> List.length
    
    let trySkip (count : int) (list : 'T list) : 'T list option =
        if count > (list |> List.length) then
            None
        else
            list |> List.skip count |> Some
    
    let filterIndex (predicate : 'T -> bool) (list : 'T list) : int list =
        list
        |> List.indexed
        |> List.filter (fun (_, x) -> predicate x)
        |> List.map (fun (i, _) -> i)
