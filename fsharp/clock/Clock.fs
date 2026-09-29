module Clock

// Clock will be the minutes in one day

let minutesPerDay = 24 * 60

/// Normalize number of minutes to handle totals of more than 1 day and negative totals
/// <p> Basically minutes should be for only one day so excess minutes should be rolled over. </p>
/// <p> Clock math uses modular math for basic calculations. </p>
let normalize minutes =
    (minutes % minutesPerDay + minutesPerDay) % minutesPerDay

/// Create clock with normalized `hours` and `minutes`.
let create hours minutes =
    let total  = (hours * 60) + minutes
    normalize total

/// Add minutes to the passed 'clock` returning a new clock.
let add minutes clock =
     create 0 (clock + minutes)

/// Subtract minutes to the passed 'clock` returning a new clock.
let subtract minutes clock =
    create 0 (clock - minutes)

let display clock =
    let hours = clock / 60
    let seconds = clock % 60
    $"%02d{hours}:%02d{seconds}"
