// Hamming Distance worksheet

let str1 = "GGACGGATTCTG"
let str2 = "AGGACGGATTCT"
// should be 9

//let zip1 = Seq.zip str1 str2

Seq.zip str1 str2
|> Seq.filter (fun (chr1, chr2) -> chr1 <> chr2)
|> Seq.length
|> Some
