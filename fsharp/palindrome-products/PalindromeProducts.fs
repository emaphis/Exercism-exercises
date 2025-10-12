module PalindromeProducts


/// True if number is a palindrome, using fast reverse' algo
let isPalendrome' num =

    // fast (mutable) reverse algo    
    let reverse' num =
        let mutable current = num
        let mutable result = 0
        while (current > 0) do
            result <- result * 10 + current % 10
            current <- current / 10
        result

    num = reverse' num

let getPalindromes minFactor maxFactor   =
    [for y in minFactor .. maxFactor do
        for x in minFactor .. y do
            yield x*y, (x, y)]
    |> List.filter (fun x -> isPalendrome' (fst x))

let getValue palindromes pred =
    palindromes
    |> List.map fst
    |> pred 

let getFactors palindromes value =
    palindromes
    |> List.filter (fun x -> fst x = value)
    |> List.map snd
    |> List.sort


let largest minFactor maxFactor =
    if minFactor > maxFactor then invalidArg "minFactor" "min must be <= max"
    
    let palindromes =
        getPalindromes minFactor maxFactor

    if List.isEmpty palindromes then (None, [])
    else
        let value= getValue palindromes List.max
        let factors = getFactors palindromes value

        (Some value, factors)



let smallest minFactor maxFactor =
    if minFactor > maxFactor then invalidArg "minFactor" "min must be <= max"
    
    let palindromes =
        getPalindromes minFactor maxFactor

    if List.isEmpty palindromes then (None, [])
    else
        let value= getValue palindromes List.min
        let factors = getFactors palindromes value

        (Some value, factors)
