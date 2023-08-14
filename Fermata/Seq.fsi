// Fermata Version 0.5.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

[<RequireQualifiedAccess>]
module Seq =

    val tryTail: source: seq<'T> -> seq<'T> option

    val countWith: predicate: ('T -> bool) -> source: seq<'T> -> int

    val trySkip: count: int -> source: seq<'T> -> seq<'T> option

    val filterIndex: predicate: ('T -> bool) -> source: seq<'T> -> seq<int>

    val filteri: predicate: ('T -> bool) -> source: seq<'T> -> seq<(int * 'T)>

    val intersect: source1: seq<'T> -> source2: seq<'T> -> seq<'T> when 'T: equality

    val splitWith: predicate: ('T -> bool) -> source: seq<'T> -> (seq<'T> * seq<'T>)

    val padLeft: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>

    val padRight: length: int -> padding: 'T -> source: seq<'T> -> seq<'T>
