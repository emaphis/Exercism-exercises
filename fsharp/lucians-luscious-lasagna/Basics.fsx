// Basics - <https://exercism.org/tracks/fsharp/exercises/lucians-luscious-lasagna>

// Variable bindings with automatically inferred types.

let fingers = 10
// val fingers: int = 10


// Functions are also variable bindings but with parameters

let add x y = x + y
// val add: x: int -> y: int -> int

// invoking a function is done by specifying its name and passing parameters

let five = add 2 3
//val five: int = 5


// if you want to avoid type inference you can specify types

let fingers1 : int = 10
// val fingers1: int = 10

let add1 (x: int) (y: int): int = x + y
//val add1: x: int -> y: int -> int


// F# uses significant whitespace to indicate scope

let toes =
    let left = 5
    let right = 5
    left + right
// val toes: int = 10

let multiplyPlusTwo x y =
    let product = x * y
    product + 2
// val multiplyPlusTwo: x: int -> y: int -> int

let tt = multiplyPlusTwo toes 2
// val tt: int = 22


// A module groups related functionality and is defined using the module keyword.

module calculator =

    let pi = 3.14
    
    let add x y = x + y
    
    
let num1 = calculator.add calculator.pi 3.0
// val num1: float = 6.14
