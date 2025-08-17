// Records - <https://exercism.org/tracks/fsharp/exercises/bandwagoner>

// Define a record
type Address = {
    Street : string
    HouseNumber : int
}

// Create a record
let oldAddress =
    { Street = "Main Street"
      HouseNumber = 17 }


// Single-line alternative
type ConciseAddress = { Street: string; HouseNumber: int }

let conciseAddress: ConciseAddress = { Street = "Main Street"; HouseNumber = 17 }

// Records are immutable, to update you must create new with fields updated,
// use `with` as concise updater syntax.

let newAddress = { oldAddress with HouseNumber = 86 }

let hous1 = newAddress.Street
let nmbr1 = newAddress.HouseNumber


// Records have structural equality
// Records can be deconstructed in bindings using pattern matching

let myAddress : Address = { Street = "Broadway"; HouseNumber = 123 }

let { Address.Street = myStreet; HouseNumber = myHouseNumber } = myAddress
//val myStreet: string = "Broadway"
//val myHouseNumber: int = 123


match myAddress with
| { HouseNumber = 1 } -> printfn "First House"
| { HouseNumber = houseNumber; Street = street } ->
    printfn $"House number {houseNumber} on {street}"
// House number 123 on Broadway
