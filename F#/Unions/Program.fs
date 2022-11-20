module MiiCreator

let square x = x * x

type Gender =
| Male
| Female

type Hair =
| Loose
| Bun
| Ponytail
| Braid
| Mohawk

[<EntryPoint>]
let main argv =
    printfn "%d squared is: %d!" 12 (square 12)
    0 // Return an integer exit code