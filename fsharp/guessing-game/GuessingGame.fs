module GuessingGame

let reply (guess: int): string =
    match guess with
    | n when n < 41 -> "Too low"
    | n when n > 43 -> "Too high"
    | 41 | 43 -> "So close"
    | _ -> "Correct"
