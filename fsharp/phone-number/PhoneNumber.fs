module PhoneNumber

open System


/// Clean common punctuations chars from input string
let cleanInput (input: string): string =
    input
    |> Seq.filter (fun c -> not (List.contains c ['+';'.';'-';' ';'(';')']))
    |> String.Concat


/// Validate the common lengths of the number.
/// Should be 10 length, 11 starting with 1 if long distance.
let validateLength (input: string) =
    match input.Length with
    | 10  -> Ok input
    | length  when length < 10 -> Error "must not be fewer than 10 digits"
    | 11 when input[0] = '1'  -> Ok input[1..]  // trim the first digit
    | 11 when input[0] <> '1' -> Error "11 digits must start with 1"
    | length when length > 11 -> Error "must not be greater than 11 digits"
    | _ -> Error "incorrect number of digits"


/// Number should not contain letters or punctuation
let validateNumeric (input: string) =
    match input with
    | input when Seq.forall Char.IsNumber input -> Ok input
    | input when Seq.exists Char.IsLetter input -> Error "letters not permitted"
    | input when Seq.exists Char.IsPunctuation input -> Error "punctuations not permitted"
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


let clean (input: string) : Result<uint64,string> =
    input
    |> cleanInput
    |> validateLength
    |> Result.bind validateNumeric
    |> Result.bind validateAreaCode
    |> Result.bind validateExchangeCode
    |> Result.bind (fun string -> Ok (uint64 string))
