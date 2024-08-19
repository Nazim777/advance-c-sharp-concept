namespace demo_console_app;
class Program
{
    // declare a delegate type
    // public delegate void PrintDelegate(string message);
    // method that matches the delegate signature
    // public static void PrintMessaage(string message){
    //     Console.WriteLine(message);

    // }

// multicast delegate
    // public static void PrintMessage1(string message){
    //     Console.WriteLine("message 1 " + message);
    // }
    // public static void PrintMessage2(string message){
    //     Console.WriteLine("message 2 " + message);
    // }

// using delegate as parameter(Callbacks)
    // public delegate void ProcessDelegate(int num);
    // public static void ProcessNumber(int num,ProcessDelegate process){
    //     process(num);
    // }
    // public static void PrintSquare(int num){
    //     Console.WriteLine("The Square is "+ (num*num));
    // }
    // public static void PrintCube(int num){
    //     Console.WriteLine("The Cube is "+(num*num*num));
    // }

    // delegates with lambda expression
    // public delegate int MathCalculations(int a,int b);
   



    static void Main(string[] args)
     {
        // instantiate the delegate
        // PrintDelegate del = PrintMessaage;
        // invoke the delegate
        // del("Hello, Delegate!");

        // multicast delegate
        // PrintDelegate del = PrintMessage1;
        // del = del + PrintMessage2; // multicast the delegate
        // del("Hello Delegates !");

        // using delegate as parameter(Callbacks)
        // ProcessNumber(2,PrintSquare);
        // ProcessNumber(3,PrintCube);

        // delegate with lambda expression
    //     MathCalculations add=(int a,int b)=>a+b;
    //    Console.WriteLine(add(10,10));
    //    MathCalculations multiply=(int a, int b)=>a*b;
    //    Console.WriteLine(multiply(10,10));

    // built-in delegates
    // Action delegate (no return type)
    // Action<string> Print=message=>Console.WriteLine(message);
    // Print("Hello Action delegate");

    // Func delegate return a value
//     Func<int,int,int,int> add=(a,b,c)=>a+b+c;
//     Console.WriteLine(add(1,2,3));
//    Func<string,string> PrintHello=(message)=>message;
//    Console.WriteLine(PrintHello("Hello from Func delegate"));

// predicate delegate return a boolean
// Predicate<int> checkIsEven=(a)=>a%2==0;
// Console.WriteLine(checkIsEven(4));
// Console.WriteLine(checkIsEven(99));


   
    
    }

}
