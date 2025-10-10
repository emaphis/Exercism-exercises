module CustomSet


type Set<'T when 'T : comparison> = { values : 'T list }


/// Create an empty set.
let empty<'T when 'T : comparison> : Set<'T> = { values = [] }

/// Creates a Set with one item: value. 
let singleton value = { values = [value] }

/// Returns 'true' is set is empty. 
let isEmpty set = set.values.IsEmpty

let size set = set.values.Length

let fromList list =
    let aList =
        list |> List.sort |> List.distinct
    { values = aList }

/// Returns a new list containing the elements of the set.
let toList set = set.values

let contains value set =
    List.contains value set.values

/// Returns a new set with the element added if it doesn't already exist.
let insert value set = 
    if contains value set then set
    else 
        value :: set.values
        |> List.sort
        |> fromList

/// Calculates the union of two sets.
let union left right =
    let combinedList = left.values @ right.values
    combinedList |> fromList
    

/// Calculates the intersection of two sets.
let intersection left right =
    let intersectList =
        List.filter (fun value -> contains value right) left.values
    intersectList |> fromList

/// Calculates the difference of two sets (s1 - s2).
let difference left right =
    let diffList =
        List.filter (fun value -> not (contains value right)) left.values
    diffList |> fromList

let isEqualTo left right =
    (size left = size right) && (isEmpty (difference left right))

let isSubsetOf left right =
    List.forall (fun value -> contains value right) left.values

let isDisjointFrom left right =
   not (List.exists (fun value -> contains value right) left.values)