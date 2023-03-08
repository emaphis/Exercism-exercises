module ProteinTranslation

let convertToProtein codon =
    match codon with
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

(*
// Tail recursive
let proteins rna =
    let rec loop (rna: string) (acc: string list) =
        let protein = convertToProtein rna[0..2]
        if notStop protein then
            loop rna[3..] (protein :: acc)
        else acc

    List.rev(loop rna [])
*)
