public class tamagotchi
{
    private int hunger;

    private int boredom;

    private List<string> words = [];

    private bool isAlive;

    public string Name;

    public void Feed()
    {
        hunger--;
    }

    public void Hi()
    {

    }

    public void Teach(string word)
    {

    }

    public void Tick()
    {
        isAlive = true;

        hunger++;
        boredom++;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }

        Console.ReadLine();
    }

    public void PrintStats()
    {
        Console.WriteLine($"hunger: {hunger}, boredom: {boredom}");
    }

    public bool GetAlive()
    {

        return isAlive;

    }

    private void ReduceBoredom()
    {
        boredom--;
    }

}
