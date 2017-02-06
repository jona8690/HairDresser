using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HairDresser
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Scissors one = new Scissors();
            Scissors two = new Scissors();
            Scissors three = new Scissors();
            Scissors four = new Scissors();
            Scissors five = new Scissors();
            Scissors six = new Scissors();

            Chair A = new Chair(six, one,"A");
            Chair B = new Chair(one, two,"B");
            Chair C = new Chair(two, three,"C");
            Chair D = new Chair(three, four,"D");
            Chair E = new Chair(four, five,"E");
            Chair F = new Chair(five, six,"F");

            Thread hairDresserA = new Thread(A.CutHair);
            Thread hairDresserB = new Thread(B.CutHair);
            Thread hairDresserC= new Thread(C.CutHair);
            Thread hairDresserD = new Thread(D.CutHair);
            Thread hairDresserE = new Thread(E.CutHair);
            Thread hairDresserF = new Thread(F.CutHair);

            hairDresserA.Start();
            hairDresserB.Start();
            hairDresserC.Start();
            hairDresserD.Start();
            hairDresserE.Start();
            hairDresserF.Start();

            hairDresserA.Join();
            hairDresserB.Join();
            hairDresserC.Join();
            hairDresserD.Join();
            hairDresserE.Join();
            hairDresserF.Join();

            Console.WriteLine("\nAll the hairdressers has gone home...");
            Console.ReadKey();

        }


    }
}
