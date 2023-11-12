class Flower
{
    public static int pelcount = 7;
    public delegate void EventHandler();
    public static event EventHandler Event1;
    public static event EventHandler Event2;

    public static void GenEvents()
    {
        if (pelcount > 1)
        {
            pelcount--;
            Event1();
        }
        else
        {
            Event2();
        }
    }
}

class Girl
{
    private string[] list  = { "Хочу з тобою гратися", "Хочу з тобою бiгати", "Хочу з тобою пригати", "Хочу з тобою кататися на велосипедi", "Хочу з тобою плавати", "Хочу з тобою гуляти" };
    public void Event1()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(list[Flower.pelcount - 1]); 
    }

    public void Event2()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Бажаю щоб хлопчик одужав!");
    }
}

class Boy
{
    public void Event1()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Я не можу, я хворий");
    }

    public void Event2()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Ура! Я здоровий");
    }
}

class Program
{
    static void Main()
    {
        Flower flower = new Flower();
        Girl girl = new Girl();
        Boy boy = new Boy();

        Flower.Event1 += girl.Event1;
        Flower.Event2 += girl.Event2;
        Flower.Event1 += boy.Event1;
        Flower.Event2 += boy.Event2;

        for (int i = 0; i < 7; i++)
        {
            Flower.GenEvents();
        }
    }
}
