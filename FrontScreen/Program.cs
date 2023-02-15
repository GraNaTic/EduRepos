using FrontScreen;

class Program
{
    public static void Main()
    {
        
        for (int i = 0; i < 150; i++)
        {                        
            TypeDogOrHedg(Dog.GetObj());
            TypeDogOrHedg(Hedgehog.GetObj());            
        }
        Console.SetCursorPosition(0, 31);
        Console.Clear();
        TypeListDogs();
    }
    public static void TypeDogOrHedg(Dog dog)
    {
        Console.SetCursorPosition(dog.X(), dog.Y());
        Console.ForegroundColor = dog.Color();
        Console.Write(dog.Face());
        //Thread.Sleep(1);
    }


    public static void TypeListDogs()
    {
        Random random = new Random();
        List <Dog> dogs = new List <Dog>();
        for (int i = 0; i < 75; i++)
        {
            dogs.Add(Dog.GetObj());
        }
        while (true)
        {            
            foreach (var dog in dogs)
            {
                Console.SetCursorPosition(dog.X(), dog.Y());
                //Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");                
                if (dog.Y() + 1 < 31)
                    dog.Y(dog.Y() + 1);
                else
                {
                    dog.Y(1);
                    dog.X(random.Next(120));
                }
                Console.SetCursorPosition(dog.X(), dog.Y());
                //Console.BackgroundColor = ConsoleColor.DarkRed;
                TypeDogOrHedg(dog);                
            }
            Thread.Sleep(100);
        }
    }
}
