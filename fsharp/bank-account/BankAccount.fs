module BankAccount

type Account =
    { mutable Balance: decimal
      Open: bool
      Lock: obj }

let mkBankAccount() : Account =
   { Balance = 0.0m
     Open = false
     Lock = obj() }

let openAccount (account: Account) : Account =
    { account with
        Open = true }

let closeAccount (account: Account) =
    { account with
        Open = false }

let getBalance (account: Account) : Option<decimal> =
   if account.Open then Some account.Balance
   else None

let updateBalance (change: decimal) (account: Account) =
    lock account.Lock (fun () ->
            account.Balance <- account.Balance + change
    )

    account
