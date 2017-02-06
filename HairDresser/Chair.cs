using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HairDresser
{
    class Chair
    {
        private Random random = new Random();

        public Scissors left { get; set; }
        public Scissors right { get; set; }
        public string Name { get; set; }

        public Chair(Scissors left, Scissors right, string name)
        {
            this.left = left;
            this.right = right;
            this.Name = name;
        }

        private int Period = 0;

        private bool hasLeft = false;
        private bool hasRight = false;

        public void CutHair()
        {
            while (Period < 10)
            {
                if (Monitor.TryEnter(left.locker))
                {
                    hasLeft = true;
                }
                else hasLeft = false;

                if (Monitor.TryEnter(right.locker))
                {
                    hasRight = true;
                }
                else hasRight = false;

                if (hasLeft && hasRight)
                {
                    Console.WriteLine("Hair dresser " + Name + " is cutting!");
                    this.Period++;
                }

                if (hasLeft && !hasRight)
                {
                    Monitor.Exit(left.locker);
                    hasLeft = false;
                }

                if (!hasLeft && hasRight)
                {
                    Monitor.Exit(right.locker);
                    hasRight = false;
                }

                Thread.Sleep(random.Next(100, 600));

                //if (this.Period != 10)
                //{
                //    Console.WriteLine("Hair dresser" + Name + "is taking a break!");
                //    ReleaseLocks();
                //    Thread.Sleep(random.Next(100, 600));
                //}
            }
            Console.WriteLine("Hair dresser " + Name + " is going home!");
            ReleaseLocks();
        }

        private void ReleaseLocks()
        {
            Monitor.Exit(left.locker);
            hasLeft = false;

            Monitor.Exit(right.locker);
            hasRight = false;
        }
    }
}
