Console.WriteLine("Welcome to tamagotchi type shi.");

tamagotchi tami = new();

Console.WriteLine("What yo tamagotchi name cuh?");
tami.Name = Console.ReadLine();


while (tami.GetAlive() == true)
{
    Console.Clear();
    tami.PrintStats();
    Console.WriteLine("Now what do you want to do?");
    Console.WriteLine($"1. Teach {tami.Name} a new word");
    Console.WriteLine($"2. Talk to {tami.Name}");
    Console.WriteLine($"3. Feed {tami.Name}");
    Console.WriteLine($"4. Do nothing");
    
    string doo = Console.ReadLine();

    if (doo == "1")
    {
        Console.WriteLine("what word?");
        Console.Write("Word:");
        string word = Console.ReadLine();
        tami.Teach(word);
    }

    else if (doo == "2")
    {
        tami.Hi();
    }

    else if (doo == "3")
    {
        tami.Feed();
    }

    else
    {
        Console.WriteLine("Doing nothing.");
    }
    
    tami.Tick();
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

Console.WriteLine($"OH NO! {tami.Name} is dead!");
Console.WriteLine("Press enter then go jump off a bridge.");
Console.ReadLine();
