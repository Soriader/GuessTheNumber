namespace GuessTheNumber;

public class GuessMethods
{
    public int RandomNumberCreator()
    {
        return new Random().Next(1, 1001);
    }

    public bool WinTheGame(int winNumber, int guessNumber)
    {
        if (winNumber > guessNumber)
        {
            SoClose(winNumber, guessNumber);
            Console.WriteLine("Your number is too low!");
            return false;
        }
        else if (winNumber < guessNumber)
        {
            SoClose(winNumber, guessNumber);
            Console.WriteLine("Your number is too high!");
            return false;
        }

        return true;
    }

    private bool SoClose(int winNumber, int guessNumber)
    {
        if (winNumber > guessNumber && winNumber - guessNumber <= 20)
        {
            Console.WriteLine("Your score is too low, but you're very close!");
            return false;
        }
        else if (winNumber < guessNumber && guessNumber - winNumber <= 20)
        {
            Console.WriteLine("Your score is too high, but you're very close!");
            return false;
        }
        
        return true;
    }
}