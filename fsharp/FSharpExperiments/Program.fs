open Datastructures
open Datastructures.Stack1

let x =
    StackNode(1,
        StackNode(2,
            StackNode(3, EmptyStack)))

let y = StackOps1.getRange 5 10


printfn "%A" x
printfn "%A" y
