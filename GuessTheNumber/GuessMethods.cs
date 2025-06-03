namespace GuessTheNumber;

public class GuessMethods
{
    private readonly int _winNumber;

    public GuessMethods()
    {
        _winNumber = new Random().Next(1, 1001);
    }

    public bool IsGuessCorrect(int guessNumber)
    {
        if (_winNumber == guessNumber)
        {
            return true;
        }
        
        if (Math.Abs(_winNumber - guessNumber) <= 20)
        {
            Console.WriteLine(_winNumber > guessNumber 
                ? "Your number is too low, but you're very close!" 
                : "Your number is too high, but you're very close!");
        }
        else
        {
            Console.WriteLine(_winNumber > guessNumber 
                ? "Your number is too low!" 
                : "Your number is too high!");
        }
        
        return false;
    }

    private bool IsGuessClose(int winNumber, int guessNumber)
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

    public bool ProcessGuess(string guessNumber)
    {
        int answer = IsNotCorrectNumber(guessNumber);
        
        if (answer == -1)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 1000.");
            return false;
        }
        
        return IsGuessCorrect(answer);
    }
    

    public int IsNotCorrectNumber(string userAnswer)
    {
        if (int.TryParse(userAnswer, out int number) && number >= 1 && number <= 1000)
        {
            return number;
        }   
        
        return -1;
    }
    
}