module Raindrops

// Extensible solution: Add (divisor, drop sound) pairs to the `mapping` list
// passed to the calcRainDrop function.

/// Produce raindrop sound or number as a string given a list of divisor drop sound pair
/// and number to test
let calcRainDrop mapping n =
    let rec loop mapping acc =
        match mapping with
        | []    -> if acc = "" then string n else acc
        | head::tail ->
            let value =
                head |> (fun (div, drop) -> if n % div = 0 then drop else "")
            loop tail (acc + value)
    loop mapping ""

let convert (number: int): string =
    let mapping = [ (3, "Pling"); (5, "Plang"); (7, "Plong") ]
    calcRainDrop mapping number

// test
//let drops =
//    [1..105] |> List.map (isRainDrop [ (3, "Pling"); (5, "Plang"); (7, "Plong") ])
