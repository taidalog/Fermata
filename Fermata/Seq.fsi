// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Seq =

    val tryTail: source: seq<'T> -> seq<'T> option

    val fore: source: seq<'T> -> seq<'T>

    val tryFore: source: seq<'T> -> seq<'T> option

    val countWith: predicate: ('T -> bool) -> source: seq<'T> -> int

    val countBefore: index: int -> source: seq<'T> -> int when 'T: equality

    val countAfter: index: int -> source: seq<'T> -> int when 'T: equality

    val trySkip: count: int -> source: seq<'T> -> seq<'T> option

    val filteri: predicate: (int -> 'T -> bool) -> source: seq<'T> -> seq<'T>

    val filterIndex: predicate: ('T -> bool) -> source: seq<'T> -> seq<int>

    val filterIndexPair: predicate: ('T -> bool) -> source: seq<'T> -> seq<(int * 'T)>

    val intersect: source1: seq<'T> -> source2: seq<'T> -> seq<'T> when 'T: equality

    val splitWith: predicate: ('T -> bool) -> source: seq<'T> -> (seq<'T> * seq<'T>)

    val padLeft: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>

    val padRight: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>

    val stairs: source: seq<'T> -> seq<seq<'T>>

    val stairsBack: source: seq<'T> -> seq<seq<'T>>

    val partitions: predicate: ('T -> 'T -> bool) -> source: seq<'T> -> seq<seq<'T>>
