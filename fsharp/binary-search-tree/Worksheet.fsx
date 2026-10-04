// Binary search tree.

/// Self-referential binary tree definition
type Node =
    { Data  : int
      Left  : Node option
      Right : Node option }

let left node : Node option = node.Left

let right node : Node option = node.Right

let data node = node.Data

/// Insert data item into tree
let rec insert (nd: Node) (data: int): Node =
    let node (currentNode: Node option) (value: int): Node =
        match currentNode with
        | Some n -> insert n value
        | None -> { Data = value; Left = None; Right = None }

    if data <= nd.Data then
        { nd with Left = Some (node nd.Left data) }
      else
        { nd with Right = Some (node nd.Right data) }

/// Walk the items list inserting each item into the tree
let create items =
    items
    |> List.tail
    |> List.fold insert { Data = List.head items; Left = None; Right = None}



let treeData = create [4]
treeData |> data = 4
treeData |> left = None
treeData |> right = None

let treeData2 = create [4; 2]
treeData2 |> data = 4
treeData2 |> left |> Option.map data = (Some 2)
treeData2 |> left |> Option.bind left = None
treeData2 |> left |> Option.bind right = None
treeData2 |> right = None

let treeData3 = create [4; 4]
treeData3 |> data = 4
treeData3 |> left |> Option.map data = (Some 4)
treeData3 |> left |> Option.bind left = None
treeData3 |> left |> Option.bind right = None
treeData3 |> right = None

