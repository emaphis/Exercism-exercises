# Password Checker

Welcome to Password Checker on Exercism's F# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.

## Introduction

The `Result` type makes it possible for a function to return a single value indicating all of the following things:
- Whether the operation succeeded or failed
- On success, the resulting value of the operation
- On failure, the reason for the failure

## Usage

The `Result` type is a generic type containing two underlying types:
- The type of the resultant value on a successful operation
- The type of error on a failure

The `Result` type is also a [discriminated union][discriminated-union] with the following possible cases:
* `Ok <value>` representing a successful result
* `Error <reason>` representing a failure

The following function demonstrates how to create a `Result` value:

```fsharp
let validateName (name: string) : Result<string, string> = 
    match name with
    | null -> Error "Name not found."
    | "" -> Error "Name is empty."
    | _ -> Ok name
```

In this example, the `Ok` value is a string (the given name), and the `Error` value is also a string (the cause of the error, in human-readable form).

## Reading the content of a `Result` value

Consider the following type definition and function signature:

```
type FileOpenError = 
| NotFound
| AccessDenied
| FileLocked

let openFile (filename: string) : Result<int, FileOpenError> =
```

Code that calls the `openFile` function can use pattern matching to handle the success and failure cases, as in the following example:

```fsharp
match openFile(filename) with
| Ok handle -> doSomethingWithFile(handle)
| Error NotFound -> printfn $"Error: file {filename} was not found."
| Error AccessDenied -> printfn $"Error: you do not have permission to open the file {filename}."
| Error FileLocked -> printfn $"Error: file {filename} is already in use."
```

## Instructions

Your task is to create a password checker.
A password checker validates a user's proposed password to ensure that it meets a set of requirements defined by the organization that controls access to the given resource.

For this exercise, the password requirements are:
* Must have 12 or more characters
* Must have at least one uppercase letter
* Must have at least one lowercase letter
* Must have at least one digit
* Must have at least one symbol in the set !@#$%^&*

Your solution must use a `Result` to encapsulate the success or failure status.
For the success case, the `Result` must convey the validated password as a string.
For the failure case, the `Result` must convey the rule that was violated in the failure case.

~~~~exercism/note
For this exercise, the password checker will be simplistic -- it will indicate only when a single rule has been violated.
A subsequent exercise will explore a more realistic password checker that can indicate when multiple rules have been violated at the same time.
~~~~

## 1. Implement the `checkPassword` function

The `checkPassword` function checks the given password against the aforementioned rules.  On failure, it indicates the rule that was violated by encapsulating one of the `PasswordRule` values within the result value.

```fsharp
checkPassword "abcdefghij5#"
// => Error MissingUppercaseLetter
```

## 2. Implement the ``getStatusMessage` function

The `getStatusMessage` function returns a string containing a human-readable message indicating the meaning of the result returned from `checkPassword`.

```fsharp
getStatusMessage (Error MissingDigit)
// => "Error: does not have at least one digit"
```

## Source

### Created by

- @blackk-foxx