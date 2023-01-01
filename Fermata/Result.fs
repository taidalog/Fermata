namespace Fermata

[<RequireQualifiedAccess>]
module Result =
    let ofOption error option =
        match option with
        | Some s -> Ok s
        | None -> Error error
