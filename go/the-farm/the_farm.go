package thefarm

import (
	"errors"
	"fmt"
)

// See types.go for the types defined for this exercise.

// TODO: Define the SillyNephewError type here.
type SillyNephewError struct {
	Cows int ``
}

// SillyNephewError should implement Error()
func (neph *SillyNephewError) Error() string {
	msg := fmt.Sprintf("silly nephew, there cannot be %d cows", neph.Cows)
	return msg
}

// DivideFood computes the fodder amount per cow for the given cows.
func DivideFood(weightFodder WeightFodder, cows int) (float64, error) {
	fodder, err := weightFodder.FodderAmount()

	if err != nil && err != ErrScaleMalfunction {
		return 0, err
	}

	if err == ErrScaleMalfunction {
		fodder *= 2
	}

	if fodder < 0 {
		return 0, errors.New("negative fodder")
	}

	if cows == 0 {
		return 0, errors.New("division by zero")
	}

	if cows < 0 {
		silly := SillyNephewError{Cows: cows}
		return 0, &silly
	}

	perCow := fodder / float64(cows)
	return perCow, nil

}
