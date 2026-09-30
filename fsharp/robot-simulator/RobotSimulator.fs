module RobotSimulator

type Direction = North | East | South | West
type Position = int * int


/// Turn Robots's direction Right
let turnRight (direction, position) =
    match direction with
    | North -> East, position
    | East  -> South, position
    | South -> West, position
    | West  -> North, position


/// Turn Robots's direction Left
let turnLeft (direction, position) =
    match direction with
    | North -> West, position
    | East  -> North, position
    | South -> East, position
    | West  -> South, position


/// Advance Robot 1 position
let advance (direction, position) =
    let x, y = position
    match direction with
    | North -> direction, (x, y + 1)
    | East  -> direction, (x + 1, y)
    | South -> direction, (x, y - 1)
    | West  -> direction, (x - 1, y)

// Instructions for robot represented as chars:
// R' is Right | 'L' is Left | 'A' is Advance

/// Move Robot given an instruction passed as a char
let processInstruction (direction, position) instruction =
    match instruction with
    | 'R' -> turnRight (direction, position)
    | 'L' -> turnLeft (direction, position)
    | 'A' -> advance (direction, position)
    | _  -> failwith "Oops - Invalid instruction"


/// Create a Robot with direction and position
let create direction position = direction, position

/// Move a Robot given a sequence of instructions passed as a string.
let move instructions robot =
    Seq.fold processInstruction robot instructions
