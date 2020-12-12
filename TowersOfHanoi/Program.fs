// Learn more about F# at http://fsharp.org

open System

let printMove start finish =
    printfn "%i -> %i" start finish

let rec move start finish amountDisks =    
    match amountDisks with
    | i when i <= 1 -> 
        printMove start finish
        1
    | n -> 
        let newFinish = 6 - start - finish
        let preMoves = move start newFinish (n-1)
        let actualMove = move start finish 1       
        let postMoves = move newFinish finish (n-1)
        preMoves + postMoves + actualMove

let rec totalMoves amountDisks =
    match amountDisks with
    | i when i <= 1 -> 1
    | n -> 
        let previousMoves = totalMoves (n - 1)
        2 * previousMoves + 1

[<EntryPoint>]
let main argv =
    if argv.Length < 1 then
        printfn "Please enter a number."
        1
    else
        argv.[0] 
        |> int
        |> move 1 3
        |> printfn "Total moves: %i"
        0
