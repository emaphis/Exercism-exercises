module ValentinesDay

type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Korean
    | Turkish

type Genre =
    | Horror
    | Romance
    | Thriller
    | Crime

type Activity = 
    | Chill 
    | BoardGame
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity): Approval =
    match activity with
    | Chill -> No
    | BoardGame -> No
    | Movie genre ->
        match genre with
        | Horror -> No
        | Romance -> Yes
        | Thriller -> No
        | Crime -> No
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> Yes
        | Turkish -> Maybe
    | Walk km ->
        match km with
        | km when km < 3 -> Yes
        | km when km < 5 -> Maybe
        | _  -> No
