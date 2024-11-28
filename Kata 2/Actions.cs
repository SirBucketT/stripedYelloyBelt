namespace Kata2;

public class Actions
{
    public static void Game()
    {
        Random rnd = new Random();
        Random rnd2 = new Random();
        int rdn1 = rnd.Next(0, 1000);
        int rdn3 = rnd2.Next(0, 1000);
        Character arin = new Character("Arin", rdn1, characterAction: (targets) =>
        {
            if (targets.Any())
            {
                var target = targets.OrderBy(t => t.Health).First();
                target.Health -= 100;
                Console.WriteLine($"Arin Attacks {target.Name}.");
            }
        });

        Character dalia = new Character("Dalia", rdn3, characterAction: (targets) =>
        {
            if (targets.Any())
            {
                var target = targets.OrderBy(t => t.Health).First();
                target.Health -= 100;
                Console.WriteLine($"Dalia attacks {target.Name}.");
            }
        });

        static void OnHealthChanged(int health)
        {
            Console.WriteLine($"HP changed to {health}");
        }

        Console.WriteLine($"Arin HP: {arin.Health}");
        Console.WriteLine($"Dalia HP: {dalia.Health}");

        List<Character> characters = new List<Character> { arin, dalia };
        arin.CharacterAction(characters);
        arin.HealthChanged += OnHealthChanged;
        OnHealthChanged(arin.Health);
        
        dalia.CharacterAction(characters);
        dalia.HealthChanged += OnHealthChanged;
        OnHealthChanged(dalia.Health);
    }
}
    