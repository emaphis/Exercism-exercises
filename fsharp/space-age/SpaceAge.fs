module SpaceAge

/// Represents a Planet in the Solar System
type Planet =
    | Mercury
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

/// Given a Planet produce the length of the Planet's year in terms of seconds.
let planetsYearInSeconds planet =
    let secondsPerEarthYear = 31_557_600.0

    let planetYearsInEarthYears =
        match planet with
        | Mercury -> 0.2408467
        | Venus   -> 0.61519726
        | Earth   -> 1.0
        | Mars    -> 1.8808158
        | Jupiter -> 11.862615
        | Saturn  -> 29.447498
        | Uranus  -> 84.016846
        | Neptune -> 164.79132

    planetYearsInEarthYears * secondsPerEarthYear

/// Return a person's age in planetary years given a planet and a persons age in seconds
let age (planet: Planet) (seconds: int64): float = 
    (float seconds) / (planetsYearInSeconds planet)
