Random rnd = new Random();

int RandomNumber = rnd.Next(0, 10); // Picks a number from 0-10

Console.WriteLine("Guess The Number From 0-10!");

int PickedNumber = Int32.Parse(Console.ReadLine()); // Converts the guess from string to int

if (RandomNumber == PickedNumber)
{
    Console.WriteLine("You Guessed The Number!");
}

else
{
    Console.WriteLine("You Didnt Guess the Correct Number!");
    Console.WriteLine("The Correct Number was " + RandomNumber);
}

