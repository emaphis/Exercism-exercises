// Recursion - PizzaPricing

// recursive function

let rec factorial x =
    // base case
    if x = 1 then 1
    // recursive case
    else x * factorial (x - 1)


// recursive definition
type RussianDoll =
    | Doll
    | Layer of RussianDoll


let doll = Layer (Layer (Layer Doll))


// Recursive function consuming RussianDoll

let rec countLayers russian =
    match russian with
    | Doll  -> 0
    | Layer lyr ->  1 + countLayers lyr

let cnt = countLayers doll
// val cnt: int = 3