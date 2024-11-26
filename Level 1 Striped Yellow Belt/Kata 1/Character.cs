namespace kata1;

public class Character
{
    public string Name{get;}
    public int Health{get; set; }
    public Action<List<Character>> PrimaryAction { get; }

    public Character(string name, int health, Action<List<Character>> primaryAction)
    {
        Name = name;
        Health = health;
        PrimaryAction = primaryAction;
    }
}