namespace DiceGame.Scenario
{
    internal class Scene
    {
        private List<int> date=new();
        private List<Checker> encounter=new();

        internal List<int> Date { get => date; set => date = value; }
        internal List<Checker> Encounter { get => encounter; set => encounter = value; }

        public Scene()
        {
            Date.Add(0);//占位
            //int表需要认真设计，表示场景的属性表
        }
    }
}
