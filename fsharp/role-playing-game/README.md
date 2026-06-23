# Role Playing Game

Welcome to Role Playing Game on Exercism's F# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.
If you get stuck on the exercise, check out `HINTS.md`, but try and solve it without using those first :)

## Introduction

The `Option` type is the F# language mechanism for dealing with values that may or may not exist.
It provides a type-safe alternative to the use of `null`, which is common in other languages for dealing with such values.
It is used in many standard F# library functions, so understanding it is essential for effective use of the standard F# library.

## Usage 

The `Option` type is a generic type (having an underlying type).  
`Option` values are either `Some value`, representing some specific value, or `None`, representing no value.

The following function demonstrates how to create an `Option` value:

```fsharp
let keepIfPositive (a: int) : int option = if a > 0 then Some a else None
```

~~~~exercism/note
`T option` is the postfix syntax equivalent for `Option<T>`; the two syntax forms can be used interchangeably.
However, according to the F# Style Guide, the postfix notation is preferred for Option types (see [F# Style Guide section on Formatting Types and Type Annotations](https://learn.microsoft.com/en-us/dotnet/fsharp/style-guide/formatting#for-types-prefer-prefix-syntax-for-generics-foot-with-some-specific-exceptions)). 
~~~~

## Reading the content of an Option value

The idiomatic way to read an `Option` value is via pattern matching, as shown in the following example:

```fsharp
// Returns "Hello, <name>!" if the name is provided; otherwise returns "Hello, you!"
let sayHello (optionalName: string option): string = 
    match optionalName with
    | Some name -> "Hello, " + name + "!"
    | None -> "Hello, you!"

sayHello (Some "Matthieu")
// --> "Hello, Matthieu!"

sayHello None
// --> "Hello, you!"
```

## Unwrapping Options with default values

`Option`s can be "unwrapped" (converted to their contained type) by providing default values with the `Option.defaultValue` function. 
This is particularly useful when you want to ensure that the value is not `None`.
For example:

```fsharp
Option.defaultValue "" (Some "F#")
// --> "F#"

Option.defaultValue 0 None
// --> 0
```

## Instructions

In this exercise, you'll be implementing mechanics of a role-playing game.
A player's character is represented by the following type:

```fsharp
type Player = {
    Name: string option
    Level: int
    Health: int
    Mana: int option
}
```

Players in this game must reach level 10 before they unlock a mana pool so that they can start casting spells.
You'll be working on two pieces of functionality in this game: the revive mechanic and the spell casting mechanic.

## 1. Introduce yourself

Write the content of the `introduce` function.
Note that the `Name` field of the `Player` record is an `Option`.
Stealthy players might want to hide their name by leaving it set to `None` -- such players will be introduced as `"Mighty Magician"`.
Otherwise, just use your name to introduce yourself.

```fsharp
introduce { Name = None; Level = 2; Health = 8; Mana = None }
    --> "Mighty Magician"

introduce { Name = Some "Merlin"; Level = 2; Health = 8; Mana = None }
    --> "Merlin"
```

## 2. Implement the revive mechanic

The `revive` function should check that the player's character is indeed dead (their health has reached 0).
If they are, it should return a new `Player` instance with 100 health.
Otherwise, if the player's character isn't dead, the `revive` function returns `None`.

If the player's level is 10 or above, they should also be revived with 100 mana.
If the player's level is below 10, their mana should be `None`.
The `revive` function should preserve the player's level.

```fsharp
let deadPlayer = { Name = None; Level = 2; Health = 0; Mana = None }

revive deadPlayer
    --> Some { Name = None; Level = 2; Health = 100; Mana = None }
```

If the `revive` method is called on a player whose health is 1 or above, then the function should return `None`.

```fsharp
let alivePlayer = { Name = None; Level = 2; Health = 42; Mana = None }

revive alivePlayer
    --> None
```

## 3. Implement the spell casting mechanic

The `castSpell` function takes as arguments an `int` indicating how much mana the spell costs as well as a `Player`.
It returns the updated player, as well as the amount of damage that the cast spell inflicts.
A successful spell cast does damage equal to two times the mana cost of the spell.
However, if the player has insufficient mana, nothing happens, the player is unchanged and no damage is done.
If the player does not even have a mana pool, attempting to cast the spell must decrease their health by the mana cost of the spell and does no damage.

```fsharp
let wizard = { Name = None; Level = 18; Health = 123; Mana = Some 30 }

let updatedWizard, damage = castSpell 14 wizard

updatedWizard.Mana --> Some 16
damage             --> 28
```

## Source

### Created by

- @blackk-foxx

### Contributed to by

- @mpizenberg
- @ceddlyburge