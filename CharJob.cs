namespace DiceGame.Char
{
    internal class CharJob //这个类用于存储角色的bool值。主要是职业，也有性别等。
                     //默认均为false。
                     //注意！
                     //本类的更新需要反映在Defalut中。
                     //这里有多少个bool就要有多少个Default.JobNum！
                     //CharMaker也要做出相应的修改。

    {



        //性别。默认男性。
        private bool is00Female = false;

        internal bool Is00Female { get => is00Female; set => is00Female = value; }

        //职业标签：工人。
        internal bool is01Worker = false;

        internal bool Is01Worker { get => is01Worker; set => is01Worker = value; }

        //侦探
        internal bool is02Detective = false;

        internal bool Is02Detective { get => is02Detective; set => is02Detective = value; }

        //医生
        private bool is03Doctor = false;

        internal bool Is03Doctor { get => is03Doctor; set => is03Doctor = value; }

        //艺术家
        private bool is04Artist = false;

        internal bool Is04Artist { get => is04Artist; set => is04Artist = value; }

        //格斗家
        private bool is05Fighter = false;

        internal bool Is05Fighter { get => is05Fighter; set => is05Fighter = value; }

        //程序员
        private bool is06Hacker = false;

        internal bool Is06Hacker { get => is06Hacker; set => is06Hacker = value; }

        //图书馆员
        private bool is07Librarian = false;

        internal bool Is07Librarian { get => is07Librarian; set => is07Librarian = value; }

        //贵族
        private bool is08Noble = false;

        internal bool Is08Noble { get => is08Noble; set => is08Noble = value; }

        //律师
        private bool is09Lawyer = false;

        internal bool Is09Lawyer { get => is09Lawyer; set => is09Lawyer = value; }


        //研究员
        private bool is10Researcher = false;

        internal bool Is10Researcher { get => is10Researcher; set => is10Researcher = value; }


        //士兵
        private bool is11Soldier = false;

        internal bool Is11Soldier { get => is11Soldier; set => is11Soldier = value; }


        //学生
        private bool is12Student = false;

        internal bool Is12Student { get => is12Student; set => is12Student = value; }

        //无家可归者
        private bool is13Homeless = false;

        internal bool Is13Homeless { get => is13Homeless; set => is13Homeless = value; }

    }
}
