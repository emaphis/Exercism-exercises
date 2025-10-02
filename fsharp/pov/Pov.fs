module Pov

// TODO: implement this module

type Graph<'a> = {
    value : 'a
    children : Graph<'a> list  // list of Graphs
}

let mkGraph data list = { value = data; children = list }

