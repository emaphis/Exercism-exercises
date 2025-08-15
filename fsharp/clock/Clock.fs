module Clock

// Clock will be the minutes in one day

let minutesPerDay = 24 * 60

/// Normalize number of minutes to handle totals of more than 1 day and negative totals <p>
/// Basically minutes should be for only one day so excess minutes should be rolled over.<p>
/// Clock math uses modular math for basic calculations
let normalize minutes =
    (minutes % minutesPerDay + minutesPerDay) % minutesPerDay

/// Create clock with
let create hours minutes =
    let total  = (hours * 60) + minutes
    normalize total

let add minutes clock =
    create 0 (clock + minutes)

let subtract minutes clock =
    create 0 (clock - minutes)

let display clock =  sprintf "%02d:%02d" (clock / 60) (clock % 60)