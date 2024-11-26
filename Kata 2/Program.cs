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
            }
        });
        Character Dalia = new Character("Dalia", 100, characterAction: (targets) =>
        {
            Console.WriteLine("Dalia Attacks");
            if (targets.Any())
            {
                
            }
        });
        
        List<Character> characters = new List<Character> { Arin, Dalia };
    }
}
