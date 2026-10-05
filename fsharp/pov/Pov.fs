module Pov

// TODO: implement this module

//type Graph<'a> = Node of value: 'a * children: Graph<'a> list

type Graph<'a> = {
    value : 'a
    children : Graph<'a> list  // list of Graphs
}

let mkGraph (data: 'a) (child: Graph<'a> list)  : Graph<'a> =
    { value = data; children = list }

let fromPOV (data: 'a) (graph: Graph<'a>) : Graph<'a> option  =
    Some (mkGraph data [])
