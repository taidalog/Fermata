// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Array =
    let tryTail (array: 'T[]) : 'T[] option =
        match array with
        | [||] -> None
        | _ -> Array.tail array |> Some

    let countWith (predicate: 'T -> bool) (array: 'T[]) : int =
        array |> Array.filter predicate |> Array.length

    let trySkip (count: int) (array: 'T[]) : 'T[] option =
        if count > (array |> Array.length) then
            None
        else
            array |> Array.skip count |> Some

    let filterIndex (predicate: 'T -> bool) (array: 'T[]) : int[] =
        array
        |> Array.indexed
        |> Array.filter (fun (_, x) -> predicate x)
        |> Array.map (fun (i, _) -> i)

    let filteri (predicate: 'T -> bool) (array: 'T[]) : (int * 'T)[] =
        array
        |> Array.mapi (fun i x -> (i, x))
        |> Array.filter (fun (_, x) -> predicate x)

    let intersect (array1: 'T[]) (array2: 'T[]) : 'T[] =
        Array.filter (fun x -> Array.contains x array2) array1

    let splitWith (predicate: 'T -> bool) (array: 'T[]) : 'T[] * 'T[] =
        array |> Array.takeWhile (predicate >> not), array |> Array.skipWhile (predicate >> not)

    let padLeft (length: int) (padding: 'T) (array: 'T[]) : 'T[] =
        let length' = length - Array.length array

        if length' < 1 then
            array
        else
            Array.append (Array.replicate length' padding) array

    let padRight (length: int) (padding: 'T) (array: 'T[]) : 'T[] =
        let length' = length - Array.length array

        if length' < 1 then
            array
        else
            Array.append array (Array.replicate length' padding)
