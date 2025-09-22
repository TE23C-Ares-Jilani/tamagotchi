tamagotchi tami = new();

int x = 1;


while (tami.GetAlive() == true)
{

    tami.PrintStats();

    Console.WriteLine("Write a word.");

    Console.Write("Word:");

    string word = Console.ReadLine();

    tami.Teach(word);

    tami.PrintStats();

}

