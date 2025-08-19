module SqueakyClean

open System

let transform (c: char) : string =
    if c = '-' then  "_"
    elif Char.IsWhiteSpace c then ""
    elif Char.IsUpper c then $"-{Char.ToLower(c)}"   // Camel to Kebab -  'C' -> '-c'
    elif Char.IsNumber c then ""
    elif c >= 'α' && c <= 'ω'  then "?"
    else string c 
    

let clean (identifier: string): string =
   String.collect transform identifier
