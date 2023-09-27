namespace ShootingDice;
// TODO: Complete this class

// A Player who always rolls in the upper half of their possible role and
//  who throws an exception when they lose to the other player
public class SoreLoserUpperHalfPlayer : SoreLoserPlayer 
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