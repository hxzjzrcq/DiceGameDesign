namespace DiceGame
{
    public static class Default
    {
        public static readonly string Name = "charname";
        public static readonly int Abi = 50;

        public static readonly int JobNum = 13;
        //注意！这个数据和Job类强相关！直接反映了Job当前版本的判断数目！
        //每次增加新的判断，都需要调整这里的数值，使其相当于Job类中bool的总数目！
        //CharMaker也要做出相应的修改。

        public static readonly int AbiNum = 7;//不应该修改这个值




    }
}
