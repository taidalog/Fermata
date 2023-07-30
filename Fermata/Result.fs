namespace Fermata

[<RequireQualifiedAccess>]
module Result =
    let ofOption (error: 'Error) (option: 'T option) : Result<'T, 'Error> =
        match option with
        | Some s -> Ok s
        | None -> Error error
