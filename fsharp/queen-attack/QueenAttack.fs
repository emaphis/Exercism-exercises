module QueenAttack

let create (position: int * int) =
    let r, c = position
    r > 0 && r < 8 && c > 0 && c < 8

let canAttack (queen1: int * int) (queen2: int * int) =
    let r1, c1 = queen1
    let r2, c2 = queen2
    if r1 = r2 || c1 = c2 then true   // rows, columns
    elif abs (r1 - r2) = abs (c1 - c2) then true  // diagonals.
    else false
