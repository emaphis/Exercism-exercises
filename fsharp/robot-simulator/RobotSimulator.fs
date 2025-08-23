module RobotSimulator

type Direction = North | East | South | West
type Position = int * int

/// A Robot is a Direction and a Positon
type Robot =
    { direction: Direction
      position: Position }


/// Turn Robots's direction Right
let robotRight robot =
    match robot.direction with
    | North -> { robot with direction = East  }
    | East  -> { robot with direction = South }
    | South -> { robot with direction = West  }
    | West  -> { robot with direction = North }


/// Turn Robots's dirction Left
let robotLeft robot =
    match robot.direction with
    | North -> { robot with direction = West  }
    | East  -> { robot with direction = North }
    | South -> { robot with direction = East  }
    | West  -> { robot with direction = South }


/// Advance Robot 1 postion
let robotAdvance robot =
    let (x, y) = robot.position
    match robot.direction with
    | North -> { robot with position = (x, y + 1) }
    | East  -> { robot with position = (x + 1, y) }
    | South -> { robot with position = (x, y - 1) }
    | West  -> { robot with position = (x - 1, y) }


// R' is Right | 'L' is Left | 'A' is Advance

/// Move Robot given instruction represented as a char
let processInstruction robot instruction =
    match instruction with
    | 'R' -> robotRight robot
    | 'L' -> robotLeft robot
    | 'A' -> robotAdvance robot
    | _  -> failwith "Opps - Invalid instruction"


/// Create a Robot with direction and position
let create direction position = { direction = direction; position = position}


/// Move a Robot given as a sequence of instructions passed as a string.
let move instructions robot =
    let instructionList = (instructions: string).ToCharArray() |> Array.toList
    List.fold processInstruction robot instructionList
