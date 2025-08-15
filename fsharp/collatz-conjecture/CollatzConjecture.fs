module CollatzConjecture

// Some n is the answer, None is an error.

let steps (number: int): int option =

    let even n = n % 2 = 0

    let rec collaz n acc =
        if n = 1 then acc
        else
            let nextN =
                if even n then n / 2
                else 3 * n + 1

            collaz nextN (acc + 1)

    if number < 1 then  None  // Anything less than 1 is an error.
    else Some (collaz number 0)
