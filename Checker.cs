namespace DiceGame.Scenario
{
    internal class Checker
    {
        private int dc=new();
        private  List<bool> flag=new();

        internal int Dc { get => dc; set => dc = value; }
        internal List<bool> Flag { get => flag; set => flag = value; }

        internal Checker(int dc)
        {
            Dc = dc;
            Flag.Add(false);//[0]是否首次激活判断
            Flag.Add(false);//[1]是否可以再次判断
            Flag.Add(false);//[2]是否判断成功

        }

       
    }
}
