namespace GuessTheNumber;

public class GuessMethods
{
    private readonly int _winNumber;

    public GuessMethods()
    {
        _winNumber = new Random().Next(1, 1001);
    }

    public bool WinTheGame(int guessNumber)
    {
        if (_winNumber > guessNumber)
        {
            VeryClose(_winNumber, guessNumber);
            Console.WriteLine("Your number is too low!");
            return false;
        }
        else if (_winNumber < guessNumber)
        {
            VeryClose(_winNumber, guessNumber);
            Console.WriteLine("Your number is too high!");
            return false;
        }

        return true;
    }

    private bool VeryClose(int winNumber, int guessNumber)
    {
        if (winNumber > guessNumber && winNumber - guessNumber <= 20)
        {
            Console.WriteLine("Your score is too low, but you're very close!");
            return true;
        }
        else if (winNumber < guessNumber && guessNumber - winNumber <= 20)
        {
            Console.WriteLine("Your score is too high, but you're very close!");
            return true;  
        }
        
        return false;
    }

    public bool IsNotCorrectNumber(string userAnswer)
    {
        if(int.TryParse(userAnswer, out int number) && int.Parse(userAnswer) >= 1 && int.Parse(userAnswer) <= 1000)
        {
            return true;
        }
        
        return false;
    }
}