public class tamagotchi
{
    private int hunger;

    private int boredom;

    private List<string> words = ["Harro",];

    private bool isAlive = true;

    public string Name;

    public void Feed()
    {
        Console.WriteLine($"{Name} eats and becomes less hungry.");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Hi()
    {
        int WordNum = Random.Shared.Next(words.Count);
        Console.WriteLine($"{Name} Says: {words[WordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($"{Name} learns: {word} ");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"name: {Name} || hunger: {hunger} || boredom: {boredom} || Vocabulary: {words.Count} words");
    }

    public bool GetAlive()
    {

        return isAlive;

    }

    private void ReduceBoredom()
    {
        Console.WriteLine($" [{Name}] is now less bored!");

        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }

}
