module NthPrime

/// Check if number is prime
let isPrime n =
    let last = int (sqrt (float n))
    seq { 2 .. last }
    |> Seq.exists (fun num -> n % num = 0)
    |> not


/// Lazy sequence of primes
let primes =
    Seq.initInfinite id
    |> Seq.skip 1
    |> Seq.choose (fun num ->
                            if isPrime num then Some num
                            else None )
    

let prime nth : int option =
    if nth <= 0 then None
    else
        primes
        |> Seq.item nth
        |> Some
