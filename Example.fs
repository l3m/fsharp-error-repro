[<RequireQualifiedAccess>]
module FsErrorRepro.Example

let dummy (blahNum: int) =
    let blah : Blah = { Number = blahNum }
    printf $"%i{blah.Number}"
