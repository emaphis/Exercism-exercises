module NthPrime

/// Lazy sequence of primes.using Sieve of Eratosthenes
let lazyPrimes =
    let rec sieve (numbers: int seq) =
        seq {
            let head = Seq.head numbers  // Take the first number as prime
            yield head                               // Yield the prime number
            yield! sieve (Seq.filter (fun x -> x % head <> 0) (Seq.tail numbers))
        }
    sieve (Seq.initInfinite ((+) 2))  // Start with 2 as a prime
    

let prime nth : int option =
    let seq1 = lazyPrimes |> Seq.take nth
    try 
        Some (Seq.last seq1)
    with
        :? System.InvalidOperationException  -> None
