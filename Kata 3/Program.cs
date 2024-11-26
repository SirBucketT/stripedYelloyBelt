namespace Kata_3;

class Program
{
    static void Main()
    {
        var hellfire = new AttackAbility("Hellfire", "Hellfire's inferno deals over 9000 damage, you got fried.");
        var healing = new HealAbility("Revival bead", "Revives deeply fried human.");
        
        var attackAbilityContainer = new AbilityContainer<AttackAbility>();
        var healAbilityContainer = new AbilityContainer<HealAbility>();
        
        attackAbilityContainer.AddAbility(hellfire);
        healAbilityContainer.AddAbility(healing);
        
        attackAbilityContainer.DisplayAbilities();
        healAbilityContainer.DisplayAbilities();
        
        var retrieved = attackAbilityContainer.GetAbilityByName("Hellfire");
        Console.WriteLine($"Retrieved Ability: {retrieved.Name} - {retrieved.Effect}");
        
        attackAbilityContainer.RemoveAbility(hellfire);
        attackAbilityContainer.DisplayAbilities();
    }
}