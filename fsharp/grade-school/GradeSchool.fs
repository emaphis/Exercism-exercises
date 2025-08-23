module GradeSchool

open System.Collections.Generic
open System.Linq

type School = Map<int, string list>

let empty: School = Map.empty


let add (student: string) (grade: int) (school: School): School =
    if Map.exists (fun _ students -> List.contains student students) school then
        school
    else
        let newGrade =
            match Map.tryFind grade school with
            | Some students ->
                if List.contains student students then
                    students
                else
                    List.sort (student :: students)
            | None -> [student]

        Map.add grade newGrade school


let roster (school: School): string list =
    match school with
    | schl when schl = empty -> []
    | schl -> schl.Values |> List.concat


let grade (number: int) (school: School): string list =
    match Map.tryFind number school with
    | Some students -> students
    | None -> []
