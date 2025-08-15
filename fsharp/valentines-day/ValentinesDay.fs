module ValentinesDay


type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Korean
    | Turkish

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity): Approval =
    match activity with
    | BoardGame  -> No
    | Chill  -> No
    | Movie genre ->
        match genre with
        | Romance -> Yes
        | _  -> No
    | Restaurant cuis ->
        match cuis with
        | Korean -> Yes
        | Turkish -> Maybe
    | Walk dist ->
        match dist with
        | dist when dist < 3 -> Yes
        | dist when dist < 5 -> Maybe
        | _ -> No
