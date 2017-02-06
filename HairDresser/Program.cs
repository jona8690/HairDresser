using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairDresser
{
    class Program
    {
        Scissors one = new Scissors();
        Scissors two = new Scissors();
        Scissors three = new Scissors();
        Scissors four = new Scissors();
        Scissors five = new Scissors();
        Scissors six = new Scissors();

        HairDresser A = new HairDresser();
        HairDresser B = new HairDresser();
        HairDresser C = new HairDresser();
        HairDresser D = new HairDresser();
        HairDresser E = new HairDresser();
        HairDresser F = new HairDresser();


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {

        }
    }
}
