namespace Fermata
    
    [<RequireQualifiedAccess>]
    module Result =
        
        val ofOption: error: 'Error -> option: 'T option -> Result<'T,'Error>

