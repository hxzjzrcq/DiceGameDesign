namespace DiceGame.DiceTool
   
{
    class Dice//本程序2种方式得到表示骰子得点的集合List<int>。
              //1，直接使用静态方法Dice.Roll。2，通过实例化的Dx对象运行GetResult方法。

    {   
        public static List<int> Roll(int a, int b)//静态方法，Roll(骰子数，骰子面数）
        {
            List<int> List = new();
            Random Rnd = new();//初始化

            if (a < 1) a = 1;
            if (b < 1) b = 1; //ab不小于1


            for (int i = 1; i <= a; i++)//连续丢出a个骰子
            {
                int j = Rnd.Next(1, b + 1);//骰子面数为b，丢一次骰子，得数为j
                List.Add(j);//把骰子得数添加到List集合
            }

            return List;//返回包括所有骰子结果的int集合

        }

    }

}

