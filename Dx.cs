namespace DiceGame.DiceTool
{
    public class Dx//基本的骰子对象。这个类依赖于Dice类运作。
    {
        public Dx(int i, int j)//构造函数。自定义骰子的数量和面数。

        {
            DiceNumber = i;
            DiceType = j;
        }

        public Dx(int i)//重载。构造函数只有一个参数时，骰子数固定为1
        {
            DiceType = i;
            DiceNumber = 1;
        }

        //字段和属性
        private int diceType;
        private int diceNumber;

        public int DiceType
        {
            get => diceType;
            set => diceType = value < 1 ? 1 : value;
        }//两个属性至少为1

        public int DiceNumber
        {
            get => diceNumber;
            set => diceNumber = value < 1 ? 1 : value;
        }

        public List<int> GetResult()//生成骰子数结果副本的方法
        {
            return Dice.Roll(DiceNumber, DiceType);
        }

    }
}