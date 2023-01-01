namespace Fermata

[<RequireQualifiedAccess>]
module Bool =
    let toInt (b : bool) : int =
        match b with
        | true -> 1
        | false -> 0
    
    let ofInt (i : int) : bool =
        i <> 0
