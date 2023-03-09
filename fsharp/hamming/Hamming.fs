module Hamming
 

let distance (strand1: string) (strand2: string): int option =

    (* // Recursive solution 
    let rec loop lst1 lst2 acc =
       match lst1, lst2 with
       | [], []         -> Some acc
       | _,  []         -> None
       | [], _          -> None 
       | x::xs, y::ys when x <> y
                        -> loop xs ys (acc + 1)
       | _::xs, _::ys   -> loop xs ys acc

    loop (Seq.toList strand1) (Seq.toList strand2) 0
*)

   // Higher order functions
   if strand1.Length <> strand2.Length then None
   else 
       Seq.zip strand1 strand2
       |> Seq.filter (fun (chr1, chr2) -> chr1 <> chr2)
       |> Seq.length
       |> Some
