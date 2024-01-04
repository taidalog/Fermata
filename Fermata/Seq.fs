// Fermata Version 0.7.0
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

    let fore (source: seq<'T>) : seq<'T> =
        source |> Seq.rev |> Seq.tail |> Seq.rev

    let tryFore (source: seq<'T>) : seq<'T> option =
        match source |> Seq.isEmpty with
        | true -> None
        | false -> source |> fore |> Some

    let count (predicate: 'T -> bool) (source: seq<'T>) : int =
        source |> Seq.filter predicate |> Seq.length

    let countBefore (index: int) (source: seq<'T>) : int =
        source |> Seq.truncate index |> count ((=) (Seq.item index source))

    let countAfter (index: int) (source: seq<'T>) : int =
        source |> Seq.skip (index + 1) |> count ((=) (Seq.item index source))

    let trySkip (count: int) (source: seq<'T>) : seq<'T> option =
        if count > (source |> Seq.length) then
            None
        else
            source |> Seq.skip count |> Some

    let filteri (predicate: int -> 'T -> bool) (source: seq<'T>) : seq<'T> =
        source
        |> Seq.indexed
        |> Seq.filter (fun (i, x) -> predicate i x)
        |> Seq.map (fun (_, x) -> x)

    let filterIndex (predicate: 'T -> bool) (source: seq<'T>) : seq<int> =
        source
        |> Seq.indexed
        |> Seq.filter (fun (_, x) -> predicate x)
        |> Seq.map (fun (i, _) -> i)

    let filterIndexed (predicate: 'T -> bool) (source: seq<'T>) : seq<(int * 'T)> =
        source |> Seq.mapi (fun i x -> (i, x)) |> Seq.filter (fun (_, x) -> predicate x)

    let intersect (source1: seq<'T>) (source2: seq<'T>) : seq<'T> =
        Seq.filter (fun x -> Seq.contains x source2) source1

    let splitFind (predicate: 'T -> bool) (source: seq<'T>) : seq<'T> * seq<'T> =
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

    let stairs (source: seq<'T>) : seq<seq<'T>> =
        source
        |> Seq.scan (fun acc x -> Seq.append acc (seq { x })) Seq.empty
        |> Seq.tail

    let stairsBack (source: seq<'T>) : seq<seq<'T>> =
        source
        |> Seq.rev
        |> Seq.scan (fun acc x -> Seq.append (seq { x }) acc) Seq.empty
        |> Seq.tail

    let splitWith (predicate: 'T -> 'T -> bool) (source: seq<'T>) : seq<seq<'T>> =
        source
        |> Seq.pairwise
        |> Seq.fold
            (fun acc (x, y) ->
                if predicate x y then
                    Seq.append acc (seq { (seq { y }) })
                else
                    Seq.append (fore acc) (seq { (Seq.append (Seq.last acc) (seq { y })) }))
            (seq { seq (seq { Seq.head source }) })
