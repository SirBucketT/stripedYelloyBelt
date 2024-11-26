namespace Kata_3;

public class Abilities
{
    
}
public class AttackAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public AttackAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}

public class HealAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public HealAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}
