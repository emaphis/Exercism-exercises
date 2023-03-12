package pangram

import "strings"

//package main

var alphabet = "abcdefghijklmnopqrstuvwxyz"

func IsPangram(input string) bool {
	set := map[rune]bool{}
	input = strings.ToLower(input)

	for _, rune := range input {
		set[rune] = true
	}

	// Compare input set to alphabet
	for _, rune := range alphabet {
		if _, exists := set[rune]; !exists {
			return false
		}
	}

	return true
}
