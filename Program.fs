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

//Output Hello World!
Console.WriteLine("Hello World")

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
(*if userinput.Equals("1") then
    Console.Write("Hello, this is Evan.")
elif userinput.Equals("2") then
    Console.Write("Hello, this is Jacqueline.")
elif userinput.Equals("3") then
    Console.Write("Hello, this is Leah.")
elif userinput.Equals("4") then
    Console.Write("Hello, this is Adrienne.")
elif userinput.Equals("0") then
    Console.Write("Please hold, we're transferring your call.")
else
    Console.Write("This call has ended. Goodbye!")
*)

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
 


let beginning x y = x - 2*y
let ending x y = x + 2*y

let function3 x y =
    for i = (beginning x y) to (ending x y) do
        printf "%d " i
    printfn ""
function3 10 4
    

//Stop console from closing, which is useful for testing.
System.Console.ReadKey(true)

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



