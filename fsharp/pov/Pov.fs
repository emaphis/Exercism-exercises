module Pov

// TODO: implement this module

type Graph<'a> = {
    value : 'a
    children : Graph<'a> list  // list of Graphs
}

let mkGraph (data: 'a) (chld: Graph<'a> list)  : Graph<'a> =
    { value = data; children = chld }

let fromPOV (data: 'a) (grph: Graph<'a>) : Graph<'a> option  =
    Some (mkGraph data [])

