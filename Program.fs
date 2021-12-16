module AoC2017.Main

open AoC2017.Utils
open AoC2017.Day1


[<EntryPoint>]
let main argv =
    let day = argv |> getProblem
    match day with
    | "1" -> day1 "1" ()
    | "1b" -> day1part2 "1" ()
    | "test" -> day1part2 "1" ()
    |> printfn "%d"
    0
   