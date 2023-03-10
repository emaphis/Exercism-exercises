module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot =
  { direction: Direction
    position: Position }

let create direction position =
  { direction = direction;
    position = position }

let private turnLeft robot =
    let direction =
        match robot.direction with
        | North -> West
        | East  -> North
        | South -> East
        | West  -> South
    create direction robot.position

let private turnRight robot =
    let direction =
        match robot.direction with
        | North -> East
        | East  -> South
        | South -> West
        | West  -> North
    create direction robot.position

let private advance robot = 
    let (x, y) = robot.position
    let position =
        match robot.direction with
        | North -> (x, y+1)
        | East  -> (x+1, y)
        | South -> (x, y-1)
        | West  -> (x-1, y)
    create robot.direction position

/// Takes a robot and an instruction and "preforms"
/// instruction returning a new robot
///  - (A folder function)
let private perform robot instruction =
    match instruction with
    | 'L' -> turnLeft robot
    | 'R' -> turnRight robot
    | 'A' -> advance robot
    | _   -> failwith "Invalid instruction"


// Using recursion
let move instructions robot =

    let list = Seq.toList(instructions)
    
    let rec loop perform robot instList =
        match instList with
        | [] -> robot
        | inst :: rest ->
            loop perform (perform robot inst) rest
    
    loop perform robot list


// Using `fold`
let move' instructions robot =

    let list = Seq.toList(instructions)

    List.fold perform robot list
