module Isogram

open System

let normalize str =
    let chars = Seq.filter Char.IsLetter str
    Seq.map Char.ToLower chars
    
    
let isIsogram str = 
    let normalized = normalize str
    let orig =Seq.length normalized
    let dist = normalized |> Seq.distinct |> Seq.length
    orig = dist
