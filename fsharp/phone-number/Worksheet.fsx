// Phone numbers


open System

/// Clean common punctuations chars from input string
let cleanInput (input: string): string =
    input
    |> Seq.filter (fun c -> not (List.contains c ['+';'.';'-';' ';'(';')']))
    |> String.Concat

/// Validate the common lengths of the number
/// Should be 10 length, 11 starting with 1 if long distance
let validateLength (input: string) =
    match input.Length with
    | 10  -> Ok input
    | 11 when input[0] = '1'  -> Ok input[1..]
    | 11 when input[0] <> '1' -> Error "11 digits must start with 1"
    | length when length > 11 -> Error "more than 11 digits"
    | _ -> Error "incorrect number of digits"

/// Number should not conatain letters or punctuation
let validateNumeric (input: string) =
    match input with
    | inpt when Seq.forall Char.IsNumber inpt -> Ok input
    | inpt when Seq.exists Char.IsLetter inpt -> Error "letters not permitted"
    | inpt when Seq.exists Char.IsPunctuation inpt -> Error "punctuations not permitted"
    | _  -> Error "I don't know why I got here."

/// Area code can't start with 0 or 1
let validateAreaCode (input: string) =
    match input[0] with
    | '0' -> Error "area code cannot start with zero"
    | '1' -> Error "area code cannot start with one"
    | _ -> Ok input


/// Exchange code can't start with 0 or 1
let validateExchangeCode (input: string) =
    match input[3] with
    | '0' -> Error "exchange code cannot start with zero"
    | '1' -> Error "exchange code cannot start with one"
    | _ -> Ok input


let phone1 = "(223) 456-7890"
let phone2 = "223.456.7890"    // Ok: 10 digits.
let phone3 = "123456789"       // Error: 9 digits.
let phone4 = "523-abc-7890"    // Error: No lettere
let phone5 = "(023) 456-7890"  // Error: Area code starts with 0 
let phone6 = "(123) 456-7890"  // Error: Ares code starts with 1
let phone7 = "(223) 056-7890"  // Error: Exchange code starts with 0


let clean (input: string) : Result<uint64,string> =
    input
    |> cleanInput
    |> validateLength
    |> Result.bind validateNumeric
    |> Result.bind validateAreaCode
    |> Result.bind validateExchangeCode
    |> Result.bind (fun string -> Ok (uint64 string))
    

let out = clean phone7
out


let res1 = Ok 2234567890UL
out = res1
