tamagotchi tami = new();

int x = 1;

while (x == 1)
{

    tami.PrintStats();

    Console.WriteLine("Write a word.");

    Console.Write("Word:");

    string word = Console.ReadLine();

    tami.Teach(word);

    tami.PrintStats();

}

