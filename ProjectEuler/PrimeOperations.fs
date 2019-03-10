namespace ProjectEuler

open System

module PrimeOperations =
    let IsPrime (num : int64) =
        match num with
        | 1L -> false
        | 2L -> true
        | _ ->
            if (num % 2L = 0L)
            then false
            else
                let ceiling = int64(Math.Ceiling(Math.Sqrt(float(num))))
                seq {3L..2L..ceiling} |> Seq.forall (fun x -> num % x <> 0L)

    let GeneratePrimes (numOfPrimes : int64) =
        seq {2L..(numOfPrimes-1L)} |> Seq.filter (fun i -> (seq{2L..int64(Math.Sqrt(float(i)))} |> Seq.forall (fun j -> i % j <> 0L)))

    let PrimeFactors (num : int64) =
        let ceiling = int64(Math.Ceiling(Math.Sqrt(float(num))))
        seq {int64(2)..ceiling} 
        |> Seq.filter (fun i -> num % i = int64(0)) 
        |> Seq.filter IsPrime