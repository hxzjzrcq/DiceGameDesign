using DiceGame.Char;

namespace DiceGame
{
    internal class ActionChar
    {
        CharCoc player0 = new();

        internal CharCoc Player0 { get => player0; set => player0 = value; }

        internal ActionChar(CharCoc charCoc)
        {
            Player0 = charCoc;
        }



    }
}
