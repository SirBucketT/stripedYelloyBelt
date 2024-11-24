namespace Level_1_Striped_Yellow_Belt;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int health = rnd.Next(0, 100);
        Random random = new Random();
        int health2 = random.Next(0, 100);
        
        Character Warrior = new Character
        {
            Name = "Warrior",
            Health = health,
        };
        Character Healer = new Character
        {
            Name = "Healer",
            Health = health2,
        };
    }
}
