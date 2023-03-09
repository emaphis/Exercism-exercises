package airportrobot

// Write your code here.
// This exercise does not have tests for each individual task.
// Try to solve all the tasks first before running the tests.

type Greeter interface {
	LanguageName() string
	Greet(Name string) string
}

func SayHello(name string, greeter Greeter) string {
	greeting := "I can speak " + greeter.LanguageName() + ": " + greeter.Greet(name)
	return greeting
}

type Italian struct{}

func (it Italian) LanguageName() string {
	return "Italian"
}

func (it Italian) Greet(name string) string {
	return "Ciao " + name + "!"
}

type Portuguese struct{}

func (port Portuguese) LanguageName() string {
	return "Portuguese"
}

func (port Portuguese) Greet(name string) string {
	return "Olá " + name + "!"
}
