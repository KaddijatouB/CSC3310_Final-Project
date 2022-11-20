
module Scores

type Title =
| Awesome
| Cool
| Outstanding
| Amazing
| Interesting
| Sacriligious

type Score =
| Grade of float //case identifier for an unamed float
| Rank of Title //case identifier for another union
| Points of //case identifier for a set of values
    items: int * //star indicates that the types must go together (like a tuple)
    time: float * 
    combos: int 
| Comments of //case identifier without names
    char * 
    string option //optional value (can be omitted)

let getTitle title =
    match title with
    | Awesome -> printfn "You are sooo awesome!"
    | Cool -> printfn "That was Cool! Pun entirely intended."
    | Outstanding -> printfn "You did outstanding!!"
    | Amazing -> printfn "That was AmAziNg"
    | Interesting -> printfn "iNteReStiNg / 10"
    | Sacriligious -> printfn "I have no words....."

let printVal opt =
    match opt with
    | Some x -> $"{x}"
    | None -> "..."

let getScore score =
    match score with
    | Grade(float) -> printfn "Your grade is: %f" float
    | Rank(title) -> getTitle title
    | Points(items, time, combos) -> printfn "Your total score is: %f" ((float)items + time + (float)combos)
    | Comments(letter, statement) -> printfn $"{letter} - {printVal statement}"

[<EntryPoint>]
let main argv =
    //simple union type
    let gpa = Grade(3.5)
    //union type of another union
        //using another variable
    let fail = Sacriligious
    let noob = Rank(fail)
        //without another variable
    let pro = Rank(Outstanding)
    //union type of multiple values
        //with names
    let champ = Points(items = 30, time = 5.5, combos = 20)
        //without names
    let loser = Points(4, 16.6, 1)
    //union type without names
        //with option type
    let yay = Comments('Y', Some("Yay!!!!"))
        //without option type
    let nay = Comments('N', None)
    //output
    getScore gpa
    getScore noob
    getScore pro
    getScore champ
    getScore loser
    getScore yay
    getScore nay
    0 // Return an integer exit code