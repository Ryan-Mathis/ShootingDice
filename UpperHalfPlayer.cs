namespace ShootingDice;
// TODO: Complete this class

// A Player whose role will always be in the upper half of their possible rolls
public class UpperHalfPlayer : Player
{
    
    public override int Roll()
    {
        int randomNumber = new Random().Next(DiceSize) + (DiceSize / 2);
        while (randomNumber > DiceSize || randomNumber == (DiceSize / 2))
        {
            randomNumber = new Random().Next(DiceSize) + (DiceSize / 2);
        }
        // Return a random number between 1 and DiceSize
        return randomNumber;
    }
}