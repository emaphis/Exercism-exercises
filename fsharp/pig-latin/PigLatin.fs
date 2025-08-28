module PigLatin

let latinizeWord  (word : string) =
    let vowelish = [ "a"; "e"; "i"; "o"; "u"; "yt"; "xr" ]
    let others = [ "thr"; "sch"; "ch"; "qu"; "th"; "sh"; "rh" ]

    let root =
        if vowelish |> List.exists word.StartsWith then
            word
        elif others |> List.exists word.StartsWith then
            let baseWrd = others |> List.filter word.StartsWith |> List.head
            word[baseWrd.Length..] + baseWrd
        elif word[1..].StartsWith("qu") then
            word[3..] + word[0..2]
        else
            word[1..] + string word[0]

    root + "ay"


// `input` is a sting of words separated by spaces
let translate (input: string) =
    let array =input.Split(' ')
    array
    |> Array.toList
    |> List.map latinizeWord
    |> String.concat " "
