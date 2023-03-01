module Gigasecond

open System

let gigaSecond = 1000000000.0

let add (beginDate: DateTime) = beginDate.AddSeconds(gigaSecond)
