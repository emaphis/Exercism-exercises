// High Scores Worksheet.

// Assume list of scores is ordered by time of entry.

/// List all of the scores
let scores (values: int list): int list = values

scores [30; 50; 20; 70] = [30; 50; 20; 70]


let latest (values: int list): int = List.last values
  //  List.rev values
  //  |> List.head

latest [100; 0; 90; 30] = 30


let personalBest (values: int list): int = List.max values
   // values
   // |> List.sort
   // |> latest

personalBest [40; 100; 70] = 100


let personalTopThree (values: int list): int list =
    let values = List.sortDescending values
    if values.Length < 3 then values
    else List.take 3 values


personalTopThree [10; 30; 90; 30; 100; 20; 10; 0; 30; 40; 40; 70; 70] = [100; 90; 70]
personalTopThree [20; 10; 30] = [30; 20; 10]

