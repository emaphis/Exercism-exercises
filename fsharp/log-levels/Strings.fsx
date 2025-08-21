// Strings - <https://exercism.org/tracks/fsharp/exercises/log-levels>

// Strings are immutable object representing text as a sequence of Unicode characters.
// Double quotes define a string instance

let fruit = "Apple"
//val fruit: string = "Apple"

// Some special characters need escaping.

let escaped = "c:\\test.txt"
//val escaped: string = "c:\test.txt"

let verbatim = @"c:\test.txt"
// val verbatim: string = "c:\test.txt"


// Triple allows using a double quote in the string without escaping it.

let tripledQuoted = """<movie title />"""
// val tripledQuoted: string = "<movie title />"
