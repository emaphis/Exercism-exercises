module BinarySearchTree

// Recursive binary tree definition
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
    | None ->  { data = data; left = None; right = None }
    | Some tr when data <= tr.data -> { tr with left = Some (insert tr.left data) }
    | Some tr -> { tr with right = Some (insert tr.right data) }

/// Cree tree from int list
let create (items: int list) =
    items
    |> List.fold (fun acc data -> Some (insert acc data)) None
    |> Option.get // Remove option

/// Tree traversal.
let sortedData node =
    let rec sorted node =
        match node with
        | None -> []
        | Some nd -> sorted nd.left @ [nd.data] @ sorted nd.right

    sorted (Some node)
