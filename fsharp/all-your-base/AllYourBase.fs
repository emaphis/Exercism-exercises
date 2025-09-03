module AllYourBase

let toNumberBase bas num =
    let rec convert nm acc =
        match nm with
        | 0 -> acc
        | _ -> convert (nm / bas) (nm % bas :: acc)

    match convert num [] with
    | []  -> Some [0]
    | dig -> Some dig


let fromNumberBase bas nums =
    let rec convert acc nms =
        match nms with
        | [] -> Some acc
        | dig::digs ->
            if dig <  0 ||  dig >= bas then None
            else
                convert (acc * bas + dig) digs

    convert 0 nums


let rebase digits inputBase outputBase =
    if inputBase < 2 || outputBase < 2 then None
    else
        digits
        |> fromNumberBase inputBase
        |> Option.bind (toNumberBase outputBase)
