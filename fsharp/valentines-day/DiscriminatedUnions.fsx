// Discrimated Unions  - Valentines Day

// The discriminated union type represents a fixed number of named cases.
// Each value of a discriminated union corresponds to exactly one of the named cases.

// A discriminated union is defined using the type keyword.

// Discriminated union without associated data
type Season =
    | Spring
    | Summer
    | Autumn
    | Winter

// Discriminated union with associated data
type Number =
    | Integer of int
    | Float of float
    | Invalid


// Creating a value for a specific case can be done by referring to its name
// As case names are just constructor functions, associated data can be passed as a regular function argument. 

let byName = Integer 2
// val byName: Number = Integer 2

let byFullName = Number.Invalid
// val byFullName: Number = Invalid

// Discriminated unions have structural equality,


// The preferred way to work with discriminated unions is through pattern matching using the identifier pattern:

let describe number =
    match number with
    | Integer i -> $"Integer: {i}"
    | Float d -> $"Float : {d}"
    | Invalid -> "Invalid"

let str1 = describe byName
// val str1: string = "Integer: 2"

let str2 = describe byFullName
// val str1: string = "Integer: 2"

let str3 = describe (Float 3.33)
// val str3: string = "Float : 3.33"
