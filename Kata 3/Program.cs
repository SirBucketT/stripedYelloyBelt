namespace Kata_3;

class Program
{
    static void Main(string[] args)
    {
        var fireball = new AttackAbility("Hellfire", "Hellfire's inferno deals over 9000 damage, you got fried.");
        var healingTouch = new HealAbility("Revival bead", "Revives deeply fried human.");
        
        var attackAbilityContainer = new AbilityContainer<AttackAbility>();
        var healAbilityContainer = new AbilityContainer<HealAbility>();
        
        attackAbilityContainer.AddAbility(fireball);
        healAbilityContainer.AddAbility(healingTouch);
        
        attackAbilityContainer.DisplayAbilities();
        healAbilityContainer.DisplayAbilities();
        
        var retrieved = attackAbilityContainer.GetAbilityByName("Fireball");
        Console.WriteLine($"Retrieved Ability: {retrieved.Name} - {retrieved.Effect}");
        
        attackAbilityContainer.RemoveAbility(fireball);
        attackAbilityContainer.DisplayAbilities();
    }
}