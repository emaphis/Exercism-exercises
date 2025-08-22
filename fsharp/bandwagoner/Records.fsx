// Records - Bandwagoner

// A record is a collection of fields (which can be of different types) that belong together.
// `type` is used to define records

// Define a record
type Address = {
    Street : string
    HouseNumber : int
}

// Create a record
let oldAddress =
    { Street = "Main Street"
      HouseNumber = 17 }
    
let str1 = oldAddress.Street
// val str1: string = "Main Street"

let int1 = oldAddress.HouseNumber
//val int1: int = 17


// Single-line alternative
type ConciseAddress = { Street: string; HouseNumber: int }

let conciseAddress: ConciseAddress = { Street = "Main Street"; HouseNumber = 17 }


// Records are immutable, to update you must create new with fields updated,
// use `with` as concise updater syntax.

let newAddress = { oldAddress with HouseNumber = 86 }

let hous1 = newAddress.Street
let nmbr1 = newAddress.HouseNumber


// If a record's field names are unique, type annotations are optional as the compiler will be able to infer the
// type automatically.
// If the combination of a field names is not unique, you can help the compiler choose the correct record by either
// using an explicit type

type Boat = { Weight: int; Length: int }
type Car = { Weight: int; Length: int }

// Let compiler infer type
let typeEqualsLastMatch = { Weight = 5000; Length = 15 }
//val typeEqualsLastMatch: Car = { Weight = 5000 Length = 15 }

// Use type annotation on bind to force Boat.
let typeAnnotation: Boat = { Weight = 5000; Length = 15 }
//val typeAnnotation: Boat = { Weight = 5000; Length = 15 }

// Use fully qualified name for field to force type to Boat
let fullyQualifiedField = { Boat.Weight = 5000; Length = 15}
//val fullyQualifiedField: Boat = { Weight = 5000; Length = 15 }


// Records have structural equality - two instances of the same record with identical values are equivalent:

let address1 = { Street = "Main Street"; HouseNumber = 17 }
let address2 = { Street = "Main Street"; HouseNumber = 17 }
let address3 = { Street = "Broadway"; HouseNumber = 17 }

address1 = address2  // true
address1 = address3  // true




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
