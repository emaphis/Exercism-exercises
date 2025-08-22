// Datetimes -- <https://exercism.org/tracks/fsharp/exercises/booking-up-for-beauty>

open System
open System.Data.Common

// A `DateTime` in F# is an immutable object that contains both date and time information
// DateTimes can be manipulated by using builtin properties and methods

let now1 = DateTime.Now
// val now1: DateTime = 8/21/2025 4:05:10 PM

let later1 = DateTime.Parse("8/21/2025 6:0:00 PM")
// val later1: DateTime = 8/21/2025 6:00:00 PM

let timeStr1 = later1.ToString()
// val timeStr1: string = "8/21/2025 6:00:00 PM"

let timeStr2 =  sprintf "%O" later1
// val timeStr2: string = "8/21/2025 6:00:00 PM"

// DataTimes can be compared with < >
