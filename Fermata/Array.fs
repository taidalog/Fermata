namespace Fermata

[<RequireQualifiedAccess>]
module Array =
    let tryTail (array : 'T[]) : 'T[] option =
        match array with
        | [||] -> None
        | _ -> Array.tail array |> Some

    let countWith (predicate : 'T -> bool) (array : 'T[]) : int =
        array
        |> Array.filter predicate
        |> Array.length
    
    let trySkip (count : int) (array : 'T[]) : 'T[] option =
        if count > (array |> Array.length) then
            None
        else
            array |> Array.skip count |> Some
    
    let filterIndex (predicate : 'T -> bool) (array : 'T[]) : int[] =
        array
        |> Array.indexed
        |> Array.filter (fun (_, x) -> predicate x)
        |> Array.map (fun (i, _) -> i)
