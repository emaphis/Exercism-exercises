module PalindromeProducts


/// True if number is a palindrome, using fast reverse' algo
let isPalendrome' num =

    // fast (mutable) reverse algo
    // Goes from about 12 seconds to 3 seconds on the 4 digit exampesls
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
            let prod = x * y
            if isPalendrome' prod then
                yield x*y, (x, y)]

let getValue palindromes (minmax: int list -> int) =
    palindromes
    |> List.map fst
    |> minmax 

let getFactors palindromes value =
    palindromes
    |> List.filter (fun x -> fst x = value)
    |> List.map snd
    |> List.sort

let calcMinMaxPalindrome (minmax: int list -> int) minFactor maxFactor =
    if minFactor > maxFactor then invalidArg "minFactor" "min must be <= max"
    
    let palindromes =
        getPalindromes minFactor maxFactor

    if List.isEmpty palindromes then (None, [])
    else
        let value= getValue palindromes minmax
        let factors = getFactors palindromes value

        (Some value, factors)

let largest minFactor maxFactor =
    calcMinMaxPalindrome List.max minFactor maxFactor

let smallest minFactor maxFactor =
   calcMinMaxPalindrome List.min minFactor maxFactor
