namespace ProjectEuler

module FibonacciGenerator =
    let Generate upTo =
        Seq.unfold (fun (a, b) -> Some(a, (b, a+b))) (1,2) |> Seq.takeWhile (fun x ->  x <= upTo)