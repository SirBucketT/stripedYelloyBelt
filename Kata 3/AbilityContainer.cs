namespace Kata_3;

public class AbilityContainer<T> where T : IAbility
{
    private readonly List<T> _abilities = new();

    public void AddAbility(T ability)
    {
        _abilities.Add(ability);
        Console.WriteLine($"Ability added: {ability.Name}");
    }

    public void RemoveAbility(T ability)
    {
        if (_abilities.Remove(ability))
            Console.WriteLine($"Ability removed: {ability.Name}");
        else
            Console.WriteLine("Ability not found!");
    }

    public T GetAbilityByName(string name)
    {
        return _abilities.Find(ability => ability.Name == name);
    }

    public void DisplayAbilities()
    {
        if (_abilities.Count == 0)
        {
            Console.WriteLine("404 abilities not found");
            return;
        }

        Console.WriteLine("Abilities in the container:");
        foreach (var ability in _abilities)
        {
            Console.WriteLine($"{ability.Name}: {ability.Effect}");
        }
    }
}
