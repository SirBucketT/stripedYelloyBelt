namespace Kata2;

public class Character
{
    public string Name {get;}
    public int Health { get; set; }

    public Action<List<Character>> CharacterAction { get; }
    public event Action<int> HealthChanged;
    
    //public delegate void CharacterAction(Character target, int amount);
   // public delegate HealthChanged();
    public Character(string name, int health, Action<List<Character>> characterAction)
    {
        Name = name;
        Health = health;
        CharacterAction = characterAction;
        HealthChanged?.Invoke(health);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        HealthChanged?.Invoke(Health);
    }
}