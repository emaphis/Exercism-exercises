module InterestIsInteresting

let interestRate (balance: decimal): single =
    if balance < 0.00M then 3.213f
    elif balance < 1_000.00M then 0.500f
    elif balance < 5_000.00M then 1.621f
    else 2.475f  // > 5_000.00M


let interest (balance: decimal): decimal =
   let rate = decimal (interestRate balance) / 100.00m
   balance * rate


let annualBalanceUpdate(balance: decimal): decimal =
   balance + (interest balance)

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
   let rate =
      if balance > 0.0m then
         decimal (taxFreePercentage / 100.0 * 2.0)
      else
         0m
   int (balance * rate)
