namespace Level_2_stripped_yellow_belt;

public class Character
{
    public string Name {get;}
    public int Health {get; }
    
    public Action<List<Character>> CharacterAction { get; }
    
    //public delegate void CharacterAction(Character target, int amount);

    public Character(string name, int health, Action<List<Character>> characterAction)
    {
        Name = name;
        Health = health;
        CharacterAction = characterAction;
    }
}