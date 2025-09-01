module Darts

let score (x: double) (y: double): int =
    let radius = sqrt (x*x + y*y)

    if   radius <= 1.0 then 10
    elif radius <= 5.0 then 5
    elif radius <= 10.0 then 1
    else 0
