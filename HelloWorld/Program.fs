open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let add x y = x + y

let sub x y = x - y

let printThreeNumbers num1 num2 num3 =
    printfn "num1: %i" num1
    printfn "num2: %i" num2
    printfn "num3: %i" num3


let SayHello() = 
    printfn "Hello"


[<EntryPoint>]
let main argv = 
    //printfn "Hello World"
    //printThreeNumbers 5 (add 10 7) (sub 20 8)
    //Console.ReadLine() |> ignore 
    SayHello()
    Console.ReadLine() |> ignore 
    0
     // return an integer exit code


    

    