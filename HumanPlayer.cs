namespace ShootingDice;

// TODO: Complete this class

// A player the prompts the user to enter a number for a roll
public class HumanPlayer : Player
{

        public override int Roll()
    {
        Console.WriteLine("Please enter your roll:");
        // Return a random number between 1 and DiceSize
        return Int32.Parse(Console.ReadLine());
    }
}