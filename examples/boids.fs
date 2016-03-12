

open System


let coords = [(0,0); (5,5)];;


let _origin = (0,0);;
let _start = (0,0);;
let _end = (5,5);;

let sqr x = x * x

let dist (a,b) (c,d) = sqrt (float ((sqr (a - c)) + sqr ((b - d))))

let go = coords |> List.map (fun x -> dist x _origin);;

let main() =
    Console.WriteLine("out: {0}", (go))

main()
