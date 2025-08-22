// Tuples - <https://exercism.org/tracks/fsharp/exercises/tisbury-treasure-hunt>

// An immutable grouping of ordered values.

let tpl1 = ("one", 2)
let tpl2 = ("one", 2, true)


// Only tuples of the same length and same type can be compared.
(1, 2) = (1, 2)  // true

(1, 2) = (2, 1)  // false

//(1, 2) = (1, "2") // wrong types

//(1, 2) = (1, 2, 3)  // wrong lenght


// three ways to extract values form tuples

let person = ("Jordan", 170)

// fst/snd
let name1 = fst person
let length1 = snd person

// deconstruction
let (name2, length2) = person

// pattern matching
match person with
| name3, length3 -> $"{name3}, {length3}"
