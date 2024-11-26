namespace Kata2;

public class Character
{
    public string Name {get;}
    public int Health {get;}
    
    public Action<List<Character>> CharacterAction { get; }
    
    //public delegate void CharacterAction(Character target, int amount);
   // public delegate HealthChanged();

    public Character(string name, int health, Action<List<Character>> characterAction)
    {
        Name = name;
        Health = health;
        CharacterAction = characterAction;
    }
}
