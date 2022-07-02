namespace DiceGame.Char
{
    internal interface ICharAbility
    {

        internal int LevelUp(int i)
        {
            return i;
            //所有能力值共享的能力：升级。
        }

    }


    //力量
    internal class Str : ICharAbility
    {
        int basedStr = Default.Abi;//初始化默认值

        internal int BasedStr { get => basedStr; set => basedStr = value >= 0 ? value : 1; }
        //大于0
        internal Str(int based)
        //构造函数。
        //但是，尽量使用无参构造函数然后利用其他类赋值。
        {
            BasedStr = based;
        }

        internal Str()//无参构造函数
        {
            BasedStr = Default.Abi;
        }

        internal int LevelUp(int i)//升级方法

        {
            BasedStr += i;
            return BasedStr;
        }

    }

    //体质
    internal class Con : ICharAbility
    {
        int basedCon = Default.Abi;//初始化默认值

        internal int BasedCon
        {
            get => basedCon;
            set => basedCon = value >= 0 ? value : 1;
        }
        //大于0
        internal Con(int based)//构造函数
        {
            BasedCon = based;
        }

        internal Con()//无参构造函数
        {
            BasedCon = Default.Abi;
        }

        internal int LevelUp(int i)//升级方法

        {
            BasedCon += i;
            return BasedCon;
        }

    }
    //敏捷
    internal class Dex : ICharAbility
    {
        int basedDex = Default.Abi;//初始化默认值

        internal int BasedDex
        {
            get => basedDex;
            set => basedDex = value >= 0 ? value : 1;
        }
        //大于0
        internal Dex(int based)//构造函数
        {
            BasedDex = based;
        }

        internal Dex()//无参构造函数
        {
            BasedDex = Default.Abi;
        }

        internal int LevelUp(int i)//升级方法

        {
            BasedDex += i;
            return BasedDex;
        }

    }
    //智力。因为int潜在的关键词冲突用Brain命名。
    internal class Brain : ICharAbility
    {
        int basedBrain = Default.Abi;//初始化默认值

        internal int BasedBrain
        {
            get => basedBrain;
            set => basedBrain = value >= 0 ? value : 1;
        }
        //大于0
        internal Brain(int based)//构造函数
        {
            BasedBrain = based;
        }

        internal Brain()//无参构造函数
        {
            BasedBrain = Default.Abi;
        }

        internal int LevelUp(int i)//升级方法

        {
            BasedBrain += i;
            return BasedBrain;
        }

    }
    //意志
    internal class Pow : ICharAbility
    {
        int basedPow = Default.Abi;//初始化默认值

        internal int BasedPow
        {
            get => basedPow;
            set => basedPow = value >= 0 ? value : 1;
        }
        //大于0
        internal Pow(int based)//构造函数
        {
            BasedPow = based;
        }

        internal Pow()//无参构造函数
        {
            BasedPow = Default.Abi;
        }

        internal int LevelUp(int i)//升级方法

        {
            BasedPow += i;
            return BasedPow;
        }

    }

    //魅力。因为和Char缩写相近用App（外貌）命名。
    internal class App : ICharAbility
    {
        int basedApp = Default.Abi;//初始化默认值

        internal int BasedApp
        {
            get => basedApp;
            set => basedApp = value >= 0 ? value : 1;
        }
        //大于0
        internal App(int based)//构造函数
        {
            BasedApp = based;
        }

        internal App()//无参构造函数
        {
            BasedApp = Default.Abi;
        }

        internal int LevelUp(int i)//升级方法

        {
            BasedApp += i;
            return BasedApp;
        }

    }

    //教育，也表示知识
    internal class Edu : ICharAbility
    {
        int basedEdu = Default.Abi;//初始化默认值

        internal int BasedEdu
        {
            get => basedEdu;
            set => basedEdu = value >= 0 ? value : 1;
        }
        //大于0
        internal Edu(int based)//构造函数
        {
            BasedEdu = based;
        }

        internal Edu()//无参构造函数
        {
            BasedEdu = Default.Abi;
        }

        internal int LevelUp(int i)//升级方法

        {
            BasedEdu += i;
            return BasedEdu;
        }

    }

}


