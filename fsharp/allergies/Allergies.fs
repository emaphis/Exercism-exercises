module Allergies

open System

/// Representation of Allergies
type Allergen =
   | Eggs = 1
   | Peanuts = 2
   | Shellfish = 4
   | Strawberries = 8
   | Tomatoes = 16
   | Chocolate = 32
   | Pollen = 64
   | Cats = 128


let allergicTo (codedAllergies: int) (allergen: Allergen) =
    codedAllergies &&& int allergen <> 0


let list (codedAllergies: int) =
    Enum.GetValues(typeof<Allergen>)
    |> Seq.cast<Allergen>
    |> List.ofSeq   // I don't know why this has to be a list and not a seq
    |> List.filter (allergicTo codedAllergies)
