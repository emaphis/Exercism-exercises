module PizzaPricing

type Pizza =
    | Margherita
    | Formaggio
    | Caprese
    | ExtraSauce    of Pizza
    | ExtraToppings of Pizza


let rec pizzaPrice (pizza: Pizza): int =
    match pizza with
    | Margherita    -> 7
    | Caprese       -> 9
    | Formaggio     -> 10
    | ExtraSauce pizza    -> (pizzaPrice pizza) + 1
    | ExtraToppings pizza -> (pizzaPrice pizza) + 2

let orderPrice(pizzas: Pizza list): int =
    let rec priceOfPizzas pizzas acc =
        match pizzas with
        | []   -> acc
        | pizza :: pizzas ->
            priceOfPizzas pizzas (pizzaPrice pizza + acc)

    let extraCosts =
        match pizzas.Length with
        | 1  -> 3
        | 2  -> 2
        | _  -> 0

    (priceOfPizzas pizzas 0) + extraCosts
