// Package weather is a weather forcasting package that keeps tack of current conditions at the current location.
package weather

// CurrentCondition...
var CurrentCondition string

// CurrentLocation...
var CurrentLocation string

// Forecast provides the forcast of a location given the curren location and current conditions.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
