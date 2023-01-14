namespace Fermata
    
    module RadixConversion =
        
        [<RequireQualifiedAccess>]
        module Dec =
            
            val validate: input: string -> bool
            
            val toBin: input: int -> string
            
            val tryToBin: input: string -> string option
            
            val toHex: input: int -> string
            
            val tryToHex: input: string -> string option
        
        [<RequireQualifiedAccess>]
        module Bin =
            
            val validate: input: string -> bool
            
            val toDec: input: string -> int
            
            val tryToDec: input: string -> int option
        
        [<RequireQualifiedAccess>]
        module Hex =
            
            val validate: input: string -> bool
            
            val toDec: input: string -> int
            
            val tryToDec: input: string -> int option

