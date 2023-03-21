package secret

/*
00001 = wink
00010 = double blink
00100 = close your eyes
01000 = jump
10000 = Reverse the order of the operations in the secret handshake.
*/
const (
	wink  = 0b00001
	blink = 0b00010
	close = 0b00100
	jump  = 0b01000
	revse = 0b10000
)

func Handshake(code uint) []string {
	moves := []string{}
	if (code & wink) > 0 {
		moves = append(moves, "wink")
	}

	if (code & blink) > 0 {
		moves = append(moves, "double blink")
	}

	if (code & close) > 0 {
		moves = append(moves, "close your eyes")
	}

	if (code & jump) > 0 {
		moves = append(moves, "jump")
	}

	if (code & revse) > 0 {
		moves = reverse(moves)
	}

	return moves
}

func reverse(strings []string) []string {
	for i, j := 0, len(strings)-1; i < j; i, j = i+1, j-1 {
		strings[i], strings[j] = strings[j], strings[i]
	}
	return strings
}
