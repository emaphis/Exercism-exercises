module InterestIsInteresting

let interestRate (balance: decimal): single =
    if (balance < 0M) then 3.213f
    elif (balance < 1000M) then 0.5f
    elif (balance < 5000M) then 1.621f
    else 2.475f  // > 5000M


let interest (balance: decimal): decimal =
    let rate = decimal (interestRate balance) / 100m
    balance * rate


let annualBalanceUpdate(balance: decimal): decimal =
    let intrst = interest balance
    balance + intrst


let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    let rate =
        if balance > 0.0m then
            decimal (taxFreePercentage / 100.0 * 2.0)
        else
            0m
    int (balance * rate)
