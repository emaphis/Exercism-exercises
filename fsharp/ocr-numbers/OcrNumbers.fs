module OcrNumbers


/// Convert OCR digits (tuples) to string digits
let convertDigit (dig: string * string * string) =
   match dig with
   | ( " _ ",
       "| |",
       "|_|" )   -> "0"

   | ("   ", "  |", "  |")  -> "1"

   | ( " _ ",
       " _|",
       "|_ " )  -> "2"

   | ( " _ ",
       " _|",
       " _|" )  -> "3"

   | ( "   ",
       "|_|",
       "  |" ) -> "4"

   | ( " _ ",
       "|_ ",
       " _|" ) -> "5"

   | ( " _ ",
       "|_ ",
       "|_|" ) -> "6"

   | ( " _ ",
       "  |",
       "  |" ) -> "7"

   | ( " _ ",
       "|_|",
       "|_|" ) -> "8"

   | ( " _ ",
       "|_|",
       " _|" ) -> "9"

    | _ -> "?"

let convertDigits (inputList: string list list) =
    List.zip3 inputList[0] inputList[1] inputList[2]
    |> List.map convertDigit
    |> String.concat ""

let parseLine line =
    Seq.chunkBySize 3 line
    |> Seq.toList
    |> List.map (fun array -> System.String(array))

let parseInput input =
    input
    |> List.map parseLine
    |> List.chunkBySize 4
    |> List.map convertDigits
    |> String.concat "," // Numbers separated by empty lines are recognized. Lines are joined by commas.

let goodSize (input: string list) =
    input.Length % 4 = 0 &&
    input |> List.forall(fun str -> str.Length % 3 = 0)


let convert input =
    if goodSize input then Some (parseInput input)
    else None
