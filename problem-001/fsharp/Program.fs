let sumMultiplesOfThreeAndFive numbers = 
    numbers
    |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sum

let sum = sumMultiplesOfThreeAndFive [0..999]

printfn "The answer is: %i" sum
printfn ""
printfn "Hit any key to continue..."

ignore (System.Console.ReadKey true)
