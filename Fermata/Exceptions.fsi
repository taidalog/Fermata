// Fermata Version 0.6.0
// https://github.com/taidalog/Fermata
// Copyright (c) 2022-2023 taidalog
// This software is licensed under the MIT License.
// https://github.com/taidalog/Fermata/blob/main/LICENSE

namespace Fermata

module Exceptions =

    exception Argument of string

    exception ArgumentNull of string

    exception EmptyString of string

    exception Format of string

    exception OutOfRange of string

    exception Overflow of string

    exception Unknown of string
