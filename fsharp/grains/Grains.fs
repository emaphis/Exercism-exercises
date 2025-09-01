module Grains

let square (n: int): Result<uint64,string> =
    if n > 0 && n <= 64 then
        Ok (pown 2UL (n - 1))
     else
        Error "square must be between 1 and 64"


let total: Result<uint64,string> =
    [ 1 .. 64 ]
    |> List.sumBy (fun num -> pown 2UL (num - 1)) |> Ok
