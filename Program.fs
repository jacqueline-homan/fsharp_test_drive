//Set the compilation warning to light mode with hash light
#light

(*
    Output Hello World!
    This is a multi-line
    comment in F#.
*)

(*Open directives - this one tells F# to use anything
inside the system at our disposal and we don't need 
the word System preceeding Console.WriteLine.
*)
open System
open System.Collections
open System.IO
//Output Hello World!
Console.WriteLine("Hello, J")

///<summary>
/// Squared squares a number and then returns it. 
///</summary>
///<returns>
///This function
///returns an integer squared
///<summary>
//let squared x = x * x
let testValue = "This is a test value" 
Console.WriteLine(testValue)

//Mutable values and "<-" as the assignment operator in F#
let mutable testValueTwo = 7
Console.WriteLine(testValueTwo)
testValueTwo <- 9 //Nota Bena: Can't use "<-" with an int of type ref
Console.WriteLine(testValueTwo)
//The special word "ref" requires use of ".Value" in the
//Console.Write parameters like so: testNum.Value
let testNum = ref 8
// Nota Bena: Must use the ":=" when changing values that 
// are ref values
testNum := 4 
Console.WriteLine(testNum.Value)

(*
printfn (Microsoft.FSharp.Core.Pervasives)
%b - booleans
%c - char
%d, %i, %o, %u, %x - integers
%e, %f, %f - floats
%s - strings
%A - anything else
*)
//Output my name
Console.WriteLine("My name is Jacqueline S. Homan")
//Or output my name this way:
let myName = "My name is Jacqueline S. Homan"
printfn "%s" myName

let number = 5
printfn "%s %i times." myName number //Nota Bena: Order matters!
(*
The screen output is "My name is Jacqueline S. Homan 5 times."
*)

//The magic of I/O and user interactive programs begins here
Console.WriteLine("Press 1 for Hello or 2 for Goodbye: ")
let input = Console.ReadLine()

if input.Equals("1") then
    Console.WriteLine("Hello")
else
    Console.WriteLine("Goodbye")


(*Iterating through several options, taking conditional
expressions further
*)
Console.WriteLine("**********************************")
Console.WriteLine("*   Welcome to the Dev Hotline   *")
Console.WriteLine("**********************************")
Console.WriteLine("Press 1 to reach Evan")
Console.WriteLine("Press 2 to reach Jacqueline")
Console.WriteLine("Press 3 to reach Leah")
Console.WriteLine("Press 4 to reach Adrienne")
Console.WriteLine("Press 0 for the operator")
let userinput = Console.ReadLine()

// Set up conditions where user input is true
if userinput.Equals("1") then
    Console.Write("Hello, this is Evan.\n")
elif userinput.Equals("2") then
    Console.Write("Hello, this is Jacqueline.\n")
elif userinput.Equals("3") then
    Console.Write("Hello, this is Leah.\n")
elif userinput.Equals("4") then
    Console.Write("Hello, this is Adrienne.\n")
elif userinput.Equals("0") then
    Console.Write("Please hold, we're transferring your call.\n")
else
    Console.Write("This call has ended. Goodbye!\n")


// Define list of callers and numbers
let numbers = [1..5]
let callers = ["Evan";"Leah";"Jacqueline";"Adrienne";"Ed"]
//let mutable value = 0

// While Loop to iterate through list or array, usually when you don't know
// the length of the list you want to iterate through
(*let mutable value = 0
while value < callers.Length do    
    let caller = callers.Item(value)
    let number = numbers.Item(value)
    printfn "Press %i for %s" number caller
    value <- value + 1
done    
*)

// For Loop to iterate through a list or array where we know the lenght 
for value = 0 to (callers.Length - 1) do   
    let caller = callers.Item(value)
    let number = numbers.Item(value)
    printfn "Press %i for %s" number caller    
done  


let beginning x y = x - 2*y
let ending x y = x + 2*y

let function3 x y =
    for i = (beginning x y) to (ending x y) do
        printf "%d " i
    done 
    printfn ""
function3 10 4

(* let arrA = [|1;3;5;7;9|] 
printfn ((arrA.Length int) : int  
    if (arrA.[0] to arrA.[4] -1) then 
        printf("%i")    

    printf("%d", arrA int)

printf("%d", arrA int)    
*)

//Traffic Light - pattern matchin
type TrafficLight = 
    | Green
    | Red
    | Yellow
let nextLight (currentLight : TrafficLight) : TrafficLight =
    match currentLight with
        | Green -> Yellow
        | Red -> Green
        | Yellow -> Red 

Console.WriteLine("You've Come to the Traffic Light - Pick your color!")
Console.WriteLine("Enter 1 for Red")
Console.WriteLine("Enter 2 for Yellow")
Console.WriteLine("Enter 3 for Green")
Console.WriteLine("Enter 4 to exit")

let user = Console.ReadLine()
let colors = ["Red"; "Yellow"; "Green";]
let num = [1..3]
if user.Equals("1") then
    Console.WriteLine("Red light!")
elif user.Equals("2") then
    Console.WriteLine("Yellow light!")
elif user.Equals("3") then
    Console.WriteLine("Green light!")
else
    Console.Write("OK! You're off to the races! Goodbye")
ignore 0

let mutable valu = 0

while valu < colors.Length do    
    let color = colors.Item(valu)
    let num = num.Item(valu)
    printfn "Press %i for %s" num color
    valu <- valu + 1
done    

//Batter up!
type Player = {Name : string; Rank : int}
let isTheBest (player : Player) : bool =
    match player with
        | {Name = name; Rank = 1} -> do (printfn "%s is best player!" name)
                                     true
        | {Name = name; Rank = _} -> do (printfn "%s sucks." name)
                                     false
(*
let bestOfThree (leftPlayer : Player) (rightPlayer : Player) (turns : turnList)
  : Player option =
    let decideMatch turn = 
        match turn with
            | Throws (Rock, Paper) -> Right
            | Throws (Rock, Scissors) -> Left
            | Throws (Paper, Scissors) -> Right
            | Throws (Paper, Rock) -> Right
            | Throws (Scissors, Rock) -> Right
            | Throws (Scissors, Paper) -> Left
            | _ -> Tie
       
     let (Turns ts) = turns

     let decisions = List.map decideMatch ts
     let counts = List.fold (fun c result -> match result with
                                               | Left -> (c-1)
                                               | Right -> (c+1)
                                               | Tie -> c)
                             0
                             decisions
      match counts with 
        | x when x > 0 -> Some rightPlayer
        | x when x < 0 -> Some leftPlayer
        | _ -> None
*)          


//Stop console from closing, which is useful for testing.
Console.ReadKey(true) |> ignore


// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

//module Hello_World.Main

//open System

//let someFunction x y = x + y

//[<EntryPoint>]
//let main args = 
//    Console.WriteLine("Hello world!")
//    0



