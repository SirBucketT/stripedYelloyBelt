namespace Kata_3;

class Program
{
    static void Main(string[] args)
    {
        var fireball = new AttackAbility("Fireball", "Deals 50 fire damage.");
        var healingTouch = new HealAbility("Healing Touch", "Restores 30 health.");
        
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