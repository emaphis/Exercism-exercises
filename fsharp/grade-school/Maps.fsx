// Maps  - GradeSchool

// A map in F# is an immutable collection of key/value pairs, designed for efficient lookups and data association.
// Maps have very fast lookup using keys,


// words: Map<int,string>
let words = Map [1, "book"; 2, "sky"; 3, "work"; 4, "cloud"]

printfn $"%A{words}"
// map [(1, "book"); (2, "sky"); (3, "work"); (4, "cloud")]

// lookup is much like an array

printfn $"%s{words[1]}"
// book

printfn $"%s{words[4]}"
// cloud

// Maps can be manipulated with properties, methods and the Map package

let cnt1 = words.Count
// val cnt1: int = 4


// We can iterate over a Map

Map.iter (fun key value1 -> printfn $"{key}: {value1}") words
// 1: book
// 2: sky
// 3: work
// 4: cloud

for key in words.Keys do
    printf $"%d{key} "
// 1 2 3 4

for value in words.Values do
    printf $"%s{value} "
// book sky work cloud

for e in words do 
    printfn $"{e.Key}: {e.Value}"
// 1: book
// 2: sky
// 3: work
// 4: cloud


// Filtering maps with `Map.filter`

let words2 =
    Map [ 1, "book"
          2, "sky"
          3, "work"
          4, "cloud"
          5, "water"
          6, "war" ]

words2
|> Map.filter (fun _ v -> v.Contains "w")
|> Map.values
|> Seq.iter (printfn "%s")

// work
// water
// war


// Remove a specific pair returning a new Map

let map2 = words2.Remove 1

printfn $"%A{map2}"
//  map [(2, "sky"); (3, "work"); (4, "cloud"); (5, "water"); (6, "war")]

// immutable
printfn $"%A{words2}"
// map [(1, "book"); (2, "sky"); (3, "work"); (4, "cloud"); (5, "water"); (6, "war")]


// With Add, we add a new element to the map.

let map3 = Map.add 7 "falcon" words2

printfn $"%A{map3}"
// map [(1, "book"); (2, "sky"); (3, "work"); (4, "cloud"); (5, "water"); (6, "war");  (7, "falcon")]

// immutable
printfn $"%A{words2}"
// map [(1, "book"); (2, "sky"); (3, "work"); (4, "cloud"); (5, "water"); (6, "war")]


// We can create an empty map with Map.empty and add new elements with Add.

type User = {
    Name: string
    Occupation: string
}

let users =
    Map.empty.
        Add(1, {Name="John Doe"; Occupation="gardener"}).
        Add(2, {Name="Roger Roe"; Occupation="driver"}).
        Add(3, {Name="Lucy Smith"; Occupation="teacher"}).
        Add(4, {Name="Tom Jones"; Occupation="programmer"})

users |> Map.iter (fun k v -> printfn $"{k}: {v}")


// We define a list of maps.

let fruits1 = Map [ "oranges", 2; "bananas", 3 ]
let fruits2 = Map [ "plums", 4; "kiwis", 5 ]

let all = [ Map[1, fruits1]; Map[2, fruits2] ]

all
|> List.iter (Map.iter (fun k v -> printfn $"{k} {v}"))

// 1 map [(bananas, 3); (oranges, 2)]
// 2 map [(kiwis, 5); (plums, 4)]

for nested in all do
    for e in nested do
         printfn $"{e.Key} {e.Value}"

// 1 map [(bananas, 3); (oranges, 2)]
// 2 map [(kiwis, 5); (plums, 4)]
