// Floating Point Numbers - <https://exercism.org/tracks/fsharp/exercises/interest-is-interesting>

// F# hast three types of floating point numbers

// single - 4 bytes
let single1 = 2.45f  // float32

// float - 8 bytes
let float1 = 2.45  // also `double`
let float2 = 2.3E+32

// decimal - 16 bytes - monetary data
let dec1 = 2.45M

// conversion operators
let floatFromSingle = float 2.45f
