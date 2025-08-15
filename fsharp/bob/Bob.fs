module Bob


let response (input: string): string =
    let isSilence (input : string) = input.Length = 0
    let isShout (input: string) = input <> input.ToLower() && input = input.ToUpper()
    let isQuestion (input : string) = input.EndsWith '?'
    
    let input = input.Trim()

    if isShout input && isQuestion input then "Calm down, I know what I'm doing!"
    elif isShout input  then "Whoa, chill out!"
    elif isQuestion input then "Sure."
    elif isSilence input then "Fine. Be that way!"
    else "Whatever."
