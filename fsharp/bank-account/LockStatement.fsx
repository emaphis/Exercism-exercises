// Lock statement - Bank Account

open System

let locker = obj() // object used for locking
let mutable counter = 0

let incrementCounter () =
    lock locker (fun () ->
        // Critical section
        counter <- counter + 1
        printfn "Counter is now %d" counter
    )

// Simulate multiple threads
[ for _ in 1 .. 5 -> async { incrementCounter() } ]
|> Async.Parallel
|> Async.RunSynchronously
|> ignore
