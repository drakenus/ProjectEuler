namespace ProjectEuler

module Problem1 =
    let Solution = 
        let sequence = {1..999}
        let filteredSequence = Seq.filter (fun x -> x % 3 = 0 || x % 5 = 0) sequence
        Seq.sum filteredSequence
