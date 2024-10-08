namespace MethodsDemoCSharp_51;

class Program
{
    //Create method here
    
    public static void Main(string[] args)
    { 
        //Void return type method
        //Console.WriteLine("Hello, World!");

        //String return type method (non void)
        //string userResponse = Console.ReadLine();
        
        //Calling a method (using a method)
        GreetPerson("Seth");
        GreetPerson("Cruz");

        int twoPlusTwo = AddTwoNumbers(2, 2);

        Console.WriteLine(twoPlusTwo);
        
        GetUserNameAndGreet();
    }
    
    //Or create the method here
    //Method definition (creating a method)
    //Pascal casing for methods
    public static void GreetPerson(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static int AddTwoNumbers(int numOne, int numTwo)
    {
        // int sum = numOne + numTwo;
        //
        // return sum;

        return numOne + numTwo;
        Console.WriteLine("Hello");
    }

    public static void GetUserNameAndGreet()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
