module Pangram

open System

let isPangram (input: string): bool =
    let input = input.ToLower()
    let alphabet = [ 'a' .. 'z' ]

    alphabet
    |> Seq.forall (fun chr -> input.Contains(chr) )
