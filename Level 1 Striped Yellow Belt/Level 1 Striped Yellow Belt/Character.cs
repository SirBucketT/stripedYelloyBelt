namespace Level_1_Striped_Yellow_Belt;

public class Character
{
    public string Name{get; set;}
    public int Health{get; set;}
    public Action<List<Character>> PrimaryAction { get; set; }
}