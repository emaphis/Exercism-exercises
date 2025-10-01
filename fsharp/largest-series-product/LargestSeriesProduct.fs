module LargestSeriesProduct

open System

let largestProduct input seriesLength : int option =
    if Seq.length input < seriesLength || seriesLength < 0 then None
    else if not (Seq.forall Char.IsDigit input) then None
    else
        input
        |> Seq.map (fun chr -> int chr - int '0')
        |> Seq.windowed seriesLength
        |> Seq.map (Array.fold (*) 1)
        |> Seq.max
        |> Some
