namespace DiceGame
{
    internal static class GameStream
    {
        
       public static void StartTestSence0 (ActionChar actionChar,ActionScene actionScene)
        {
            
            actionChar.Player0 = DefaultChar.BulidDefaultChar0(actionChar.Player0);
            actionScene.Now = DefaultScene.BulidTest1(actionScene.Now);
           
        }

        public static bool CheckStr (ActionChar actionChar, ActionScene actionScene)
        { int i = ResultMethod.Roll100().Sum;
            i += actionChar.Player0.MyStr.BasedStr;
            if( i >= actionScene.Now.Encounter[0].Dc)
                return true;
            else
                return false;
        }

    }
}
