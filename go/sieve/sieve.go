package sieve

func Sieve(limit int) []int {
	// check only half the numbers
	found := make([]int, 0, (limit / 1))

	// found composites to ignore
	composites := make([]bool, (limit + 1))

	for i := 2; i <= limit; i++ {
		if !composites[i] {
			found = append(found, i)

			// Skip multiples which are composites
			for j := i * i; j <= limit; j += i {
				composites[j] = true
			}
		}
	}

	return found
}
