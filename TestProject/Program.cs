namespace TestProject;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 33;
        float myFloat = 8.263719F;
        bool pineappleBestFruit = true;
        string loveMe = "NOOOOOO";

        Console.WriteLine("I have " + myInt + " kids");
        Console.WriteLine("You look about " + myFloat + " years old");
        Console.WriteLine("Pineapple is the besst fruit:" + pineappleBestFruit);
        Console.WriteLine("Does the love me man" + loveMe);

        for (int i = 0; i < 20; i++) {
            Console.WriteLine("I ate " + i + " slices of pizza for lunch.\n");
        }
    }
}
