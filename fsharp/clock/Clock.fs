module Clock

// A Clock is time in minutes

let minutesPerDay = 24 * 60

let normalize minutes = minutes % minutesPerDay

/// time in minutes rolled over to 1 day
let create hours minutes =
    let minutes = (hours * 60) + minutes
    let normalized = normalize minutes
    normalize (normalized + minutesPerDay)   // catch if `normalized` is negative
    
let add minutes clock = create 0 (clock + minutes)
   
let subtract minutes clock = create 0 (clock - minutes)
;;
let display clock = sprintf "%02d:%02d" (clock / 60) (clock % 60)
