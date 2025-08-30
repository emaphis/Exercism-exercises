module HighScores

// Assume list of scores is ordered by time of entry.

/// List all of the scores
let scores (values: int list): int list = values

/// Return the last score
let latest (values: int list): int = List.last values

/// Return the top score
let personalBest (values: int list): int = List.max values

/// Return the top three scores
let personalTopThree (values: int list): int list =
    let values = List.sortDescending values
    if values.Length < 3 then values
    else List.take 3 values
