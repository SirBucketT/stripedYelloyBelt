namespace Kata2;

class Program
{
    static void Main()
    {
        Character Arin = new Character("Arin", 100, characterAction: (targets) =>
        {
            Console.WriteLine("Arin Attacks");
            if (targets.Any())
            {
                var target = targets.First();
                target.Health -= 10;
                Console.WriteLine($"Arin Attacks {target.Name}. {target.Name} Health {target.Health}");
            }
        });
        Character Dalia = new Character("Dalia", 100, characterAction: (targets) =>
        {
            Console.WriteLine("Dalia Attacks");
            if (targets.Any())
            {
                var target = targets.First();
                target.Health -= 10;
                Console.WriteLine($"Dalia attacks {target.Name}. {target.Name} Health: {target.Health}");
            }
        });
        
        List<Character> characters = new List<Character> { Arin, Dalia };

    }
}
