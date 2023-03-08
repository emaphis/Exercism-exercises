module CollatzConjecture

let steps (number: int): int option = 
    let rec loop number acc =
        if number = 1 then acc
        elif number % 2 = 0 then
            loop (number / 2) (acc + 1)
        else
            loop (3 * number + 1) (acc + 1)

    if number < 1 then None 
    else Some (loop number 0)
