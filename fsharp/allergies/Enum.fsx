// Enum - Allergies

//  F#, an enum (short for enumeration) is a distinct type that consists of a set of named constants called members.
// Enums are useful for representing a fixed set of related values in a readable and maintainable way.

// Define an enum using the type keyword followed by the = operator and the list of named constants.

/// An enum
type DaysOfWeek =
    | Sunday = 0
    | Monday = 1
    | Tuesday = 2
    | Wednesday = 3
    | Thursday = 4
    | Friday = 5
    | Saturday = 6


// Using an Enum

let today = DaysOfWeek.Friday
printfn "Today is: %A" today
// Today is: Friday


// Convert an enum to its underlying integer value and vice versa:

let dayAsInt = int DaysOfWeek.Monday
// val dayAsInt: int = 1

let dayFromInt = enum<DaysOfWeek> 3
// val dayFromInt: DaysOfWeek = Wednesday


// F# does not provide built-in support for iterating over enum values, but you can use reflection to achieve this:

let allDays =
    System.Enum.GetValues(typeof<DaysOfWeek>)
    |> Seq.cast<DaysOfWeek>

for day in allDays do
    printfn "%A" day
// Sunday
// Monday
// Tuesday
// Wednesday
// Thursday
// Friday
// Saturday


// Enum parsiong

let success, parsedDay = System.Enum.TryParse<DaysOfWeek>("Monday")
// val success: bool = true
// val parsedDay: DaysOfWeek = Monday

let seasonString =
    if success then parsedDay.ToString()
    else "None"
// val seasonString: string = "Monday"


// F# supports bit flag enums using the [<Flags>] attribute.

open System

[<Flags>]
type Permissions =
    | None = 0
    | Read = 1
    | Write = 2
    | Execute = 4
    | All = 7

let userPermissions = Permissions.Read ||| Permissions.Write
// val userPermissions: Permissions = Read, Write

let read = userPermissions &&& Permissions.Read
// val read: Permissions = Read
let write = userPermissions &&& Permissions.Write
// val write: Permissions = Write
let execute = userPermissions &&& Permissions.Execute
// val execute: Permissions = None
