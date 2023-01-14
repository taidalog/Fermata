namespace Fermata
    
    [<RequireQualifiedAccess>]
    module String =
        
        val head: str: string -> string
        
        val tryHead: str: string -> string option
        
        val tail: str: string -> string
        
        val tryTail: str: string -> string option
        
        val last: str: string -> string
        
        val tryLast: str: string -> string option
        
        val max: strList: string list -> string
        
        val min: strList: string list -> string
        
        val mid: start: int -> len: int -> str: string -> string
        
        val replace:
          oldString: string -> newString: string -> str: string -> string
        
        val tryReplace:
          oldString: string -> newString: string -> str: string -> string option
        
        val padLeft:
          totalWidth: int -> paddingChar: char -> str: string -> string
        
        val padRight:
          totalWidth: int -> paddingChar: char -> str: string -> string
        
        val trim: str: string -> string
        
        val trimEnd: str: string -> string
        
        val trimStart: str: string -> string

