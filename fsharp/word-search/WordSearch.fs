module WordSearch

let directions = [(-1,-1);(0,-1);(1,-1);(1,0);(1,1);(0,1);(-1,1);(-1,0);]

let isInBounds (grid: string list) (x, y) =
    x >= 0 && y >= 0 && x < grid[0].Length && y < grid.Length

let rec move (grid: string list) (x, y) (dx, dy) chars =
    match chars with
    | [chr] when grid[y][x] = chr -> Some (x, y)
    | chr::tail when grid[y][x] = chr ->
        let next = (x + dx, y + dy)
        if isInBounds grid next then
            move grid next (dx, dy) tail
        else None
    | _ -> None


let searchGrid grid (x, y) (word:string) = 
    let chars = word |> Seq.toList

    let found =
        directions
        |> List.map (fun dir -> move grid (x, y) dir chars)
        |> List.choose id
    match found with
    | [(x2, y2)] -> Some (word, Some ((x + 1, y + 1), (x2 + 1, y2 + 1)))
    | _ -> None


let searchAll wordsToSearchFor grid (x, y) =
    wordsToSearchFor
    |> List.map (searchGrid grid (x, y))
    |> List.choose id

let search (grid: string list) wordsToSearchFor =

   let result =
        [0 .. grid.Length - 1]
        |> List.map (fun y ->
                                [0 .. grid[0].Length - 1]
                                |> List.map (fun x ->
                                    searchAll wordsToSearchFor grid (x, y)))

   let foundMap =
        result
        |> List.concat
        |> List.concat
        |> Map.ofList

   wordsToSearchFor
        |> List.fold (fun map word ->
            if Map.containsKey word map |> not then
                Map.add word None map
            else
                map) foundMap
