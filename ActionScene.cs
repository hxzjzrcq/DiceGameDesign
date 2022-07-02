using DiceGame.Scenario;

namespace DiceGame
{
    internal class ActionScene
    {
        private Scene now = new();


        internal Scene Now { get => now; set => now = value; }

        internal ActionScene(Scene scene)
        {
            Now = scene;
        }


    }
}
