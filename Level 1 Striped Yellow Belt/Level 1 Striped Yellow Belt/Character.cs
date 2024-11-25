namespace Level_1_Striped_Yellow_Belt;

public class Character
{
    public string Name{get;}
    public int Health{get; set;}
    public Action<Character> PrimaryAction { get;  set; }

    public Character(string name, int health, Action<List<Character>> primaryAction)
    {
        Name = name;
        Health = health;
        PrimaryAction = primaryAction as Action<Character>;
    }
}