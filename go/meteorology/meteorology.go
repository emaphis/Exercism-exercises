package meteorology

import "fmt"

type TemperatureUnit int

const (
	Celsius    TemperatureUnit = 0
	Fahrenheit TemperatureUnit = 1
)

// Add a String method to the TemperatureUnit type
func (tu TemperatureUnit) String() string {
	labels := []string{"°C", "°F"}
	return labels[tu]
}

type Temperature struct {
	degree int
	unit   TemperatureUnit
}

// Add a String method to the Temperature type
func (tmp Temperature) String() string {
	return fmt.Sprintf("%d %s", tmp.degree, tmp.unit)
}

type SpeedUnit int

const (
	KmPerHour    SpeedUnit = 0
	MilesPerHour SpeedUnit = 1
)

// Add a String method to SpeedUnit
func (spu SpeedUnit) String() string {
	labels := []string{"km/h", "mph"}
	return labels[spu]
}

type Speed struct {
	magnitude int
	unit      SpeedUnit
}

// Add a String method to Speed
func (spd Speed) String() string {
	return fmt.Sprintf("%d %s", spd.magnitude, spd.unit)
}

type MeteorologyData struct {
	location      string
	temperature   Temperature
	windDirection string
	windSpeed     Speed
	humidity      int
}

// Add a String method to MeteorologyData
func (md MeteorologyData) String() string {
	str := fmt.Sprintf("%v: %v, Wind %v at %v, %v%% Humidity",
		md.location, md.temperature, md.windDirection, md.windSpeed, md.humidity)
	return str
}
