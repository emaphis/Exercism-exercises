module KindergartenGarden

/// Represents plants
type Plant =
    | Radishes
    | Clover
    | Grass
    | Violets
    | What

/// Convert Char to it's Plant representation
let getPlant plant =
    match plant with
    | 'R' -> Radishes
    | 'C' -> Clover
    | 'G' -> Grass
    | 'V' -> Violets
    | _ -> What


// Alice, Bob, Charlie, David, Eve, Fred, Ginny, Harriet, Ileana, Joseph, Kincaid, Larry
// Student's names are in alphabetical order. The first letter serves as an index

/// Return 0 based index given students's name. (name is a code 0..11, each code represnts 2 pots)
let getStudentIndex (student: string) = (int student[0] - 65) * 2

/// Get the two rows of plant indexes from the diagram, return rows as 2 char arrays.
let getRows (diagram: string) =
    let rows = diagram.Split('\n')
    let row1 = rows[0].ToCharArray()
    let row2 = rows[1].ToCharArray()
    row1, row2


let plants diagram student =
    let row1, row2 = getRows diagram
    let idx = getStudentIndex student
    let plants = [ row1[idx]; row1[idx + 1]; row2[idx]; row2[idx + 1] ]
    List.map (fun plnt -> getPlant plnt) plants
