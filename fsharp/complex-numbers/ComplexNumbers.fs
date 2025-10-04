module ComplexNumbers

open System

type Complex = { real : float; imaginary : float }

let create real imaginary = { real = real; imaginary = imaginary }

let real z :  float = z.real

let imaginary z:  float = z.imaginary

let mul z1 z2 = 
    let a = real z1
    let b = imaginary z1
    let c = real z2
    let d = imaginary z2
    { real = a * c - b * d;
      imaginary = b * c + a * d }


let add z1 z2 =
    let a = real z1
    let b = imaginary z1
    let c = real z2
    let d = imaginary z2
    { real = a + c; imaginary = b + d }

let sub z1 z2 =
    let a = real z1
    let b = imaginary z1
    let c = real z2
    let d = imaginary z2
    { real = a - c; imaginary = b - d }

let div z1 z2 =
    let a = real z1
    let b = imaginary z1
    let c = real z2
    let d = imaginary z2
    { real = (a * c + b * d) / (Math.Pow(c, 2.0) + Math.Pow(d, 2.0))
      imaginary = (b * c - a * d) / (Math.Pow(c, 2.0) + Math.Pow(d, 2.0)) }

let abs z =
    let a = real z
    let b = imaginary z
    Math.Sqrt(a * a + b * b)

let conjugate z =
    { z with imaginary = -z.imaginary }
    
let exp z =
    let a = real z
    let b = imaginary z
    { real = Math.Cos(b) * Math.Exp(a)
      imaginary = Math.Sin(b) * Math.Exp(a) }