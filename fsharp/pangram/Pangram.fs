module Pangram

let isPangram (input: string): bool =
    let letters = [ 'a' .. 'z' ]
    let lower = input.ToLower()
    List.forall (fun (chr: char) -> lower.Contains(chr)) letters
