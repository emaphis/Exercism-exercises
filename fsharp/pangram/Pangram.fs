module Pangram

let isPangram (input: string): bool =
    let input = input.ToLower()
    let alphabet = [ 'a' .. 'z' ]

    alphabet
    |> Seq.forall input.Contains
