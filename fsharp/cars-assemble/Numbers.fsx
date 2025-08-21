// Numbers -

// Integers and floats are distinct types in F#

// Ints and floats

let i = 123
let d = 54.29

// Chunks of numbers can be separated by '_' 

let largeInt = 1_000_000
let largeFloat = 9_876_543.21

// Arithmetic can be done with the standard operators + - * /
// Numbers can be compared by the standard operators < >= = <>

5 * 6
1.2 > 0.8
2 <> 4


// You can't combine different numerical types in F#
// Converting between types.

let floatFromInt = float 2
let intFromFloat = int 3.39

