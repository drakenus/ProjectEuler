namespace ProjectEuler

module PalindromeOperations = 
    let IsPalindrome<'T when 'T : equality> (p : seq<'T>) =
        let list = List.ofSeq p
        list = List.rev list
        