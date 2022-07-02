using DiceGame.Char;

namespace DiceGame
{
    internal static class DefaultChar
    {


        internal static CharCoc BulidDefaultChar0(CharCoc temp)
        {
            MakeChar.ReName(temp, "Alice");
            List<int> ints = new() { 75, 95, 95, 95, 95, 95, 95 };
            List<bool> job = new() { true, false, true };
            MakeChar.CocAbiInitialize(temp, ints);
            MakeChar.JobInitialize(temp, job);
            return temp;
        }







    }
}
