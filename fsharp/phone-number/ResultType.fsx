// Result Type - Phone Number

// Result type is a powerful tool for handling errors and modeling computations that can either succeed or fail.

(*// has type of
type Result<'T, 'TError> =
    | Ok of 'T
    | Error of 'TError

// Ok represents a successful computation with a value of type 'T.
// Error represents a failure with an error value of type 'TError.
 *)


// Usage
// The Result type forces you to explicitly handle both success and failure cases, making your code more robust
// and predictable.

// Example

let divide x y =
    if y = 0 then
        Error "Division by zero"
    else
        Ok (x / y)

do match divide 10 2 with
   | Ok result -> printfn $"Result: {result}"
   | Error err -> printfn $"Error: {err}"
// Result: 5


do match divide 10 0 with
   | Ok result -> printfn $"Result: {result}"
   | Error err -> printfn $"Error: {err}"
// Error: Division by zero


// Chaining with Result

let bind f result =
    match result with
    | Ok value -> f value
    | Error err -> Error err
// val bind: f: ('a -> Result<'b,'c>) -> result: Result<'a,'c> -> Result<'b,'c>

let safeDivide x y =
    if y = 0 then Error "Division by zero"
    else Ok (x / y)
// val safeDivide: x: int -> y: int -> Result<int,string>

let compute =
    safeDivide 10 2
    |> bind (fun res -> safeDivide res 2)
//val compute: Result<int,string> = Ok 2

match compute with
| Ok value -> printfn $"Final Result: {value}"
| Error err -> printfn $"Error: {err}"
// Final Result: 2


// Use built in `bind` method

let compute2 =
    safeDivide 10 2
    |> Result.bind (fun res -> safeDivide res 2)

match compute2 with
| Ok value -> printfn $"Final Result: {value}"
| Error err -> printfn $"Error: {err}"
// Final Result: 2
