module Clock

// A Clock is time in minutes

let minutesPerDay = 24 * 60

/// Normalize number of minutes to handle totals of more than 1 day and negative totals
let normalize minutes =
    (minutes % minutesPerDay + minutesPerDay) % minutesPerDay

/// Create clock which is time in minutes rolled over to 1 day
let create hours minutes =
    let totalMinutes = (hours * 60) + minutes
    normalize totalMinutes
    
let add minutes clock = create 0 (clock + minutes)
   
let subtract minutes clock = create 0 (clock - minutes)

let display clock = sprintf "%02d:%02d" (clock / 60) (clock % 60)
