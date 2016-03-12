
open System


let split (li : List<int>) = 
    let rec split_helper (left_list : List<int>) (right_list : List<int>) =
            let x = left_list.Length - right_list.Length
            match x with 
                | 0 -> (left_list, right_list)
                | 1 -> (left_list, right_list)
                | _ -> split_helper (List.tail left_list) (List.head left_list :: right_list)
    split_helper li []

let rec merge left right = 
    match (left,right) with 
    | (ls, []) -> ls
    | ([], rs) -> rs
    | (l::ls, r::rs) -> if l < r then l :: (merge ls (r :: rs)) else r :: (merge (l :: ls) rs)

let rec mergesort li = 
    match li with 
    | [first] -> [first]
    | [first; second] -> if first < second then [first; second] else [second; first]
    | same_list -> 
        let (M,N) = split same_list in
            merge (mergesort M) (mergesort N)

// Running mergesort:

let my_list = [5; 6; 3; 1; 8; 2; 3; 12; 7];;
let l1 = [1; 3;];;
let l2 = [2; 4;];;

let go = mergesort my_list

let main() =
    printfn "%A" (go);; // for printing a list
    //Console.WriteLine("out: {0}", go) // for printing anything else

main()
