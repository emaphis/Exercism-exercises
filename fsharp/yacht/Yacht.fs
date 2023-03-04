module Yacht

type Category = 
    | Ones
    | Twos
    | Threes
    | Fours
    | Fives
    | Sixes
    | FullHouse
    | FourOfAKind
    | LittleStraight
    | BigStraight
    | Choice
    | Yacht

type Die =
    | One 
    | Two 
    | Three
    | Four 
    | Five 
    | Six

let dieValue (die: Die): int =
    match die with
    | One   -> 1
    | Two   -> 2
    | Three -> 3
    | Four  -> 4
    | Five  -> 5
    | Six   -> 6


/// List of Die type
type Dice = Die list

/// Record to hold the number of dice per face.
type DieGroup =
  { Die: Die
    Count: int }


/// Sum the faces of the dice.
let sumDice dice =
    dice |> (List.map dieValue) |> List.sum

/// Score by counting the faces of the selected dice
let scoreByDie die (dice: Dice): int =
    List.filter (fun d -> d = die) dice
    |> sumDice    

/// Count the number of per faces in a list of Die
///  Sort the list of counts by count
// factored out of several functions
let sumByFace dice = 
    List.countBy id dice
    |> List.sortByDescending snd
    |> List.map (fun (die, count) ->
                { Die = die; Count = count })

let fullHouseScore (dice: Dice) =
    let firstFace =
         (sumByFace dice) |> List.head
    if firstFace.Count = 3 then sumDice dice
    else 0    

let fourOfAKindScore (dice: Dice) =
    let firstFace =
         (sumByFace dice) |> List.head
    if firstFace.Count >= 4 then (dieValue firstFace.Die) * 4
    else 0
       
let straightScore die dice=
    let dieList =
        (sumByFace dice) |> List.map (fun d -> d.Die)
    if dieList.Length = 5 &&    // not a full house
        not (List.contains die dice) then 30
    else 0
        
let littleStraightScore = straightScore Die.Six

let bigStraightScore = straightScore Die.One


/// True (50) if all the dice faces are the same, if not (0).
let yachtScore (dice: Dice) =
    let list = (sumByFace dice)
    if list.Length = 1 then 50
    else 0 
    

let score (category: Category) (dice: Die list): int =
    match category with
    | Ones   -> scoreByDie Die.One dice 
    | Twos   -> scoreByDie Die.Two dice
    | Threes -> scoreByDie Die.Three dice
    | Fours  -> scoreByDie Die.Four dice
    | Fives  -> scoreByDie Die.Five dice
    | Sixes  -> scoreByDie Die.Six dice
    | FullHouse      ->  fullHouseScore dice
    | FourOfAKind    -> fourOfAKindScore dice
    | LittleStraight -> littleStraightScore dice
    | BigStraight    -> bigStraightScore dice
    | Choice  -> sumDice dice  // Choice just sums the dice
    | Yacht   -> yachtScore dice

