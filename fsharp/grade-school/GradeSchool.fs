module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School =
    if Map.exists (fun _ -> List.contains student) school then
        school
    else
        let newGrade =
            match school.TryFind grade with
            | Some students when List.contains student students -> students
            | Some students -> List.sort(student :: students)
            | None ->  student :: []
        school.Add (grade, newGrade)

let roster (school: School): string list =
    match school with
    | school when school = empty -> []
    | school -> List.concat school.Values

let grade (number: int) (school: School): string list =
    match school.TryFind number with
    | Some students -> students
    | None -> []
