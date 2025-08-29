module Isogram

/// Produce a normalized seq of chars given a string.
let normalize str =
    str
    |> Seq.filter System.Char.IsLetter
    |> Seq.map System.Char.ToLower


let isIsogram (str: string): bool =
    let seq = normalize str
    let len = Seq.length seq
    let dst = seq |> Seq.distinct |> Seq.length

    len = dst
