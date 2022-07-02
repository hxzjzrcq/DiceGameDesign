using DiceGame;
using static System.Console;
//internal修饰的方法或者属性，只要是在同一个程序集的中的其他类都可以访问
//如果二者不在同一命名空间，只要使用using引用上相应的命名空间即可
//这里，从另外一个方面也间接看出命名空间并不是界定访问级别的，而是保证全局的类唯一性的

ActionChar actionChar = new(MakeChar.NewCoc("Alice"));//建立人物

ActionScene actionScene = new(MakeScene.NewScene());//建立场景

GameStream.StartTestSence0(actionChar,actionScene);//初始化人物和场景

WriteLine(actionChar.Player0.CharName);
WriteLine(actionChar.Player0.MyStr.BasedStr);
WriteLine(actionScene.Now.Encounter[0].Dc);

while(true)
{
    bool b = GameStream.CheckStr(actionChar, actionScene);
    if (b == true)
    WriteLine("举起来了");

    else
    WriteLine("没举起来");

    ReadKey();


}


