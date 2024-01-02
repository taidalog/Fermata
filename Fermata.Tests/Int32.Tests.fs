// Fermata Version 0.7.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

module Int32.Tests

open System
open Xunit
open Fermata

[<Fact>]
let ``Int32.validate 1`` () =
    let actual = Int32.validate "42"
    let expected = Ok 42
    Assert.Equal(expected, actual)

[<Fact>]
let ``Int32.validate 2`` () =
    let actual = Int32.validate "42."

    let expected =
        Error(FormatException "The input string '42.' was not in a correct format.")

    match expected with
    | Ok _ -> Assert.Fail ""
    | Error e1 ->
        match actual with
        | Ok _ -> Assert.Fail ""
        | Error e2 ->
            if e2.GetType().Name = e1.GetType().Name then
                Assert.Equal(e1.Message, e2.Message)
            else
                Assert.Fail ""

[<Fact>]
let ``Int32.validate 3`` () =
    let actual = Int32.validate null
    let expected = Error(ArgumentNullException())

    match expected with
    | Ok _ -> Assert.Fail ""
    | Error e1 ->
        match actual with
        | Ok _ -> Assert.Fail ""
        | Error e2 ->
            if e2.GetType().Name = e1.GetType().Name then
                Assert.Equal(e1.Message, e2.Message)
            else
                Assert.Fail ""

[<Fact>]
let ``Int32.validate 4`` () =
    let actual = Int32.validate ""

    let expected =
        Error(FormatException "The input string '' was not in a correct format.")

    match expected with
    | Ok _ -> Assert.Fail ""
    | Error e1 ->
        match actual with
        | Ok _ -> Assert.Fail ""
        | Error e2 ->
            if e2.GetType().Name = e1.GetType().Name then
                Assert.Equal(e1.Message, e2.Message)
            else
                Assert.Fail ""

[<Fact>]
let ``Int32.validate 5`` () =
    let actual = Int32.validate "2147483648" // System.Int32.MaxValue + 1

    let expected =
        Error(OverflowException "Value was either too large or too small for an Int32.")

    match expected with
    | Ok _ -> Assert.Fail ""
    | Error e1 ->
        match actual with
        | Ok _ -> Assert.Fail ""
        | Error e2 ->
            if e2.GetType().Name = e1.GetType().Name then
                Assert.Equal(e1.Message, e2.Message)
            else
                Assert.Fail ""

[<Fact>]
let ``Int32.validate 6`` () =
    let actual = Int32.validate "-2147483649" // System.Int32.MinValue - 1

    let expected =
        Error(OverflowException "Value was either too large or too small for an Int32.")

    match expected with
    | Ok _ -> Assert.Fail ""
    | Error e1 ->
        match actual with
        | Ok _ -> Assert.Fail ""
        | Error e2 ->
            if e2.GetType().Name = e1.GetType().Name then
                Assert.Equal(e1.Message, e2.Message)
            else
                Assert.Fail ""
