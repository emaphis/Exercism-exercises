open System

// Function to perform Run-Length Encoding
let runLengthEncode (input: string) : string =
    if String.IsNullOrEmpty(input) then
        ""
    else
        input
        |> Seq.fold (fun (acc, prevChar, count) char ->
            if char = prevChar then
                (acc, prevChar, count + 1)
            else
                let encoded = if count > 0 then acc + string count + string prevChar else acc
                (encoded, char, 1)
        ) ("", '\000', 0)
        |> fun (acc, prevChar, count) -> acc + string count + string prevChar

// Function to perform Run-Length Decoding
let runLengthDecode (input: string) : string =
    let rec decodeHelper chars acc count =
        match chars with
        | [] -> acc
        | head :: tail when Char.IsDigit head ->
            decodeHelper tail acc (count * 10 + int (head.ToString()))
        | head :: tail ->
            let expanded = String.replicate count (string head)
            decodeHelper tail (acc + expanded) 0
    decodeHelper (Seq.toList input) "" 0

// Main function to test the implementation
[<EntryPoint>]
let main argv =
    // Test Run-Length Encoding
    let original = "aaabbbcccdde"
    let encoded = runLengthEncode original
    printfn "Original: %s" original
    printfn "Encoded: %s" encoded

    // Test Run-Length Decoding
    let decoded = runLengthDecode encoded
    printfn "Decoded: %s" decoded

    // Verify correctness
    if original = decoded then
        printfn "Success: Decoded matches the original!"
    else
        printfn "Error: Decoded does not match the original."

    0 // Return an integer exit code
