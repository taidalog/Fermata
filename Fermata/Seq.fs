// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Seq =
    let tryTail (source: seq<'T>) : seq<'T> option =
        match source |> Seq.isEmpty with
        | true -> None
        | false -> Seq.tail source |> Some

    let countWith (predicate: 'T -> bool) (source: seq<'T>) : int =
        source |> Seq.filter predicate |> Seq.length

    let trySkip (count: int) (source: seq<'T>) : seq<'T> option =
        if count > (source |> Seq.length) then
            None
        else
            source |> Seq.skip count |> Some

    let filterIndex (predicate: 'T -> bool) (source: seq<'T>) : seq<int> =
        source
        |> Seq.indexed
        |> Seq.filter (fun (_, x) -> predicate x)
        |> Seq.map (fun (i, _) -> i)

    let filteri (predicate: 'T -> bool) (source: seq<'T>) : seq<(int * 'T)> =
        source |> Seq.mapi (fun i x -> (i, x)) |> Seq.filter (fun (_, x) -> predicate x)

    let intersect (source1: seq<'T>) (source2: seq<'T>) : seq<'T> =
        Seq.filter (fun x -> Seq.contains x source2) source1

    let splitWith (predicate: 'T -> bool) (source: seq<'T>) : seq<'T> * seq<'T> =
        source |> Seq.takeWhile (predicate >> not), source |> Seq.skipWhile (predicate >> not)

    let padLeft (length: int) (padding: 'T) (source: seq<'T>) : seq<'T> =
        let length' = length - Seq.length source

        if length' < 1 then
            source
        else
            Seq.append (Seq.replicate length' padding) source

    let padRight (length: int) (padding: 'T) (source: seq<'T>) : seq<'T> =
        let length' = length - Seq.length source

        if length' < 1 then
            source
        else
            Seq.append source (Seq.replicate length' padding)
