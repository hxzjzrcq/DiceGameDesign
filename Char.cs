namespace DiceGame.Char
{
    internal class Char//角色基类
    {
        private string charName = Default.Name;//角色名字段初始量
        internal string? CharName { get => charName; set => charName = value ?? Default.Name; }

       

        //实现构造函数，封装属性并处理null
        internal Char(string charName)
        {
            CharName = charName;
        }

        internal Char()
        {
            CharName = Default.Name;
        }

    }

    internal class CharCoc : Char

    {
        //属性组
        //属性类自带保护



        internal Str MyStr { get => myStr; set => myStr = value; }
        internal Con MyCon { get => myCon; set => myCon = value; }
        internal Dex MyDex { get => myDex; set => myDex = value; }
        internal Brain MyBrain { get => myBarin; set => myBarin = value; }
        internal Pow MyPow { get => myPow; set => myPow = value; }
        internal App MyApp { get => myApp; set => myApp = value; }
        internal Edu MyEdu { get => myEdu; set => myEdu = value; }


        private Str myStr = new();

        private Con myCon = new();

        private Dex myDex = new();

        private Brain myBarin = new();

        private Pow myPow = new();

        private App myApp = new();

        private Edu myEdu = new();


        //职业（判断）组

        private CharJob myJob = new();
        internal CharJob MyJob { get => myJob; set => myJob = value; }

    }
}
