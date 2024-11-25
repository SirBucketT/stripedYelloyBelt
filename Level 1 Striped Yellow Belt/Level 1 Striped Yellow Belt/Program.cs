namespace Level_1_Striped_Yellow_Belt;

class Program
{
    static int Main()
    {
        Random random = new Random();
        Random random1 = new Random();
        Random random2 = new Random();
        Random random3 = new Random();

        Character warrior = new Character("Warrior", random.Next(0, 101), primaryAction: (targets) =>
        {
            if (targets.Any())
            {
                 var target = targets.First();
                 target.Health -= 20;
                 Console.WriteLine($"{target.Name} takes 20 damage! Health is now {target.Health}.");
            }
        });

        Character healer = new Character("Healer", random1.Next(0, 101), primaryAction: (targets) =>
        {
             Console.WriteLine("Healer McHeals!");
             if (targets.Any())
             {
                 var target = targets.OrderBy(t => t.Health).First();
                 target.Health += 15;
                 Console.WriteLine($"{target.Name} is healed by 16! Health is now {target.Health}.");
             }
        });
        if (warrior.Health < 50 && healer.Health < 50)
        {
            warrior.Health = random2.Next(70, 100);
            healer.Health = random3.Next(30, 50);
        }
        if (warrior.Health > 50 && healer.Health > 50)
        {
            warrior.Health = random2.Next(70, 100);
            healer.Health = random3.Next(30, 50);
        }

        List<Character> characters = new List<Character> { warrior, healer };

        Console.WriteLine($"{healer.Name} HP: {healer.Health}");
        Console.WriteLine($"{warrior.Name} HP: {warrior.Health}");
        
        bool charactersAreAlive = characters.Any();
        while (charactersAreAlive)
        {
            foreach (Character character in characters)
            {
                if (character.Health <= 0)
                {
                    Console.WriteLine($"{character.Name} is dead!");
                    charactersAreAlive = false;
                    //character.Health = 0;
                    break;
                }
                if (character.Health < 50)
                {
                    warrior.PrimaryAction(characters);
                    Console.WriteLine($"{warrior.Health} warrior health {healer.Health}!");
                }

                if (character.Health >= 50)
                {
                    healer.PrimaryAction(characters);
                }

                Console.WriteLine($"Healer HP: {healer.Health}");
                Console.WriteLine($"Warrior HP: {warrior.Health}");
            }
        }

        var warriors = characters.Where(t => t.Name != "Warrior").ToList();
        var healers = warriors.Where(z => z.Name != "Healer").ToList();
        return 0;
        // while (warriors.Any(c => c.Health > 0))
        // {
        //     foreach (Character character in warriors)
        //     {
        //         if (character.Health <= 0)
        //         {
        //             Console.WriteLine($"{character.Name} is dead!");
        //             break;
        //         }
        //         
        //         if (character.Health < 50)
        //         {
        //             warrior = character;
        //             Console.WriteLine($"{character.Name} prioritize attacking!");
        //             character.Health -= 20;
        //
        //         }
        //         
        //         if (character.Name == "Healer")
        //         {
        //             healer = character;
        //             Console.WriteLine($"{character.Name} prioritize McHeals!");
        //             character.Health += 15;
        //         }
        //
        //         character.PrimaryAction(warriors.First());
        //
        //         if (warriors.Count(c => c.Health > 0) <= 1)
        //         {
        //             Console.WriteLine("Loop condition met");
        //             break;
        //         }
        //         foreach (var c in warriors)
        //         {
        //             Console.WriteLine($"{c.Name} HP: {c.Health}");
        //         }
        //     }
        // }
    }
}    
