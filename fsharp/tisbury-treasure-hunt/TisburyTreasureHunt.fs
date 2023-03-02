module TisburyTreasureHunt

open System

let getCoordinate (line: string * string): string =
    match line with (_, coordinate) -> coordinate


let convertCoordinate (coordinate: string): int * char = 
    Int32.Parse(string coordinate[0]), coordinate[1]

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let azarasCoordinate = convertCoordinate (snd azarasData)
    let ruisCoordinate =
        match ruisData with (_, coord, _) -> coord
    azarasCoordinate = ruisCoordinate

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    if compareRecords azarasData ruisData then
        match azarasData, ruisData with
         (treasure, coordinate), (location, _, quadrant) ->
            (coordinate, location, quadrant, treasure)
    else
        ("", "", "", "")
         