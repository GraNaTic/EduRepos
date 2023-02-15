using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontScreen
{
    abstract class Monster
    {
        private int x;

        private int y;

        private int weight;

        public Monster (int x, int y)
        {
            Random random = new Random();
            int weight = random.Next (0, 75);
            BeBorn(x, y, weight);
        }

        public void X(int arg)
        {
            x = arg;
        }

        public int X()
        {
            return x;
        }

        public void Y(int arg)
        {
            y = arg;
        }

        public int Y()
        {
            return y;
        }

        public void Weight(int arg)
        {
            weight = arg;
        }

        public int Weight()
        {
            return weight;
        }

        public void BeBorn( int x, int y, int weight)
        {
            X(x);
            Y(y);
            Weight(weight);
        }
    }

    class Dog: Monster
    {
        private ConsoleColor clr;

        private char face;

        public Dog ( int x, int y):base (x, y)
        {
            Face('@');
            if (Weight() > 55)
                Color(ConsoleColor.Magenta);
            else
                if (Weight() - 27>0)
                    Color(ConsoleColor.Yellow);
                else 
                    Color(ConsoleColor.DarkYellow);
        }

        public ConsoleColor Color()
        {
            return clr;
        }

        public void Color(ConsoleColor color)
        {
            clr = color;
        }

        public char Face()
        {
            return face;
        }

        public void Face(char arg)
        {
            face = arg;
        }
        
        public static Dog GetObj()
        {
            Random random = new Random();
            var dog = new Dog(random.Next(120), random.Next(1, 30));
            return dog;
        }
    }

    class Hedgehog : Dog
    {
        public Hedgehog(int x, int y) : base(x, y)
        {
            Face('Ж');
            Color(ConsoleColor.Gray);
        }
        new public static Hedgehog GetObj()
        {
            Random random = new Random();
            var hedgehog = new Hedgehog(random.Next(120), random.Next(1, 30));
            return hedgehog;
        }
    }
}
