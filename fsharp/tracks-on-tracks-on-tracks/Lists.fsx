// Lists <https://exercism.org/tracks/fsharp/exercises/tracks-on-tracks-on-tracks>

// definition

let empty = []
let singleValue = [5]
let threeValues = ["a"; "b"; "c"]


// add an element

let twoToFour = [2; 3; 4]
let oneToFour = 1 :: twoToFour
// nt list = [1; 2; 3; 4]


// head - first element; tail - everything else

List.head oneToFour  // 1
List.tail oneToFour  // [2; 3; 4]


// Lists can be manipulated with functions snd methods in the List module and
// with pattern matching

let describe1 list =
    match list with
    | []  -> "Empty list"
    | head::tail -> $"Non-empty list with head: {head} and tail: {tail}"
    
let str1 = describe1 []
let str2 = describe1 [1]
let str3 = describe1 [5; 7; 9]


// You can discard values in pattern matching with the '_' symbol.

let describe2 list =
    match list with
    | []  -> "Empty list"
    | [x] -> $"List with one item: {x}"
    | [_; y] -> $"List with two items, first item is ignored, second {y}"
    | _ -> "List with many items (all items ignored)"
    
let str4 = describe2 []
let str5 = describe2 [1]
let str6 = describe2 [5; 7]
let str7 = describe2 [5; 7; 9]
