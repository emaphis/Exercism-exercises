// Pattern Matching  - <https://exercism.org/tracks/fsharp/exercises/guessing-game>

// A powerful wat to conditionally execute logic.


// A constant pattern

let number = 1

let describe number =
    match number with
    | 0 -> "Zero"
    | 1 -> "One"
    | _ -> "?"
    
let str1 = describe number
// val str1: string = "One"


// variable pattern

let str2 =
    match number with
    | 0 -> "Zero"
    | i ->  $"Non zero: {i}"
// val str2: string = "Non zero: 1"


// variable pattern with a guard claus
// This uses '_' as the wildcard pattern to have exhaustive matching
let str3 =
    match number with
    | 0 -> "Zero"
    | i when i > 0 -> $"Positive number {i}"
    | _ -> "Negative number"
// val str3: string = "Positive number 1"

// The compiler cannot use `when` clauses to determine exhaustiveness.


