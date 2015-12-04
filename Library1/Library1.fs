
#if INTERACTIVE
#else 
module JumpStart
#endif

// Alt + Enter to Run

let x = 42
let hi = "Hello"

let Square x = x * x

let Area (length :float) height=
    length * height

let Greeting name =
    if System.String.IsNullOrWhiteSpace(name) then
        "whoever you are"
    else 
        name

let SayHiToMe me = 
    printfn "Hi, %s" (Greeting me)

let PrintNumbers min max =
  let square x = x * x
  for x in min..max do
    printfn "%i %i" x (square x)


let RandomPosition() = 
    let r = new System.Random()
    r.NextDouble(), r.NextDouble()

let Latitude, Longitude = RandomPosition()

open System.IO
let files = Directory.EnumerateFiles("@c:\windows","*.exe")