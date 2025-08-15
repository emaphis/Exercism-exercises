module Leap

let leapYear (year: int): bool =
    let divBy400 n = n % 400 = 0
    let divBy100 n = n % 100 = 0
    let divBy4  n = n % 4 = 0

    if divBy4 year && not (divBy100 year) then true
    elif divBy400 year then true
    else false

// or more concisely
// (year % 400 = 0) || ((year % 4 = 0) && (year % 100 <> 0))
