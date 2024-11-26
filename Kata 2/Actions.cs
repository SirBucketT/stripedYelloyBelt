namespace Kata2;

public class Actions
{
    public static void Game()
    {
        Character arin = new Character("Arin", 90, characterAction: (targets) =>
        {
            Console.WriteLine("Arin Attacks");
            if (targets.Any())
            {
                var target = targets.OrderBy(t => t.Health).First();
                target.Health -= 10;
                Console.WriteLine($"Arin Attacks {target.Name}. {target.Name} Health {target.Health}");
            }
        });

        Character dalia = new Character("Dalia", 89, characterAction: (targets) =>
        {
            Console.WriteLine("Dalia Attacks");
            if (targets.Any())
            {
                var target = targets.OrderBy(t => t.Health).First();
                target.Health -= 10;
                Console.WriteLine($"Dalia attacks {target.Name}. {target.Name} Health: {target.Health}");
                target.HealthChanged += OnHealthChanged;
            }
        });

        static void OnHealthChanged(int health)
        {
            Console.WriteLine($"Health changed to {health}");
        }

        List<Character> characters = new List<Character> { arin, dalia };
        arin.CharacterAction(characters);
        dalia.CharacterAction(characters);
    }

    public void OnHealthChanged(int health)
    {
        Console.WriteLine($"Health changed to {health}");
    }
}
    