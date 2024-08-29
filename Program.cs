namespace demo_console_app;
class Program
{



    public static async Task Main()
    {
        // returning value from async method
        // int result = await CalculateAsync(10, 10, '+');
        // Console.WriteLine(result);

        // async method with no return value
        // await PrintMessage();

        // handling exception with async method
        // try{
        //     int result = await DivideAsync(10,0);
        //     Console.WriteLine(result);

        // }
        // catch(DivideByZeroException ex)
        // {
        //     Console.WriteLine($"caught exception: {ex.Message}");

        // }

        // asynchornous foreach loop
        // int[] numbers = {1,2,3,4,5,6};
        // Task[] tasks = Array.ConvertAll(numbers,async num=>await ProcessNumberAsync(num));
        // await Task.WhenAll(tasks);

        // avoid using async void use async Task
        // await ProccessAsync("Hello world!");

        // making asynchronous http request
        // using(HttpClient client= new HttpClient()){
        //     // asynchronous get request
        //     string content = await client.GetStringAsync("https://fakestoreapi.com/products/7");
        //     Console.WriteLine(content);

        // }
        



    }

    // avoid using async void use async Task
    // public static async Task ProccessAsync(string Message){
    //     await Task.Delay(1000);
    //     Console.WriteLine(Message);
    // }

    // async foreach loop
    // public static async Task ProcessNumberAsync(int number){
    //     await Task.Delay(1000);
    //     Console.WriteLine($"process number: {number}");
    // }

    // handling exception with async method
    // public static async Task<int> DivideAsync(int a, int b){
    //     await Task.Delay(1000);
    //     return a/b; // this will return DivideByZeroException if b=0
    // }


    // async method with no return value
    // public static async Task PrintMessage(){
    //     await Task.Delay(1000);
    //     Console.WriteLine("Hello world!");
    // }


    // returning value from async method
    // public static async Task<int> CalculateAsync(int a, int b, char operatorChar)
    // {
    //     await Task.Delay(0);
    //     if (operatorChar == '+')
    //     {
    //         return a + b;

    //     }
    //     else if (operatorChar == '-')
    //     {
    //         return a - b;
    //     }
    //     else if (operatorChar == '*')
    //     {
    //         return a * b;
    //     }
    //     else if (operatorChar == '/')
    //     {
    //         if (b == 0)
    //         {
    //             throw new DivideByZeroException("can not divide by 0");
    //         }
    //         return a / b;
    //     }

    //     else
    //     {
    //         throw new InvalidOperationException("invalid operator");
    //     }

    // }



}
