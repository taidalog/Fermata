namespace Fermata

[<RequireQualifiedAccess>]
module Int32 =
    /// <summary></summary>
    /// <param name="value"></param>
    /// <returns></returns>
    val validate: value: string -> Result<int, exn>
