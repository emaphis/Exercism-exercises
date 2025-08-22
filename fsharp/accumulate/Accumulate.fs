module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =

    let rec loop func lst acc =
        match lst with
        | [] -> acc
        | x::xs -> loop func xs (func x :: acc)

    let reverse list = loop id list []

    reverse (loop func input [])
