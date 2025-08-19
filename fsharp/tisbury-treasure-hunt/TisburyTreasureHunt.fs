module TisburyTreasureHunt


let getCoordinate (line: string * string): string =
    match line with _, coordinate -> coordinate
   
let convertCoordinate (coordinate: string): int * char =
   System.Int32.Parse(string coordinate[0]), coordinate[1]


let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let ararasCoord = convertCoordinate (getCoordinate azarasData)
    let ruisCoord =
        match ruisData with | _, coord, _ -> coord
    ararasCoord = ruisCoord

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    if compareRecords azarasData ruisData then
        match azarasData, ruisData with
         (treasure, coordinate), (location, _, quadrant) ->
            (coordinate, location, quadrant, treasure)
    else ("", "", "", "")
