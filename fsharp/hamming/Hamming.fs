module Hamming
 

let distance (strand1: string) (strand2: string): int option =
   
   (*  // Recursive solution 
   let list1 = Seq.toList strand1
   let list2 = Seq.toList strand2
 
   let rec loop lst1 lst2 acc =
       match lst1, lst2 with
       | [], []    -> Some acc
       | xs, []    -> None
       | [], ys    -> None
       | xs, ys when xs.Length <> ys.Length -> None 
       | x::xs, y::ys when x <> y ->  loop xs ys (acc + 1)
       | _::xs, _::ys -> loop xs ys acc
        
   loop list1 list2 0
   *)

   // Higher order functions
   if strand1.Length <> strand2.Length then None
   else 
       Seq.zip strand1 strand2
       |> Seq.map (fun (chr1, chr2) -> chr1 <> chr2)
       |> Seq.filter (fun bl -> bl)
       |> Seq.length
       |> Some
