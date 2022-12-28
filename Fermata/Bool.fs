namespace Fermata

module Bool =
    let toInt b =
        match b with
        | true -> 1
        | false -> 0
    
    let ofInt i =
        i <> 0
