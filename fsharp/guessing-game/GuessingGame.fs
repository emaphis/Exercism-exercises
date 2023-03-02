module GuessingGame

let reply (guess: int): string =
    match guess with
    | n when n < 41 -> "Too low"
    | 41 | 43 -> "So close"
    | 42      -> "Correct"
    | _       -> "Too high"

