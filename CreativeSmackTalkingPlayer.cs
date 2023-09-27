namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
{
    public List<string> TauntList { get; set; } = new List<string>()
    {
        "I'm the best there ever was!",
        "I always win!",
        "I'm gonna win this one sucker!",
        "You're trash!",
        "GIVE SCRAP!"
    };

    public override int Roll()
    {
        int RandomNumber = new Random().Next(4);
        Console.WriteLine($"{TauntList[RandomNumber]}");
        return new Random().Next(DiceSize) + 1;
    }
}