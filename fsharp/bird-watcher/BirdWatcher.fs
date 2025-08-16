module BirdWatcher

open System.Linq

let lastWeek: int[] =
    [| 0; 2; 5; 3; 7; 8; 4 |]

// Yesterday is the 5th day
let yesterday(counts: int[]): int = counts[5]

let total(counts: int[]): int = counts.Sum()

let dayWithoutBirds(counts: int[]): bool =
    Array.contains 0 counts

let incrementTodaysCount(counts: int[]): int[] =
    let today = counts.Length - 1
    counts[today] <- counts[today] + 1
    counts

/// Every odd day has the same number of birds
let unusualWeek(counts: int[]): bool =
    match counts with
    | [| _; m; _; n; _; o; _ |] when m = n && n = o -> true
    | [| m; _; n; _; o; _; p |] when m = n && m = n && m = o && m = p -> true
    | _  -> false
