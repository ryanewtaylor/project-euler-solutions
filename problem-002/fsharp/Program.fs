let MakeFibonacciSequence max =
    let rec FibonacciSeqImpl prev curr =
        if prev + curr < max then
            let current = prev + curr
            let rest = FibonacciSeqImpl curr current
            current :: rest
        else
            []

    0::1::(FibonacciSeqImpl 0 1)

let sumEvens list = 
    list
    |> List.filter (fun x -> x % 2 = 0)
    |> List.sum

let sum = sumEvens (MakeFibonacciSequence 4000000)

printfn "The answer is: %i" sum
printfn ""
printfn "Hit any key to continue..."

ignore (System.Console.ReadKey true)
