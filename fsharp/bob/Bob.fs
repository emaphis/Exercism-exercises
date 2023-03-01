module Bob

let isSilent input = input = ""

let isQuestion (input: string) = input.EndsWith('?')

let isShout (input: string) = input <> input.ToLower() && input = input.ToUpper()

let response (input: string): string =
    let input = input.Trim()  
    
    if   (isSilent(input)) then    "Fine. Be that way!"
    elif (isQuestion(input) &&
          isShout(input)) then     "Calm down, I know what I'm doing!"
    elif (isQuestion(input)) then  "Sure."
    elif (isShout(input)) then     "Whoa, chill out!"
    else                           "Whatever."
