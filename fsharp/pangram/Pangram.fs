module Pangram

let isPangram (input: string): bool =
    let alphabet = [ 'a' .. 'z' ]
    let example = input.ToLower()

    alphabet
    |> Seq.forall example.Contains
