namespace Level_1_Striped_Yellow_Belt;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Random random1 = new Random();
        
        Character Warrior = new Character
        {
            Name = "Warrior",
            Health = random.Next(0, 100),
            PrimaryAction = (targets) =>
            {
                Console.WriteLine("Warrior McWar!");
                if (targets.Any())
                {
                    var target = targets.First();
                    target.Health -= 20; 
                    Console.WriteLine($"{target.Name} takes 20 damage! Health is now {target.Health}.");
                }
            }
        };
        Character Healer = new Character
        {
            Name = "Healer",
            Health = random1.Next(0, 100),
            PrimaryAction = (targets) =>
            {
                if (targets.Any())
                {
                    var target = targets.OrderBy(t => t.Health).First();
                    target.Health += 15; 
                    Console.WriteLine($"{target.Name} is healed by 16! Health is now {target.Health}.");
                }
            }
        };    
        
        List<Character> characters = new List<Character> { Warrior, Healer };
        
        Console.WriteLine($"{Healer.Name} HP: {Healer.Health}");
        Console.WriteLine($"{Warrior.Name} HP: {Warrior.Health}");
        
        foreach (Character character in characters)
        {
            if (characters != null)
            {
                break;
            }
            
            character.PrimaryAction(targets);
        }
    }
}
