module Leap

let leapYear (year: int): bool =
    match year with
    | num when num % 400 = 0 -> true
    | num when num % 100 = 0 -> false
    | num when num % 4 = 0   -> true
    | _ -> false

// or more concisely
// (year % 400 = 0) || ((year % 4 = 0) && (year % 100 <> 0))
