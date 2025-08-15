module ReverseString

let reverse (input: string): string =
    let array = input.ToCharArray()
    let reverse = Array.rev array
    System.String reverse
