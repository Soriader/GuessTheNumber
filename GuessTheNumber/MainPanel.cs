namespace GuessTheNumber;

public class MainPanel
{
    public static GuessMethods GuessMethods = new GuessMethods();
    public string GuessUserPanel()
    {
        var userAnswer = Console.ReadLine();
        var correctAnswer = int.TryParse(userAnswer, out int number);
        int guessNumber = 0;
        
        if (!correctAnswer)
        {
            Console.WriteLine("Please enter a correct number from 1 to 1000");

            while (!GuessMethods.IsNotCorrectNumber(userAnswer))
            {
                userAnswer = Console.ReadLine();
            }
            
            guessNumber = int.Parse(userAnswer);
        }

        while (!GuessMethods.WinTheGame(guessNumber))
        {
            
        }
        
        return $"You win! The number for guess is {guessNumber}";
    }
}