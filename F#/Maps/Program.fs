
open System

[<EntryPoint>]
let main argv =
    //initialize a map
    let generes = Map [(1, "action"); (2, "romance"); (3, "sci-fi")]
    printfn "Entertainment Generes: %A" generes
    
    //iterate through map
    let printPair k v =
        printfn "Key: %i Value: %s" k v
    generes |> Map.iter printPair

    //get value from map using its key
    let avengers = generes.[1]
    //let notFound = generes.[9] //throws KeyNotFoundException
    printfn "Avengers: %A" avengers
    
    //add a key-value pair to map
    let addGeneres = generes |> Map.add 4 "adventure"
    printfn "Added a genere: %A" addGeneres
    //replaces instead of adds
    let replaceGeneres = generes.Add(2, "documentary")
    printfn "Replaced a genere: %A" replaceGeneres

    //change a key-value pair in map using a change function
    let change x = //change function
        match x with
        | Some s -> Some (s + "-adventure")
        | None -> None
    let changeAction = generes.Change(1, change)
    printfn "Changed action: %A" changeAction
    let modifyRomance = generes |> Map.change 2 change
    printfn "Changed romance: %A" modifyRomance
    
    //Remove element at key in map
    let remove = generes.Remove 2
    printfn "Removed a genere: %A" remove
    let noRemove = generes.Remove 5
    printfn "No remove: %A" noRemove
    
    //Checking if an item at key is in the map
    let contained = generes |> Map.containsKey 3
    printfn "Is there an item 3: %A" contained
    let nonContained = generes.ContainsKey 7
    printfn "Is there an item 7: %A" nonContained
    
    //Get the number of elements in the map
    let totalItems = generes.Count
    printfn "Number of generes: %A" totalItems
    
    //Check if map is empty
    let nothing: Map<int, string> = Map.empty
    let empty = nothing.IsEmpty
    printfn "Empty map: %A" empty
    let notEmpty = generes.IsEmpty
    printfn "Non-empty map: %A" notEmpty
    
    //Find an element in map by key
    let miraculous = generes.Item 2
    printfn "Miraculous Ladybug: %A" miraculous
    //let error = generes.Item 9 //throws KeyNotFoundException
    
    //Find an element in map by key (Returns Some or None)
    let printObt x =
        match x with
        | Some s -> printfn "Sonic the Hedgehog: %A" s
        | None -> printfn "Super Mario Bros: "
    let sonic = generes.TryFind 1
    printObt sonic
    let missing = generes.TryFind 7
    printObt missing

    //Find an element in map and assign to a variable if found
    let mutable x = ""
    let adv = generes.TryGetValue(3, &x)
    printfn "Jungle Book: %A found: %A" x adv
    let mutable y = ""
    let gone = generes.TryGetValue(8, &y)
    printfn "Inside Out: %A found: %A" y gone

    0 // return an integer exit code

