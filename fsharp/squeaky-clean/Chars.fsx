// Chars - Characters - <https://exercism.org/tracks/fsharp/exercises/squeaky-clean>

// A Char is a 16 bit (2 Byte) value representing a character.

let ch = 'A'
// val ch: char = 'A'


// String are arrays of chars

let str = "Exercism"

let char1 = str[4]
// val char1: char = 'c'

let str1 = char1.ToString()
// val str1: string = "c"


// Iterating over a string returns a char at each step.
// Using higher order functions and anonymous functions to iterate over strings to produce chars

let array1 = [| for c in "F#" -> c, int c |]
// val array1: (char * int) array = [|('F', 70); ('#', 35)|]

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


// .NET libraries help with extracting chars from strings, in this case Seq methods:

let lst1 = Seq.toList "Exercism"
// val lst1: char list = ['E'; 'x'; 'e'; 'r'; 'c'; 'i'; 's'; 'm']

let arry1 = Seq.toArray "Zurich"
// val arry1: char array = [|'Z'; 'u'; 'r'; 'i'; 'c'; 'h'|]


// There are various ways to convert a character list (or array) to a string

let arry2 = ['E'; 'x'; 'e'; 'r'; 'c'; 'i'; 's'; 'm'] 

// with a .NET method
let str2 = System.String.Concat arry2
// al str2: string = "Exercism"

// with String.concat
let str3 = String.concat "" (List.map string arry2)
// val str3: string = "Exercism"

// with a string constructor
let cc = [| for c in arry2 -> c |]
let str4 = new string(cc)
// val str4: string = "Exercism"

// with StringBuilder
open System.Text
let str5 =
    string (List.fold (fun (sb:StringBuilder) (c:char) -> sb.Append(c))  (StringBuilder())  arry2)
// val str5: string = "Exercism"
