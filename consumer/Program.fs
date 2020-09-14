// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open producer

[<EntryPoint>]
let main argv =

    DontSetMe(Data="Badness") |> ignore

    printfn "Hello world"
    0 // return an integer exit code