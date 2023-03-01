module CollatzConjecture

let steps (number: int): int option = 
    let rec loop number acc =
        if   number < 1 then None 
        elif number = 1 then Some acc
        elif number % 2 = 0 then
            loop (number / 2) (acc + 1)
        elif number % 2 = 1 then
            loop (3 * number + 1) (acc + 1)
        else None
    loop number 0
