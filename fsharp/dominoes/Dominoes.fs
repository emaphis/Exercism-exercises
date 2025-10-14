module Dominoes

type Domino = int * int

let flip (domino: Domino) = (snd domino, fst domino)

let isFirstEqLast (dominos: Domino list) =
    (List.head dominos |> fst) = (List.last dominos |> snd)

let rec canChain (input: Domino list) =
    match input with
    | [] -> true
    | [d] when d = flip d -> true
    | d::ds 
    | _ -> false