// Arrays

// cntr \

let empty = [|  |]
let empty2 = Array.empty

let singleValue = [| 5 |]
let singleValue1 = Array.singleton 5

let threeValues = [| "a"; "b"; "c" |]

// assigning and retrieving values

let numbers = [| 2; 3; 5 |]

numbers[2] <- 9
// [|2; 3; 9|]

let num1 = numbers[2]
// 9

// Arrays can be manipulated by functions and operators
// defined in the `Array` module or pattern matching

let describe1 array =
    match array with
    | [||] -> "Empty"
    | [| 1; 2; three |] -> $"1, 2, {three}"
    | _ -> "Other"

let str1 = describe1 [|  |]
let str2 = describe1 [| 1; 2; 4 |]
let str3 = describe1 [| 5; 7; 9 |]


let describe2 array =
    match array with
    | [||] -> "Empty array"
    | [| x |] -> $"Array with one item: {x}"
    | [| _; y |] -> $"Array with two items first item ignored, {y}"
    | _ -> "Array with many items"

let str4 = describe2 [|  |]
let str5 = describe2 [| 1  |]
let str6 = describe2 [| 5; 7 |]
let str7 = describe2 [| 5; 7; 9 |]
