namespace Fermata

module String =
    let head str =
        str |> Seq.head |> string
    
    let tryHead str =
        str |> Seq.tryHead |> Option.map string
    
    let tail str =
        str |> Seq.tail |> Seq.map string |> String.concat ""
    
    let last str =
        str |> Seq.last |> string
    
    let tryLast str =
        str |> Seq.tryLast |> Option.map string
    
    let max strList =
        strList |> Seq.maxBy String.length
    
    let min strList =
        strList |> Seq.minBy String.length
    
    let mid start len str =
        str
        |> Seq.skip start
        |> Seq.truncate len
        |> Seq.map string
        |> String.concat "" 
    
    let replace (oldString : string) (newString : string) (str : string) =
        str.Replace(oldString, newString)
    
    let tryReplace (oldString : string) (newString : string) (str : string) =
        match oldString |> System.String.IsNullOrEmpty with
        | true -> None
        | false -> str.Replace(oldString, newString) |> Some

    let padLeft totalWidth paddingChar (str : string) =
        str.PadLeft(totalWidth, paddingChar)
    
    let padRight totalWidth paddingChar (str : string) =
        str.PadRight(totalWidth, paddingChar)
    
    let trim (str : string) =
        str.Trim()
    
    let trimEnd (str : string) =
        str.TrimEnd()
    
    let trimStart (str : string) =
        str.TrimStart()
