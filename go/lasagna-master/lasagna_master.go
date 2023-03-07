package lasagna

// TODO: define the 'PreparationTime()' function
func PreparationTime(layers []string, averageTime int) int {
	if averageTime == 0 {
		averageTime = 2
	}
	return len(layers) * averageTime
}

// TODO: define the 'Quantities()' function
func Quantities(layers []string) (int, float64) {
	noodles := 0
	sauce := 0.0
	for i := 0; i < len(layers); i++ {
		if layers[i] == "noodles" {
			noodles += 50
		} else if layers[i] == "sauce" {
			sauce += 0.2
		}
	}
	return noodles, sauce
}

// TODO: define the 'AddSecretIngredient()' function
func AddSecretIngredient(friendsList []string, myList []string) {
	secret := friendsList[len(friendsList)-1]
	myList[len(friendsList)] = secret
}

// TODO: define the 'ScaleRecipe()' function
func ScaleRecipe(amounts []float64, portions int) []float64 {
	var output []float64
	scale := float64(portions) / 2
	for i := 0; i < len(amounts); i++ {
		output = append(output, amounts[i]*scale)
	}
	return output
}
