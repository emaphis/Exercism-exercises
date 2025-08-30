module PhoneNumber

open System

/// Clean common punctuations chars from input string
let normalize input =
    input
    |> Seq.filter (fun chr -> not (List.contains chr [ '(';')';'-';' ';'.';'+' ]))
    |> String.Concat
    |> Ok

/// Validate the common lengths of the number
let validateLength (input: string) =
    match input.Length with
    | 10  -> Ok input
    | 11 when input[0] = '1'  -> Ok input[1..]
    | 11 when input[0] <> '1' -> Error "11 digits must start with 1"
    | length when length > 11 -> Error "more than 11 digits"
    | _ -> Error "incorrect number of digits"

let validateNumeric (input: string) =
    match input with
    | inpt when Seq.forall Char.IsNumber inpt -> Ok input
    | inpt when Seq.exists Char.IsLetter inpt -> Error "letters not permitted"
    | inpt when Seq.exists Char.IsPunctuation inpt -> Error "punctuations not permitted"
    | _  -> Error "I don't know why I got here."


let validateAreaCode (input: string) =
    match input[0] with
    | '0' -> Error "area code cannot start with zero"
    | '1' -> Error "area code cannot start with one"
    | _ -> Ok input

let validateExchangeCode (input: string) =
    match input[3] with
    | '0' -> Error "exchange code cannot start with zero"
    | '1' -> Error "exchange code cannot start with one"
    | _ -> Ok input


let clean (input: string) : Result<uint64,string> =
    normalize input
    |> Result.bind validateLength
    |> Result.bind validateNumeric
    |> Result.bind validateAreaCode
    |> Result.bind validateExchangeCode
    |> Result.bind (fun inpt -> Ok (uint64 inpt))
