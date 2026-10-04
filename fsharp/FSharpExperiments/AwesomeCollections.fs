namespace AwesomeCollections

// --- 1. PURELY FUNCTIONAL STACK ---
type 'a stack =
    | EmptyStack
    | StackNode of 'a * 'a stack


/// Stack 1 example
module Stack = begin

    let hd = function
        | EmptyStack -> failwith "Empty stack"
        | StackNode(hd, tl) -> hd
    
    let tl = function
        | EmptyStack -> failwith "Empty stack"
        | StackNode(hd, tl) -> tl
    
    let cons hd tl = StackNode(hd, tl)

    let empty = EmptyStack

    let rec update index value s =
        match index, s with
        | index, EmptyStack  -> failwith "Index out of range."
        | 0, StackNode(hd, tl) -> StackNode(value, tl)
        | n, StackNode(hd, tl) -> StackNode(hd, update (index - 1) value tl)

    let rec append x y =
        match x with
        | EmptyStack -> y
        | StackNode(hd, tl) -> StackNode(hd, append tl y)

    let rec map f = function
        | EmptyStack -> EmptyStack
        | StackNode(hd, tl) -> StackNode(f hd, map f tl)

    let rec rev s =
        let rec loop acc = function
            | EmptyStack -> acc
            | StackNode(hd, tl) -> loop (StackNode(hd, acc)) tl
        loop EmptyStack s
end

// --- 2. PURELY FUNCTIONAL QUEUE ---
[<Class>]
type 'a Queue(item : 'a stack) =
    member this.hd with get() = Stack.hd (Stack.rev item)
    member this.tl with get() = Queue(item |> Stack.rev |> Stack.tl |> Stack.rev)
    member this.enqueue(x: 'a) = Queue(Stack.cons x item)
    static member empty = Queue(Stack.empty)

// --- 3. BINARY HEAP ---
type 'a heap =
    | EmptyHeap
    | HeapNode of 'a * 'a heap * 'a heap


module BinaryHeap =
    let rec insert (comp: 'a -> 'a -> int) item h =
        match h with
        | EmptyHeap -> HeapNode(item, EmptyHeap, EmptyHeap)
        | HeapNode(v, left, right) ->
            if comp item v < 0 then
                HeapNode(item, insert comp v right, left)
            else
                HeapNode(v, insert comp item right, left)

