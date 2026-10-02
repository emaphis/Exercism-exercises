// Binary search tree.

/// Self-referential binary tree definition
type Node =
    { data  : int
      left  : Node option
      right : Node option }

let left node  = node.left

let right node = node.right

let data node = node.data

/// Insert int item into tree
let rec insert (tree: Node option) (data: int) =
    match tree with
    | None -> Some { data = data; left = None; right = None }
    | Some node when data < node.data -> Some { data = data; left = insert node.left data; right = node.right }
   

let create items =
    items
    |> List.fold (fun acc data -> Some (insert acc data)) None
    |> Option.get // Remove option

let treeData = create [4]
treeData |> data = 4
treeData |> left = None
treeData |> right = None