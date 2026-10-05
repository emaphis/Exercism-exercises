module BinarySearchTree

/// Self-referential binary tree definition
type Node =
    {
        Data: int
        Left: Node option
        Right: Node option
    }

let left node : Node option = node.Left

let right node : Node option = node.Right

let data node = node.Data


// Insert data item into tree
let rec insert newValue node =
    if newValue <= node.Data then
        match node.Left with
        | None ->
            { node with
                Left =
                    Some
                        {
                            Data = newValue
                            Left = None
                            Right = None
                        }
            }
        | Some child ->
            { node with
                Left = Some(insert newValue child)
            }
    else
        match node.Right with
        | None ->
            { node with
                Right =
                    Some
                        {
                            Data = newValue
                            Left = None
                            Right = None
                        }
            }
        | Some child ->
            { node with
                Right = Some(insert newValue child)
            }

/// Walk the items list inserting each item into the tree
let create items =
    match items with
    | [] -> failwith "Cannot create an empty tree"
    | head :: tail ->
        let initialRoot =
            {
                Data = head
                Left = None
                Right = None
            }

        tail |> List.fold (fun acc value -> insert value acc) initialRoot

let rec sortedData node =
    let sorted (branch: Node option) : int list =
        match branch with
        | Some n -> sortedData n
        | None -> []

    sorted node.Left @ [ node.Data ] @ sorted node.Right
