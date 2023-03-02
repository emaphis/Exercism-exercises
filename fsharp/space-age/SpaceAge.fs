module SpaceAge

open System

type Planet =
    | Mercury
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let getPeriod planet =
    match planet with
    | Mercury   -> 0.2408467
    | Venus     -> 0.61519726
    | Earth     -> 1.0
    | Mars      -> 1.8808158
    | Jupiter   -> 11.862615
    | Saturn    -> 29.447498
    | Uranus    -> 84.016846
    | Neptune   -> 164.79132

let secondsFactor = (365.25 * 24.0 * 60.0 * 60.0)

let age (planet: Planet) (seconds: int64): float =
    let period = getPeriod planet 
    let age = float seconds / (period * secondsFactor)
    Math.Round(age, 2)
 