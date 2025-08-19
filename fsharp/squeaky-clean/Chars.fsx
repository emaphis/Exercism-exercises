// Chars - Characters - <https://exercism.org/tracks/fsharp/exercises/squeaky-clean>

// A Char is a 16 bit value representing a character.

let ch = 'A'
// val ch: char = 'A'


// String are arrays of chars

let char1 = "Exercism"[4]
// val char1: char = 'c'


// Iterating over a string returns a char at each step.
// Using higher order functions and anonymous functions to iterate over strings to produce chars

Seq.map (fun c -> c, int c) "F#"
// val it: (char * int) seq = seq [('F', 70); ('#', 35)]

Seq.map (fun c -> c, int c) "東京"
// val it: (char * int) seq = seq [('東', 26481); ('京', 20140)]


// The underlying `int16` can be used to compare chars

'A' < 'D'  // true

// casting ints to chars

char 77  // 'M'


// `System.Char contains a set of methods that operate on chars

'a' |> System.Char.ToUpper  // 'A'
'Q' |> System.Char.ToLower  // 'q'
