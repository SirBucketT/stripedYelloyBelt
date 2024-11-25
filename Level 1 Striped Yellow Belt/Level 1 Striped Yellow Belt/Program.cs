namespace Level_1_Striped_Yellow_Belt;

class Program
{
    static void Main()
    {
        Random random = new Random();
        Random random1 = new Random();

        Character warrior = new Character("Warrior", random.Next(40, 51), primaryAction: (targets) =>
        {
            Console.WriteLine("Warrior McWars!");
            if (targets.Any())
            {
                var target = targets.First();
                target.Health -= 20; 
                Console.WriteLine($"{target.Name} takes 20 damage! Health is now {target.Health}.");
            }
        });

        Character healer = new Character("Healer", random1.Next(40, 51), primaryAction: (targets) =>
        {
            Console.WriteLine("Healer McHeals!");
            if (targets.Any())
            {
                var target = targets.OrderBy(t => t.Health).First();
                target.Health += 15; 
                Console.WriteLine($"{target.Name} is healed by 16! Health is now {target.Health}.");
            }
        });
        
        List<Character> characters = new List<Character> { warrior, healer };
        
        Console.WriteLine($"{healer.Name} HP: {healer.Health}");
        Console.WriteLine($"{warrior.Name} HP: {warrior.Health}");
        
        foreach (Character character in characters)
        {
            if (characters != null)
            {
                break;
            }

            if (character.Health < 50)
            {
                Console.WriteLine($"{character.Name} prioritize attacking using McWars!");
                target = target.Where(t => t.Name != "Healer").ToList();
            }

            if (character.Name == "Healer")
            {
                Console.WriteLine($"{character.Name} prioritize McHeals!");
            }
            character.PrimaryAction(characters.First()); 
            
        }
    }
}
