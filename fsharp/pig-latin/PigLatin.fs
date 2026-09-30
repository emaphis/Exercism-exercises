module PigLatin

let latinizeWord  (word : string) =
    let vowelish = [ "a"; "e"; "i"; "o"; "u"; "yt"; "xr" ]
    let exceptions = [ "thr"; "sch"; "ch"; "qu"; "th"; "sh"; "rh" ]

    if vowelish |> List.exists word.StartsWith then
        word + "ay"
    elif exceptions |> List.exists word.StartsWith then
        let baseWord = exceptions |> List.filter word.StartsWith |> List.head
        word[baseWord.Length..] + baseWord + "ay"
    elif word[1..].StartsWith("qu") then
        word[3..] + word[0..2] + "ay"
    else
        word[1..] + string word[0] + "ay"


// `input` is a string of words separated by spaces
let translate (input: string) =
    input.Split(' ')
    |> Array.map latinizeWord
    |> String.concat " "
