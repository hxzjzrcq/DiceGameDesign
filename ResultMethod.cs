using DiceGame.DiceTool;
namespace DiceGame
{
    internal static class ResultMethod
    {
        internal static DiceResult Roll100 ()
        {
            Dx D100 = new(1, 100);
            DiceResult result = new(D100.GetResult());
            return result;
        }
    }
}
