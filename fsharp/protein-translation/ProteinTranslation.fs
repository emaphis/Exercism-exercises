module ProteinTranslation

let convertToProtein codone = 
    match codone with
    | "AUG"                         -> "Methionine"
    | "UUC" | "UUU"                 -> "Phenylalanine"
    | "UUA" | "UUG"                 -> "Leucine"
    | "UCU" | "UCC" | "UCA" | "UCG" -> "Serine"
    | "UAU" | "UAC"                 -> "Tyrosine"
    | "UGU" | "UGC"                 -> "Cysteine"
    | "UGG"                         -> "Tryptophan"
    | "UAA" | "UAG" | "UGA" | ""    -> "STOP"
    | _ -> failwith "Invalid codon"

let notStop code = code <> "STOP"

// using higher order functions and pipelining
let proteins rna =
    Seq.chunkBySize 3 rna
    |> Seq.map System.String
    |> Seq.map convertToProtein
    |> Seq.takeWhile notStop
    |> Seq.toList
