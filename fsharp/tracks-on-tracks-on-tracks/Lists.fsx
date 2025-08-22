// Lists <https://exercism.org/tracks/fsharp/exercises/tracks-on-tracks-on-tracks>

// A list in F# is an immutable collection of zero or more values. The values in a list must all have the same type. 


// definition

let empty1 = []
let empty2 = List.empty

let singleValue1 = [5]
let singleValue2 = List.singleton 5

let threeValues = ["a"; "b"; "c"]


// add an element using `::`

let twoToFour = [2; 3; 4]
// val twoToFour: int list = [2; 3; 4]

let oneToFour = 1 :: twoToFour
// val int list = [1; 2; 3; 4]


// List can be appended using the @ operator or List.append

let lst1 = [6; 7] @ [8; 9]
// val lst1: int list = [6; 7; 8; 9]

let lst2 = List.append [6; 7] [8; 9]
// val lst2: int list = [6; 7; 8; 9]


// head - first element; tail - everything else

List.head oneToFour  // 1
List.tail oneToFour  // [2; 3; 4]


// Lists can be manipulated with functions snd methods in the List module

let len1 = List.length [7; 8]
// val len1: int = 2

let len2 = [7; 8].Length
// val len2: int = 2


// Lists can be manipulated  with pattern matching using `::` patterns.

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
