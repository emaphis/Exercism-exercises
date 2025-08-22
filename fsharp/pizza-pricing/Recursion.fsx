// Recursion - PizzaPricing

// recursive function

let rec factorial x =
    // base case
    if x = 1 then 1
    // recursive case
    else x * factorial (x - 1)


// Lists can be processed recursively.

let rec length1 list =
    match list with
    | []  -> 0  // base case
    | _::xs -> 1 + length1 xs  // recursive case

let num1 = length1 [1; 2; 3]
// val num1: int = 3


// tail-recursive
let rec lengthRec acc list =
    match list with
    | []   -> acc
    | _::xs -> lengthRec (acc + 1) xs

let length2 list = lengthRec 0 list
// val num2: int = 3



// define the lenghtRec as a local definition

let num2 = length2 [1; 2; 3]


// Recursive function consuming RussianDoll

let length3 list =
    let rec lengthRec acc remainder =
        match remainder with
        | []  -> acc
        | _::xs -> lengthRec (acc + 1) xs
 
    lengthRec 0 list

let num3 = length3 [1; 2; 3]
// val num3: int = 3


//  recursive types through discriminated union types.

// recursive definition
type RussianDoll =
    | Doll   // base case
    | Layer of RussianDoll  // recursive doll


let doll = Layer (Layer (Layer Doll))


let rec layers doll =
    match doll with
    | Doll  -> 0
    | Layer innerDoll ->  1 + layers innerDoll

let cnt1 = layers doll
// val cnt: int = 3
