namespace Level_2_stripped_yellow_belt;

class Program
{
    static void Main()
    {
        Character Arin = new Character("Arin", 100, characterAction: (targets) =>
        {
            Console.WriteLine("Arin Attacks");
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
