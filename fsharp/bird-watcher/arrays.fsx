// Arrays

// An array in F# is a mutable collection of zero or more values with a fixed length.

let empty = [|  |]
let empty2 = Array.empty

let singleValue = [| 5 |]
let singleValue1 = Array.singleton 5

let threeValues = [| "a"; "b"; "c" |]


// assigning and retrieving values

let numbers = [| 2; 3; 5 |]

// Update value in array
numbers[2] <- 9
// [|2; 3; 9|]

// Read value from array
let num1 = numbers[2]
// 9


// Arrays are manipulated by functions and operators defined in the Array module.
// ome of these functions are also available as properties of an array instance:

let len1 = Array.length [| 7; 8 |]
// val len1: int = 2

let len2 = [| 7; 8 |].Length
// val len2: int = 2


// Arrays can be manipulated by functions and operators
// defined in the `Array` module or pattern matching

// The array pattern allows pattern matching on arrays:

let describe1 array =
    match array with
    | [||] -> "Empty"
    | [| 1; 2; three |] -> $"1, 2, {three}"
    | _ -> "Other"

let str1 = describe1 [|  |]
// val str1: string = "Empty"

let str2 = describe1 [| 1; 2; 4 |]
// val str2: string = "1, 2, 4"

let str3 = describe1 [| 5; 7; 9 |]
// val str3: string = "Other"


// You can also discard a value when pattern matching; when you do not care about a value
// use an underscore ('_') to signify this:

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
