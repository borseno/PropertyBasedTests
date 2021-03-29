// Learn more about F# at http://fsharp.org

open System
open FsCheck

let line (angle:float) modulus x =
    if angle = -infinity 
        then 0.0
    else
        if modulus <> 0.0
            then (angle * x) % modulus
        else 0.0

let ``absolute y is greater or equal to x if angle >= 1`` angle modulus x = 
    let y = line angle modulus x
    (abs y) <= (abs modulus)

let ``y mod x should be y`` angle modulus x = 
    let y = line angle modulus x
    y % x = y

Check.Verbose ``absolute y is greater or equal to x if angle >= 1``

[<EntryPoint>]
let main argv =
    //line 0.0 0.0 0.0 |> printfn "%f"
    printfn "Hello World from F#!"
    0 // return an integer exit code
