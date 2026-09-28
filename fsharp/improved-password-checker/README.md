# Improved Password Checker

Welcome to Improved Password Checker on Exercism's F# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.

## Introduction

The Flags attribute allows the values defined in a discriminated union to be represented as bit positions (i.e. flags).
As flags, such values can be combined, making it possible for multiple boolean conditions to be represented in a single value.

```fsharp
[<Flags>]
type PhoneFeatures =
| Call = 1
| Text = 2
```

```fsharp
[<Flags>]
type PhoneFeaturesBinary =
| Call = 0b00000001
| Text = 0b00000010
```

Setting a flag can be done with the bitwise OR operator (`|||`); unsetting a flag can be done with a combination of the bitwise AND operator (`&&&`) and the bitwise negation operator (`~~~`).
While checking a flag's state can be done with the bitwise AND operator, one can also use the `HasFlag()` method.

```fsharp
let features = PhoneFeatures.Call

// Set the Text flag
let moreFeatures = features ||| PhoneFeatures.Text

moreFeatures.HasFlag(PhoneFeatures.Call) // => true
moreFeatures.HasFlag(PhoneFeatures.Text) // => true
```

See [Summary of Bitwise Operators][bitwise-operators] for a complete list of the bitwise operators available in the F# language.

[bitwise-operators]: https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/symbol-and-operator-reference/bitwise-operators#summary-of-bitwise-operators

## Instructions

The goal of this exercise is to improve upon the Password Checker exercise.
Since a given password will likely violate more than one rule at a time, a useful password checker ought to communicate to the user all the rules that are violated, instead of just the first one that happens to be discovered.
The improved password checker should indicate all of the rules being violated by a given password in one go.

The rules for this password checker are the same as in the previous Password Checker exercise:

- Must have 12 or more characters
- Must have at least one uppercase letter
- Must have at least one lowercase letter
- Must have at least one digit
- Must have at least one symbol in the set !@#$%^&\*

## 1. Modify the `PasswordError` discriminated union to allow the individual values to be treated as flags

Note that the tests will not compile until this essential step is complete.

## 2. Implement the `checkPassword` function

The `checkPassword` function checks the given password against the aforementioned rules.
The function should return a `Result` value, where `Ok` is returned when the password satisfies all rules, and an `Error` value when it fails one or more rules.
If the given password fails multiple rules, the `PasswordError` value should represent all of the failing rules.

```fsharp
checkPassword "abcdefghijk5"
// => Error (PasswordError.MissingUppercaseLetter ||| PasswordError.MissingSymbol)
```

## 3. Implement the ``getStatusPhrases` function

The `getStatusPhrases` function returns a set of strings each containing a human-readable phrase corresponding to one of the erorrs in the result returned from `checkPassword`.

```fsharp
getStatusPhrases (Error PasswordError.MissingDigit ||| PasswordError.LessThan12Characters)
// => List ["12 characters"; "digit"]
```

## Source

### Created by

- @blackk-foxx

### Contributed to by

- @ErikSchierboom