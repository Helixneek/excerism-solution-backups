public class Player
{
    Random rand = new();
    
    public int RollDie() => rand.Next(1, 19);

    public double GenerateSpellStrength() => rand.NextDouble() * 100;
}
