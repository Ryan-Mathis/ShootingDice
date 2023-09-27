namespace ShootingDice;
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    public string Taunt { get; } = "I'm gonna win this one sucker!";

    public override int Roll()
    {
        Console.WriteLine($"{Taunt}");
        // Return a random number between 1 and DiceSize
        return new Random().Next(DiceSize) + 1;
    }
}