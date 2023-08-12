namespace Fermata

module Exceptions =
    exception Argument of string
    exception ArgumentNull of string
    exception EmptyString of string
    exception Format of string
    exception OutOfRange of string
    exception Overflow of string
    exception Unknown of string
