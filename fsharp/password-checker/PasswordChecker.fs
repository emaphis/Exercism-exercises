module PasswordChecker

open System

type PasswordError =
    | LessThan12Characters
    | MissingUppercaseLetter
    | MissingLowercaseLetter
    | MissingDigit
    | MissingSymbol

/// Validate the given password against the rules defined in the instructions. If it meets all
/// of the rules, return a result indicating success; otherwise return a result indicating
/// failure and an error indicating which rule was violated.
let checkPassword (password: string) : Result<string, PasswordError> =
    let symbols = "!@#$%^&*"
    match password with
    | pswd when pswd.Length < 12 -> Error LessThan12Characters
    | pswd when pswd |> String.exists System.Char.IsUpper  |> not -> Error MissingUppercaseLetter
    | pswd when pswd |> String.exists System.Char.IsLower  |> not -> Error MissingLowercaseLetter
    | pswd when pswd |> String.exists System.Char.IsDigit  |> not -> Error MissingDigit
    | pswd when pswd |> String.exists (fun chr -> symbols.Contains chr) |> not -> Error MissingSymbol
    | _ -> Ok password

/// Return a human-readable message indicating the meaning of the given result value.
let getStatusMessage (result: Result<string, PasswordError>) : string =
    let errMsg = "Error: does not have at least "
    match result with
    | Error LessThan12Characters   -> errMsg + "12 characters"
    | Error MissingUppercaseLetter -> errMsg + "one uppercase letter"
    | Error MissingLowercaseLetter -> errMsg + "one lowercase letter"
    | Error MissingDigit  -> errMsg + "one digit"
    | Error MissingSymbol -> errMsg + "one symbol"
    | Ok _ -> "OK"
