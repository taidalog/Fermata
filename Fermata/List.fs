// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module List =
    let tryTail (list: 'T list) : 'T list option =
        match list with
        | [] -> None
        | _ -> List.tail list |> Some

    let countWith (predicate: 'T -> bool) (list: 'T list) : int =
        list |> List.filter predicate |> List.length

    let trySkip (count: int) (list: 'T list) : 'T list option =
        if count > (list |> List.length) then
            None
        else
            list |> List.skip count |> Some

    let filterIndex (predicate: 'T -> bool) (list: 'T list) : int list =
        list
        |> List.indexed
        |> List.filter (fun (_, x) -> predicate x)
        |> List.map (fun (i, _) -> i)

    let filteri (predicate: 'T -> bool) (list: 'T list) : (int * 'T) list =
        list |> List.mapi (fun i x -> (i, x)) |> List.filter (fun (_, x) -> predicate x)

    let intersect (list1: 'T list) (list2: 'T list) : 'T list =
        List.filter (fun x -> List.contains x list2) list1

    let splitWith (predicate: 'T -> bool) (list: 'T list) : 'T list * 'T list =
        list |> List.takeWhile (predicate >> not), list |> List.skipWhile (predicate >> not)

    let padLeft (length: int) (padding: 'T) (list: 'T list) : 'T list =
        let length' = length - List.length list

        if length' < 1 then
            list
        else
            List.append (List.replicate length' padding) list

    let padRight (length: int) (padding: 'T) (list: 'T list) : 'T list =
        let length' = length - List.length list

        if length' < 1 then
            list
        else
            List.append list (List.replicate length' padding)
