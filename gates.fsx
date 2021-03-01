let OR a b =
    match a, b with
    | 0, 0 -> 0
    |_ -> 1

let AND a b =
    match a, b with
    | 1, 1 -> 1
    |_ -> 0

let NOT a =
    match a with
    | 0 -> 1
    |_ -> 0

let XOR a b =
    match a, b with
    | 1, 0 -> 1
    | 0, 1 -> 1
    |_ -> 0

let NAND a b =
    match a, b with
    | 1, 1 -> 0
    |_ -> 1

let NOR a b =
    match a, b with
    | 0, 0 -> 1
    |_ -> 0

let XNOR a b =
    match a, b with
    | 1, 1 -> 1
    | 0, 0 -> 1
    |_ -> 0

let IMPLY a b =
    match a, b with
    | 1, 0 -> 0
    |_ -> 1

let NIMPLY a b =
    match a, b with
    | 1, 0 -> 1
    |_ -> 0





