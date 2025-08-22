module Raindrops

let rainMaker (divisor: int) (sound: string) =
    fun (number, acc) ->
        if number % divisor = 0 then (number, acc + sound)
        else (number, acc)

let pling = rainMaker 3 "Pling"
let plang = rainMaker 5 "Plang"
let plong = rainMaker 7 "Plong"


let convert (number: int): string =
    (number, "")
    |> pling
    |> plang
    |> plong
    |> fun output ->
        match output with
        | (num, "") -> num.ToString()
        | (_, sound) -> sound 