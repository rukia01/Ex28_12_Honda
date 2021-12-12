using System;
using ConsoleUtility;

namespace Ex28_12_Honda
{
    class Ex28
    {
        static void Main(string[] args)
        {
            CraneTurtle craneTurtle = new CraneTurtle(2, 4);
            craneTurtle.SetHeadsLegs(5, 16);
            Console.WriteLine($"鶴の数は{craneTurtle.headsA}羽"); //2で正解
            Console.WriteLine($"亀の数は{craneTurtle.headsB}匹"); //3で正解
            craneTurtle.heads = 7;  //頭や足の数を変えても答えが出る
            Console.WriteLine($"鶴の数は{craneTurtle.headsA}羽"); //6で正解
            Console.WriteLine($"亀の数は{craneTurtle.headsB}匹"); //1で正解
            craneTurtle.legs = 20;
            Console.WriteLine($"鶴の数は{craneTurtle.headsA}羽"); //4で正解
            Console.WriteLine($"亀の数は{craneTurtle.headsB}匹"); //3で正解
            CraneTurtle craneTurtle1 = new CraneTurtle(8, 10);
            craneTurtle1.SetHeadsLegs(7, 66);
            Console.WriteLine($"タコの数は{craneTurtle1.headsA}匹");
            Console.WriteLine($"イカの数は{craneTurtle1.headsB}匹");
            craneTurtle1.heads = 10;
            craneTurtle1.legs = 86;
            Console.WriteLine($"タコの数は{craneTurtle1.headsA}匹");
            Console.WriteLine($"イカの数は{craneTurtle1.headsB}匹");
        }
    }
}
