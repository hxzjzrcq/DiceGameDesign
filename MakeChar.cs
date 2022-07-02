using DiceGame.Char;

namespace DiceGame
{
    internal static class MakeChar //UI用这个类的方法新建角色
    {


        internal static CharCoc NewCoc(string name)//Charmaker.NewCoc方法
        {
            CharCoc NewCharCoc = new()
            {
                CharName = name
            };
            return NewCharCoc;

        }

        internal static CharCoc ReName(CharCoc temp, string name) //MakeChar.ReName
                                                                  //角色重命名方法

        {
            temp.CharName = name;
            return temp;

        }


        //这个方法可以一次性初始化角色。
        //但是，比较死板所以尽量不要修改，并只在角色做成或洗点时使用。

        internal static CharCoc CocAbiInitialize(CharCoc temp, List<int> abi)
        //MakeChar.CocAbiInitialize方法
        //传入int集合为角色对象初始化属性。不足的部分部位默认值，多者舍去。
        {
            if (abi.Count < Default.AbiNum)
            {
                for (int i = abi.Count; i <= Default.AbiNum; i++)
                {
                    abi.Add(Default.Abi);
                }
            }

            temp.MyStr.BasedStr = abi[0];
            temp.MyCon.BasedCon = abi[1];
            temp.MyDex.BasedDex = abi[2];

            temp.MyBrain.BasedBrain = abi[3];
            temp.MyPow.BasedPow = abi[4];
            temp.MyApp.BasedApp = abi[5];
            temp.MyEdu.BasedEdu = abi[6];

            return temp;

        }


        //---------------
        //单独设置各个属性
        //这里CharMaker.DexFix(charname, charname.MyDex.LevelUp(2)）是合法的

        internal static CharCoc StrFix(CharCoc temp, int i)//力量
        {
            temp.MyStr.BasedStr = i;
            return temp;
        }

        internal static CharCoc ConFix(CharCoc temp, int i)//体质
        {
            temp.MyCon.BasedCon = i;
            return temp;
        }

        internal static CharCoc DexFix(CharCoc temp, int i)//敏捷
        {
            temp.MyDex.BasedDex = i;
            return temp;
        }

        internal static CharCoc BrainFix(CharCoc temp, int i)//智力
        {
            temp.MyBrain.BasedBrain = i;
            return temp;
        }

        internal static CharCoc PowFix(CharCoc temp, int i)//意志
        {
            temp.MyPow.BasedPow = i;
            return temp;
        }

        internal static CharCoc AppFix(CharCoc temp, int i)//魅力
        {
            temp.MyApp.BasedApp = i;
            return temp;
        }

        internal static CharCoc EduFix(CharCoc temp, int i)//教育
        {
            temp.MyEdu.BasedEdu = i;
            return temp;
        }


        internal static CharCoc JobInitialize(CharCoc temp, List<bool> bools)
        //对job进行改动的方法。只能传入集合，因为单个改动是极为少见的。
        //这个方法需要随时维护，或者重构/加入新的方法。
        {

            if (bools.Count < Default.JobNum)
            {
                for (int i = bools.Count; i <= Default.JobNum; i++)
                {
                    bools.Add(false);
                }
            }

            temp.MyJob.Is00Female = bools[0];
            temp.MyJob.Is01Worker = bools[1];
            temp.MyJob.Is02Detective = bools[2];
            temp.MyJob.Is03Doctor = bools[3];
            temp.MyJob.Is04Artist = bools[4];
            temp.MyJob.Is05Fighter = bools[5];
            temp.MyJob.Is06Hacker = bools[6];
            temp.MyJob.Is07Librarian = bools[7];
            temp.MyJob.Is08Noble = bools[8];
            temp.MyJob.Is09Lawyer = bools[9];
            temp.MyJob.Is10Researcher = bools[10];
            temp.MyJob.Is11Soldier = bools[11];
            temp.MyJob.Is12Student = bools[12];
            temp.MyJob.Is13Homeless = bools[13];


            return temp;
        }

    }


}
