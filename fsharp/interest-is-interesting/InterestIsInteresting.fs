module InterestIsInteresting

let interestRate (balance: decimal): single =
    if   (balance < 0.0m)    then 3.213f
    elif (balance < 1000.0m) then 0.5f
    elif (balance < 5000.0m) then 1.621f
    elif (balance < 5000.0m) then 3.213f
    else  2.475f
    

let interest (balance: decimal): decimal =
    let rate =  decimal (interestRate balance) / 100.0m
    balance * rate 


let annualBalanceUpdate(balance: decimal): decimal =
    balance + (interest balance)


let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    if balance > 0.0m then
        let rate =  decimal (taxFreePercentage / 100.0 * 2.0)
        int (balance * rate)
    else
        0
