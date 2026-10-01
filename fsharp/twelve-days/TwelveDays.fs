module TwelveDays

// `days` `numbers` `gifts` are lists indexed by (day -1)
let days =
    [ "first"; "second"; "third"; "fourth"; "fifth"; "sixth"; "seventh"; "eighth"; "ninth"
      "tenth"; "eleventh"; "twelfth" ]

let numbers =
    [ "a"; "two"; "three"; "four"; "five"; "six"; "seven"; "eight"; "nine"; "ten"; "eleven"; "twelve"]

let gifts =
    [ "Partridge in a Pear Tree"
      "Turtle Doves, and "
      "French Hens, "
      "Calling Birds, "
      "Gold Rings, "
      "Geese-a-Laying, "
      "Swans-a-Swimming, "
      "Maids-a-Milking, "
      "Ladies Dancing, "
      "Lords-a-Leaping, "
      "Pipers Piping, "
      "Drummers Drumming, " ]

/// Returns the list of gifts one gift per day.
/// Counts down from passed day.
let stanza day =
    let giftString =
        [ day-1 .. -1 .. 0 ]    // count down.
        |> List.map (fun day -> numbers[day] + " " + gifts[day])
        |> List.reduce (fun acc next -> acc + next)

    $"On the {days[day-1]} day of Christmas my true love gave to me: {giftString}."


let recite start stop =
    [ start .. stop ]
    |> List.map stanza
