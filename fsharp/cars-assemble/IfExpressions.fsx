// If Else Expressions - <https://exercism.org/tracks/fsharp/exercises/cars-assemble>

// Conditionally executing code can be done using `if "conditional"/elif/else expressions`
// The `conditional` must be a `bool` expression

let x = 10

if x = 5 then
    printfn "x equals 5"
elif x > 7 then
    printfn "x is not 5 and greater than 7"
else
    printfn "x is not 5 and not greater than 7"
    
// is not 5 and greater than 7

// an `if` expression returns a value.

let message = 
    if x = 5 then
        "x equals 5"
    elif x > 7 then
        "x is not 5 and greater than 7"
    else
         "x is not 5 and not greater than 7"

do printfn "%s" message

// all branches must return the same type.

// if the return is `unit` branches are optional

if x > 2 then
    printfn "x is greater than 2"
    
// The if else expression can be placed on one line
let y = if x > 5 then 10 else 20
// val y: int = 10
