namespace Fermata

module Errors =
    type Errors<'T> =
        | NullOrEmpty of 'T
        | EmptyString of 'T
        | WrongFormat of 'T
        | OutOfRange of 'T