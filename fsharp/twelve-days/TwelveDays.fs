module TwelveDays

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


let stanza day =
    let giftStr =
        [ day-1 .. -1 .. 0 ]    // count down.
        |> List.map (fun dy -> numbers[dy] + " " + gifts[dy])
        |> List.reduce (fun acc nxt -> acc + nxt)

    $"On the {days[day-1]} day of Christmas my true love gave to me: {giftStr}."


let recite start stop =
    [ start .. stop ]
    |> List.map stanza

;;;
