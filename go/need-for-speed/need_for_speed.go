package speed

type Car struct {
	speed        int
	battery      int
	batteryDrain int
	distance     int
}

// NewCar creates a new remote controlled car with full battery and given specifications.
func NewCar(speed int, batteryDrain int) Car {
	return Car{
		speed:        speed,
		battery:      100,
		batteryDrain: batteryDrain,
		distance:     0,
	}
}

type Track struct {
	distance int
}

// NewTrack creates a new track
func NewTrack(distance int) Track {
	return Track{
		distance: distance,
	}
}

// Drive drives the car one time. If there is not enough battery to drive one more time,
// the car will not move.
func Drive(car Car) Car {
	if car.battery == 0 || car.battery-car.batteryDrain < 0 {
		return car // do nothing
	}
	car.battery = car.battery - car.batteryDrain
	car.distance = car.distance + car.speed
	return car
}

// CanFinish checks if a car is able to finish a certain track.
func CanFinish(car Car, track Track) bool {
	var numDrives = car.battery / car.batteryDrain
	var carDistance = numDrives * car.speed
	if carDistance >= track.distance {
		return true
	} else {
		return false
	}
}
