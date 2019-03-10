namespace ProjectEuler

module Problem2 =
    let Solution = 
        let fibSeq = FibonacciGenerator.Generate 4_000_000
        fibSeq |> Seq.filter (fun x -> x % 2 = 0) |> Seq.sum

