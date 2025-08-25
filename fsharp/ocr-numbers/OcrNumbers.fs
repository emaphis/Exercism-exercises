module OcrNumbers

// Number array definitions

let lst0 =
    [ " _ "
      "| |"
      "|_|"
      "   " ]

let lst1 =
    [ "   ";
      "  |";
      "  |";
      "   " ]

let lst2 =
    [ " _ ";
      " _|";
      "|_ ";
      "   " ]

let lst3 =
     [ " _ ";
       " _|";
       " _|";
       "   " ]

let lst4 =
     [ "   ";
       "|_|";
       "  |";
       "   " ]

let lst5 =
    [ " _ ";
      "|_ ";
      " _|";
      "   " ]

let lst6 =
     [ " _ ";
       "|_ ";
       "|_|";
       "   " ]

let lst7 =
    [ " _ ";
      "  |";
      "  |";
      "   " ]

let lst8 =
    [ " _ ";
      "|_|";
      "|_|";
      "   " ]

let lst9 =
    [ " _ ";
      "|_|";
      " _|";
      "   " ]

let convertDigit (dig: string list) =
   if   dig.Length % 4 <> 0 then None
   elif (List.exists (fun line -> (String.length line) % 3 <> 0) dig) then None
   elif dig = lst0 then Some "0"
   elif dig = lst1 then Some "1"
   elif dig = lst2 then Some "2"
   elif dig = lst3 then Some "3"
   elif dig = lst4 then Some "4"
   elif dig = lst5 then Some "5"
   elif dig = lst6 then Some "6"
   elif dig = lst7 then Some "7"
   elif dig = lst8 then Some "8"
   elif dig = lst9 then Some "9"
   else Some "?"

let convert input = convertDigit input