namespace ProjectEuler

module Problem3 = 
    let Solution = 
        let number = 600851475143L
        let primes = PrimeOperations.PrimeFactors number
        Seq.last primes