module RunLengthEncoding

open System

let rec encode (input: string) =
    if String.IsNullOrEmpty(input) then ""
    else
        input
        |> Seq.fold (fun (acc, prev, count) chr ->
            if chr = prev then 
                (acc, prev, count + 1)
            else
                let encoded = 
                    if count = 1 then acc + string prev
                    elif count > 1 then acc + string count + string prev
                    else acc
                (encoded, chr, 1)
        ) ("", ' ', 0)
        |> fun (acc, prev, count) -> 
            if count = 1 then acc + string prev
            else acc + string count + string prev


let decode input =

   let digitToInt c = int c - int '0'
    
   let loop (decoded, (count: int option)) item =
          let count' = Option.fold (fun acc x -> acc + x * 10) (digitToInt item) count |> Some
          let updateDecoded = Option.fold (fun acc x -> acc + String(item, x - 1)) (decoded + string item) count

          if Char.IsDigit item then (decoded, count') else (updateDecoded, None)

   input 
   |> Seq.fold loop ("", None) |> fst
    
