// Fermata Version 1.0.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2024 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module List =
    let tryTail (list: 'T list) : 'T list option =
        match list with
        | [] -> None
        | _ -> List.tail list |> Some

    let fore (list: 'T list) : 'T list =
        list |> List.rev |> List.tail |> List.rev

    let tryFore (list: 'T list) : 'T list option =
        match list with
        | [] -> None
        | _ -> list |> fore |> Some

    let count (predicate: 'T -> bool) (list: 'T list) : int =
        list |> List.filter predicate |> List.length

    let countBefore (index: int) (list: 'T list) : int =
        list |> List.truncate index |> count ((=) (List.item index list))

    let countAfter (index: int) (list: 'T list) : int =
        list |> List.skip (index + 1) |> count ((=) (List.item index list))

    let trySkip (count: int) (list: 'T list) : 'T list option =
        if count > (list |> List.length) then
            None
        else
            list |> List.skip count |> Some

    let filteri (predicate: int -> 'T -> bool) (list: 'T list) : 'T list =
        list
        |> List.indexed
        |> List.filter (fun (i, x) -> predicate i x)
        |> List.map (fun (_, x) -> x)

    let filterIndex (predicate: 'T -> bool) (list: 'T list) : int list =
        list
        |> List.indexed
        |> List.filter (fun (_, x) -> predicate x)
        |> List.map (fun (i, _) -> i)

    let filterIndexed (predicate: 'T -> bool) (list: 'T list) : (int * 'T) list =
        list |> List.mapi (fun i x -> (i, x)) |> List.filter (fun (_, x) -> predicate x)

    let intersect (list1: 'T list) (list2: 'T list) : 'T list =
        List.filter (fun x -> List.contains x list2) list1

    let splitFind (predicate: 'T -> bool) (list: 'T list) : 'T list * 'T list =
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

    let stairs (list: 'T list) : 'T list list =
        list |> List.scan (fun acc x -> x :: acc) [] |> List.tail |> List.map List.rev

    let stairsBack (list: 'T list) : 'T list list =
        list |> List.rev |> List.scan (fun acc x -> x :: acc) [] |> List.tail

    let splitWith (predicate: 'T -> 'T -> bool) (list: 'T list) : 'T list list =
        list
        |> List.pairwise
        |> List.fold
            (fun acc (x, y) ->
                if predicate x y then
                    [ y ] :: acc
                else
                    (y :: List.head acc) :: List.tail acc)
            [ [ List.head list ] ]
        |> List.map List.rev
        |> List.rev
