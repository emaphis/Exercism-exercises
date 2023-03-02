module KindergartenGarden

type Plant =
  | Radishes
  | Clover
  | Grass
  | Violets

  /// Translate plant code to plant
let findPlant plant =
    match plant with
    | 'R' -> Radishes
    | 'C' -> Clover
    | 'G' -> Grass
    | 'V' -> Violets
    | _   -> failwith "Unknown plant"

/// Translate Student into a row rank index
// Lol: I just noticed the first char of a students name is
//      an index into the rows assuming an ASCI compatible char set
//      and there are two planta per student per row
//      Sooo ....
let getRank (student: string) = (int student[0] - 65) * 2

/// Get plant given a student, row, and plant index (two per row)
let getPlant (student: string) (row: string) index =
   let plantCode = row[getRank(student) + index]
   findPlant(plantCode)

let plants diagram student =
    let rows = (diagram: string).Split('\n')
    let plant1 = getPlant student rows[0] 0
    let plant2 = getPlant student rows[0] 1
    let plant3 = getPlant student rows[1] 0
    let plant4 = getPlant student rows[1] 1
    [ plant1; plant2; plant3; plant4 ]
