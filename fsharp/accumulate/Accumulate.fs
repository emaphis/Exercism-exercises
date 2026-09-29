module Accumulate

// Reimplementation of the standard `map` function.  Tail-call loop helper
// function to handle stack-overflow. Natural recursion puts list items in
// reverse order. Reused the loop function passing the do-nothing `id` to
// re-reverse the list.

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =

    let rec loop func lst acc =
        match lst with
        | [] -> acc
        | x::xs -> loop func xs (func x :: acc)

    let reverse list = loop id list []

    reverse (loop func input [])
