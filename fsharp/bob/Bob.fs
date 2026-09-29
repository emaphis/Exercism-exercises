module Bob

let response (input: string): string =
    let isSilence (input : string) = input.Length = 0
    let isShout (input: string) = input <> input.ToLower() && input = input.ToUpper()
    let isQuestion (input : string) = input.EndsWith '?'

    let input = input.Trim()

    match input with
    | _ when isShout input && isQuestion input -> "Calm down, I know what I'm doing!"
    | _ when isShout input    -> "Whoa, chill out!"
    | _ when isQuestion input -> "Sure."
    | _ when isSilence input  -> "Fine. Be that way!"
    | _ -> "Whatever."
