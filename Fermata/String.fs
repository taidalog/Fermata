namespace Fermata

[<RequireQualifiedAccess>]
module String =
    let head (str : string) : string =
        str |> Seq.head |> string
    
    let tryHead (str : string) : string option =
        str |> Seq.tryHead |> Option.map string
    
    let tail (str : string) : string =
        str |> Seq.tail |> Seq.map string |> String.concat ""
    
    let tryTail (str : string) : string option =
        str
        |> Seq.tryTail
        |> Option.map (Seq.map string)
        |> Option.map (String.concat "")
    
    let last (str : string) : string =
        str |> Seq.last |> string
    
    let tryLast (str : string) : string option =
        str |> Seq.tryLast |> Option.map string
    
    let max (strList : string list) : string =
        strList |> Seq.maxBy String.length
    
    let min (strList : string list) : string =
        strList |> Seq.minBy String.length
    
    let mid (start : int) (len : int) (str : string) : string =
        str
        |> Seq.skip start
        |> Seq.truncate len
        |> Seq.map string
        |> String.concat "" 
    
    let replace (oldString : string) (newString : string) (str : string) : string =
        str.Replace(oldString, newString)
    
    let tryReplace (oldString : string) (newString : string) (str : string) : string option =
        match oldString |> System.String.IsNullOrEmpty with
        | true -> None
        | false -> str.Replace(oldString, newString) |> Some

    let padLeft (totalWidth : int) (paddingChar : char) (str : string) : string =
        str.PadLeft(totalWidth, paddingChar)
    
    let padRight (totalWidth : int) (paddingChar : char) (str : string) : string =
        str.PadRight(totalWidth, paddingChar)
    
    let trim (str : string) : string =
        str.Trim()
    
    let trimEnd (str : string) : string =
        str.TrimEnd()
    
    let trimStart (str : string) : string =
        str.TrimStart()
    
    let rev (str : string) : string =
        str
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""
    
    let chunkBySize (chunkSize : int) (str : string) : seq<string> =
        str
        |> Seq.chunkBySize chunkSize
        |> Seq.map (Array.map string)
        |> Seq.map (String.concat "")

    let chunkBySizeRight (chunkSize : int) (str : string) : seq<string> =
        str
        |> rev
        |> chunkBySize chunkSize
        |> Seq.rev
        |> Seq.map rev
