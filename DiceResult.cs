namespace DiceGame.DiceTool
{
    public class DiceResult//反映骰子结果的对象。
                           //这个类不依赖任何类运作。实例化后，用来保存Dx类产生的整数集合。

    {
        public DiceResult(List<int> ints)//构造函数。传入整数集合。
        {
            ThisResult = ints;

            int sum = 0;

            foreach (int temp in ints)
            {
                sum += temp;
            }
            Sum = sum;
        }
        //字段和方法
        private List<int> thisResult = new();


        public List<int> ThisResult { get => thisResult; set => thisResult = value; }

        public int Sum;

      

    }
}
