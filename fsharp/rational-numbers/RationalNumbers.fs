module RationalNumbers

open System

type Rational = { Num: int; Den: int }

let rec private gcd (m, n) =
    if m = 0 then n
    else gcd (n % m, m)

let create numerator denominator =
    { Num = numerator; Den = denominator }

/// Normalize the passed Rational Number
/// Cancels common divisors so reduces any fraction with a non-zero denominator to
/// the normal form.
let reduce r =
    let { Num = p; Den = q } = r
    let sign = if p*q < 0 then -1 else 1
    let ap = abs p
    let aq = abs q
    let d = gcd(ap, aq)
    create (sign * (ap / d))  (aq / d)

let add r1 r2 =
   let { Num = n1; Den = d1 } = r1
   let { Num = n2; Den = d2 } = r2
   create (n1*d2 + n2*d1) (d1*d2)
   |> reduce

let sub r1 r2 =
   let { Num = n1; Den = d1 } = r1
   let { Num = n2; Den = d2 } = r2
   create (n1*d2 - n2*d1) (d1*d2)
   |> reduce

let mul r1 r2 =
   let { Num = n1; Den = d1 } = r1
   let { Num = n2; Den = d2 } = r2
   create (n1*n2) (d1*d2)
   |> reduce

let div r1 r2 =
   let { Num = n1; Den = d1 } = r1
   let { Num = n2; Den = d2 } = r2
   create (n1*d2) (n2*d1)
   |> reduce

let abs r =
   let { Num = n; Den = d } = r
   create (abs n) (abs d)
   |> reduce

let exprational n r =
    let { Num = num; Den = den } = r
    if n < 0 then
        let pow = -n
        create (int ((float den) ** pow )) (int ((float num) **  pow))
        |> reduce
    else
        let pow = n
        create (int ((float num) ** pow)) (int ((float den) ** pow))
        |> reduce

let expreal r n =
    let { Num = num; Den = den } = r
    Math.Pow(n, (float num) / (float den))
