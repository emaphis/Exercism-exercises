module Allergies

open System

/// An flag enum:
/// Representation of Allergies
[<Flags>]
type Allergen =
   | Eggs = 1
   | Peanuts = 2
   | Shellfish = 4
   | Strawberries = 8
   | Tomatoes = 16
   | Chocolate = 32
   | Pollen = 64
   | Cats = 128

let allergicTo codedAllergies (allergen: Allergen) =
    codedAllergies &&& int allergen <> 0

let list codedAllergies =
    Enum.GetValues(typeof<Allergen>)
    |> Seq.cast<Allergen>
    |> Seq.filter (allergicTo codedAllergies)
    |> List.ofSeq
