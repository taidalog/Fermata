// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module String.Tests

open Xunit
open Fermata

[<Fact>]
let ``head-1`` () =
    let actual = "Cheshire Cat" |> String.head
    let expected = "C"
    Assert.Equal(expected, actual)

[<Fact>]
let ``tryhead-1`` () =
    let actual = "Cheshire Cat" |> String.tryHead
    let expected = Some "C"
    Assert.Equal(expected, actual)

[<Fact>]
let ``tryhead-2`` () =
    let actual = "" |> String.tryHead
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``tail-1`` () =
    let actual = "cat" |> String.tail
    let expected = "at"
    Assert.Equal(expected, actual)

[<Fact>]
let ``trytail-1`` () =
    let actual = "cat" |> String.tryTail
    let expected = Some "at"
    Assert.Equal(expected, actual)

[<Fact>]
let ``trytail-2`` () =
    let actual = "" |> String.tryTail
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``trytail-3`` () =
    let actual = "c" |> String.tryTail
    let expected = Some ""
    Assert.Equal(expected, actual)

[<Fact>]
let ``last-1`` () =
    let actual = "The" |> String.last
    let expected = "e"
    Assert.Equal(expected, actual)

[<Fact>]
let ``trylast-1`` () =
    let actual = "The" |> String.tryLast
    let expected = Some "e"
    Assert.Equal(expected, actual)

[<Fact>]
let ``trylast-2`` () =
    let actual = "" |> String.tryLast
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``max-1`` () =
    let actual = [ "The"; "quick"; "brown"; "fox"; "jumped" ] |> String.max
    let expected = "jumped"
    Assert.Equal(expected, actual)

[<Fact>]
let ``max-2`` () =
    let actual = [ "The"; "quick"; "brown" ] |> String.max
    let expected = "quick"
    Assert.Equal(expected, actual)

[<Fact>]
let ``min-1`` () =
    let actual = [ "The"; "quick"; "brown" ] |> String.min
    let expected = "The"
    Assert.Equal(expected, actual)

[<Fact>]
let ``min-2`` () =
    let actual = [ "The"; "quick"; "brown"; "fox"; "jumped" ] |> String.min
    let expected = "The"
    Assert.Equal(expected, actual)

[<Fact>]
let ``min-3`` () =
    let actual = [ "The"; "quick"; "brown"; "fox"; "" ] |> String.min
    let expected = ""
    Assert.Equal(expected, actual)


[<Fact>]
let ``mid-1`` () =
    let input = "abcdefg"
    let actual = input |> String.mid 2 4
    let expected = "cdef"
    Assert.Equal(expected, actual)

[<Fact>]
let ``mid-2`` () =
    let input = "abcdefg"
    let actual = input |> String.mid 5 4
    let expected = "fg"
    Assert.Equal(expected, actual)

[<Fact>]
let ``mid-3`` () =
    let input = "abcdefg"
    let actual = input |> String.mid -1 4
    let expected = "abcd"
    Assert.Equal(expected, actual)

[<Fact>]
let ``replace-1`` () =
    let input = "The quick brown fox jumps..."
    let actual = input |> String.replace "quick" "lazy"
    let expected = "The lazy brown fox jumps..."
    Assert.Equal(expected, actual)

[<Fact>]
let ``tryreplace-1`` () =
    let input = "The quick brown fox jumps..."
    let actual = input |> String.tryReplace "quick" "lazy"
    let expected = Some "The lazy brown fox jumps..."
    Assert.Equal(expected, actual)

[<Fact>]
let ``tryreplace-2`` () =
    let input = "The quick brown fox jumps..."
    let actual = input |> String.tryReplace "" "lazy"
    let expected = None
    Assert.Equal(expected, actual)

[<Fact>]
let ``tryreplace-3`` () =
    let actual = "" |> String.tryReplace "quick" "lazy"
    let expected = Some ""
    Assert.Equal(expected, actual)

[<Fact>]
let ``padleft-1`` () =
    let actual = String.padLeft 3 '0' "A"
    let expected = "00A"
    Assert.Equal(expected, actual)

[<Fact>]
let ``padleft-2`` () =
    let actual = String.padLeft 3 '0' "AAAA"
    let expected = "AAAA"
    Assert.Equal(expected, actual)

[<Fact>]
let ``padright-1`` () =
    let actual = String.padRight 3 '0' "A"
    let expected = "A00"
    Assert.Equal(expected, actual)

[<Fact>]
let ``padright-2`` () =
    let actual = String.padRight 3 '0' "AAAA"
    let expected = "AAAA"
    Assert.Equal(expected, actual)

[<Fact>]
let ``padright-3`` () =
    let actual = String.padRight 6 'o' "bamb"
    let expected = "bamboo"
    Assert.Equal(expected, actual)

[<Fact>]
let ``trim-1`` () =
    let actual = String.trim "  A  "
    let expected = "A"
    Assert.Equal(expected, actual)

[<Fact>]
let ``trimend-1`` () =
    let actual = String.trimEnd "  A  "
    let expected = "  A"
    Assert.Equal(expected, actual)

[<Fact>]
let ``trimstart-1`` () =
    let actual = String.trimStart "  A  "
    let expected = "A  "
    Assert.Equal(expected, actual)

[<Fact>]
let ``rev-1`` () =
    let actual = "ABC" |> String.rev
    let expected = "CBA"
    Assert.Equal(expected, actual)

[<Fact>]
let ``chunkbysize-1`` () =
    let actual = "abcdefghijk" |> String.chunkBySize 4

    let expected =
        seq {
            "abcd"
            "efgh"
            "ijk"
        }

    Assert.Equal<seq<string>>(expected, actual)

[<Fact>]
let ``chunkbysize-right-1`` () =
    let actual = "abcdefghijk" |> String.chunkBySizeRight 4

    let expected =
        seq {
            "abc"
            "defg"
            "hijk"
        }

    Assert.Equal<seq<string>>(expected, actual)

[<Fact>]
let ``split-1`` () =
    let actual = "127.0.0.1" |> String.split '.'
    let expected = [ "127"; "0"; "0"; "1" ]
    Assert.Equal<seq<string>>(expected, actual)

[<Fact>]
let ``splitwith-1`` () =
    let str = "00001010"
    let actual = str |> String.splitWith (fun c -> c = '1')
    let expected = ("0000", "1010")
    Assert.Equal(expected, actual)

[<Fact>]
let ``splitwith-2`` () =
    let str = "taidalog"
    let actual = str |> String.splitWith ((=) 'l')
    let expected = ("taida", "log")
    Assert.Equal(expected, actual)

[<Fact>]
let ``splitwith-3`` () =
    let str = "taidalog"
    let actual = str |> String.splitWith ((=) 'z')
    let expected = ("taidalog", "")
    Assert.Equal(expected, actual)
