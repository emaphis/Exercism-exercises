package techpalace

import "strings"

// WelcomeMessage returns a welcome message for the customer.
func WelcomeMessage(customer string) string {
	msg := "Welcome to the Tech Palace, " + strings.ToUpper(customer)
	return msg
}

// AddBorder adds a border to a welcome message.
func AddBorder(welcomeMsg string, numStarsPerLine int) string {
	border := strings.Repeat("*", numStarsPerLine)
	msg := "\n" + welcomeMsg + "\n"
	return border + msg + border
}

// CleanupMessage cleans up an old marketing message.
func CleanupMessage(oldMsg string) string {
	newMsg := strings.TrimSpace(strings.ReplaceAll(oldMsg, "*", ""))
	return newMsg
}
