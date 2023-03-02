module BinarySearch

let find input value =
    
    let rec loop (array: int array) value low high =
        if low > high then None
        else
            let pivot = (low + high) / 2
            let item = array[pivot]
            
            match item with
            | elem when value = elem ->
                Some pivot
            | elem when value > elem ->
                loop array value (pivot + 1) high
            | elem when value < elem ->
                loop array value low (pivot - 1)
            | _ ->
                None
               
    
    if (input: int array).Length = 0 then None
    else
       loop input value 0 (input.Length - 1)
