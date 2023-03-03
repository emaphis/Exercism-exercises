module TracksOnTracksOnTracks

let newList: string list = []

let existingList: string list = ["F#"; "Clojure"; "Haskell"]

let addLanguage (language: string) (languages: string list): string list =
    language :: languages

let rec countLanguages (languages: string list): int =
    let rec loop list acc =
        match list with
        | []  -> acc
        | _::xs -> loop xs (acc + 1)
    loop languages 0

let rec reverseList(languages: string list): string list =
    let rec loop1 list acc =
        match list with
        | []  -> acc
        | x::xs -> loop1 xs (x :: acc)
    loop1 (languages: string list) newList
    

let excitingList (languages: string list): bool =
    match languages with
    | "F#" :: _     -> true
    | [ _; "F#" ]   -> true
    | [ _; "F#"; _] -> true
    | _  -> false
