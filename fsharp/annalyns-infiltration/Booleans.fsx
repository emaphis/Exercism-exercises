// Booleans - <https://exercism.org/tracks/fsharp/concepts/booleans>

// The bool type is represented by `true` `false`


// F# has three boolean operators `not` `&&` and `||`

let bool1 = true || false
// val bool1: bool = true

let bool2 = true && false
// val bool2: bool = false


// The tree operators have different precedence.
// `not` -> `&&` -> `||`

let bool3 = not true && false
// val bool3: bool = false

let bool4 = not (true && false)
// val bool4: bool = true
