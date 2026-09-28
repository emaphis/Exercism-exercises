module ImprovedPasswordChecker

open System

[<Flags>]
type PasswordError =
    | None                   = 0b00000000
    | LessThan12Characters   = 0b00000001
    | MissingUppercaseLetter = 0b00000010
    | MissingLowercaseLetter = 0b00000100
    | MissingDigit           = 0b00001000
    | MissingSymbol          = 0b00010000

/// Validate the given password against the rules defined in the instructions. If it meets
/// all the rules, return a result indicating success; otherwise return a result indicating
/// failure with an error value indicating all the rules that were violated.
let checkPassword (password: string) : Result<string, PasswordError> =
    let list = [
            ((fun (s: string) -> s.Length >= 12), PasswordError.LessThan12Characters);
            (String.exists Char.IsDigit, PasswordError.MissingDigit);
            (String.exists Char.IsLower, PasswordError.MissingLowercaseLetter);
            (String.exists Char.IsUpper, PasswordError.MissingUppercaseLetter);
            (String.exists "!@#$%^&*".Contains, PasswordError.MissingSymbol)
        ]
    let errors =
        list
        |> List.filter (fun (test, error) -> password |> test |> not)
        |> List.map snd
        |> List.fold (|||) PasswordError.None

    if errors = PasswordError.None then
        Ok password
    else
        Error errors

/// Return a list of human-readable phrases indicating the meaning of the given result value.
let getStatusPhrases (result: Result<string, PasswordError>) : string list =
    match result with
    | Error error -> (
            [
                (PasswordError.LessThan12Characters, "12 characters");
                (PasswordError.MissingUppercaseLetter, "uppercase letter");
                (PasswordError.MissingLowercaseLetter, "lowercase letter");
                (PasswordError.MissingDigit, "digit");
                (PasswordError.MissingSymbol, "symbol")
            ]
            |> List.filter (fun (flag, msg) ->
                error.HasFlag(flag))
            |> List.map snd
        )
    | _ -> []

