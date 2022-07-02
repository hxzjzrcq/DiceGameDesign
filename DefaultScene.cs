using DiceGame.Scenario;

namespace DiceGame
{
    internal static class DefaultScene
    {
        internal static Scene BulidTest1(Scene temp)
        {
            Checker temp0 = new(100);
            temp.Encounter.Add(temp0);//str
            temp.Encounter.Add(temp0);//con
            temp.Encounter.Add(temp0);//dex

            return temp;

        }
    }


}
