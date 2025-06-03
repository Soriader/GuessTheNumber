namespace GuessTheNumber;

public class MainPanel
{
    public static GuessMethods GuessMethods = new GuessMethods();
    public static void GuessUserPanel()
    {
        Console.WriteLine($"Welcome in game - Guess a number\nPlease enter the number you would like to guess");

        var userAnswer = Console.ReadLine();
        
        while (!GuessMethods.ProcessGuess(userAnswer))
        {
            userAnswer = Console.ReadLine();
        };

        Console.WriteLine($"You win! The number you had to guess was: {userAnswer}");
    }
}