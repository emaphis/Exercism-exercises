module RolePlayingGame

type Player = { 
    Name: string option
    Level: int
    Health: int
    Mana: int option
}

let introduce (player: Player): string = 
    Option.defaultValue "Mighty Magician" player.Name

let revive (player: Player): Player option = 
    if player.Health > 0 then None
    elif player.Level > 9 then
        Some { player with Health = 100; Mana = Some 100 }
    elif player.Level < 4 then
        Some { player with Health = 100 }
    else Some player

let castSpell (manaCost: int) (player: Player): Player * int =
    match player.Mana with
    | None ->
        let health = max (player.Health - manaCost) 0
        { player with Health = health }, 0
    | Some mana ->
        if player.Mana.Value < manaCost then player, 0
        else
            let newMana =  mana - manaCost
            let damage = 2 * manaCost
            { player with Mana = Some newMana }, damage
