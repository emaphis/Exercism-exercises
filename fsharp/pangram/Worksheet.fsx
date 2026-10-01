// Pangram worksheet

3 + 4

let pan1 = "The quick brown fox jumps over the lazy dog."

let input = pan1
let alphabet = [ 'a' .. 'z' ]
input.ToLower()

let ret =
    alphabet
    |> Seq.forall input.Contains

ret
