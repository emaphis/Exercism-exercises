// Binary search tree.

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

/// Insert data item into tree
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



let treeData = create [ 4 ]
treeData |> data = 4
treeData |> left = None
treeData |> right = None

let treeData2 = create [ 4; 2 ]
treeData2 |> data = 4
treeData2 |> left |> Option.map data = (Some 2)
treeData2 |> left |> Option.bind left = None
treeData2 |> left |> Option.bind right = None
treeData2 |> right = None

let treeData3 = create [ 4; 4 ]
treeData3 |> data = 4
treeData3 |> left |> Option.map data = (Some 4)
treeData3 |> left |> Option.bind left = None
treeData3 |> left |> Option.bind right = None
treeData3 |> right = None
