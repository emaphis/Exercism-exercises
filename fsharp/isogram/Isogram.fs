module Isogram

/// Produce a normalized seq of chars given a string.
let normalize str =
    str
    |> Seq.filter System.Char.IsLetter
    |> Seq.map System.Char.ToLower

/// Compute if the passed string is an isogram (non-duplicated letters)
/// Note:  Non-isogram word will be shorter when duplicated letters are removed
let isIsogram (str: string): bool =
    let sequence = normalize str
    let distinct = sequence |> Seq.distinct
    not (Seq.length distinct < Seq.length sequence)
