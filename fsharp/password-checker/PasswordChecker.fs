module PasswordChecker

open System

type PasswordError =
    | LessThan12Characters
    | MissingUppercaseLetter
    | MissingLowercaseLetter
    | MissingDigit
    | MissingSymbol

/// Validate the given password against the rules defined in the instructions. If it meets
/// all the rules, return a result indicating success; otherwise return a result indicating
/// failure and an error indicating which rule was violated.
let checkPassword (password: string) : Result<string, PasswordError> =
    match password with
    | _ when password.Length < 12 -> Error LessThan12Characters
    | _ when not (password |> String.exists Char.IsUpper) -> Error MissingUppercaseLetter
    | _ when not (password |> String.exists Char.IsLower) -> Error MissingLowercaseLetter
    | _ when not (password |> String.exists Char.IsDigit) -> Error MissingDigit
    | _ when not (password |> String.exists "!@#$%^&*".Contains) -> Error MissingSymbol
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
