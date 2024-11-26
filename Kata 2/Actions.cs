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
            Console.WriteLine("Arin Attacks");
            if (targets.Any())
            {
                var target = targets.OrderBy(t => t.Health).First();
                target.Health -= 10;
                Console.WriteLine($"Arin Attacks {target.Name}.");
                target.HealthChanged += OnHealthChanged;
            }
        });

        Character dalia = new Character("Dalia", rdn3, characterAction: (targets) =>
        {
            Console.WriteLine("Dalia Attacks");
            if (targets.Any())
            {
                var target = targets.OrderBy(t => t.Health).First();
                target.Health -= 10;
                Console.WriteLine($"Dalia attacks {target.Name}.");
                target.HealthChanged += OnHealthChanged;
            }
        });

        static void OnHealthChanged(int health)
        {
            Console.WriteLine($"health changed to {health}");
        }

        List<Character> characters = new List<Character> { arin, dalia };
        arin.CharacterAction(characters);
        OnHealthChanged(arin.Health);
        
        dalia.CharacterAction(characters);
        OnHealthChanged(dalia.Health);
    }
}
    