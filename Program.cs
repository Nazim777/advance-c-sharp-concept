namespace demo_console_app;
class Program
{

    
    
    static void Main(string[] args)
     {
    //     // linq with wide example and explanations
    //     var numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};
    //     // list of even numbers
    //    var evennumbers = numbers.Where(n=>n%2==0);
    //    foreach(var num in evennumbers){
    //     Console.WriteLine(num);
    //    }

    //    //list of odd numbers
    //    var oddnumbers = numbers.Where(n=>n%2==1);
    //    foreach(var num in oddnumbers){
    //     Console.WriteLine(num);
    //    }

    // filtering with Where
    // var words = new List<string>{"apple", "banana", "cherry", "date", "elderberry"};
    // var wordWithB = words.Where(w=>w.StartsWith("b"));
    // foreach(var word in wordWithB){
    //     Console.WriteLine(word);
    // }


    // joining the data with join method
    // var people = new List<Person>{
    //     new Person{Id=1,Name="Ali"},
    //     new Person{Id=2,Name="Bob"},
    //     new Person{Id=3,Name="Sam"}
    // };
    // var Orders = new List<Order>{
    //     new Order{PersonId=1,Product="Mobile"},
    //     new Order{PersonId=2,Product="HeadPhone"},
    //     new Order{PersonId=3,Product="Tablet"}
    // };

    // accessing the each item of people list
    // foreach(Person person in people){
    //     Console.WriteLine($"Id-{person.Id}: Name-{person.Name}");
    // }

    // join the two list
    // var personOrders = people.Join(Orders,
    //                                person=>person.Id,
    //                                order=>order.PersonId,
    //                                (person,order)=>new {person.Name,order.Product});

    // foreach(var personOrder in personOrders){
    //     Console.WriteLine($"{personOrder.Name} ordered {personOrder.Product}");
    // }

    // // aggregation with sum count,max,min ,agerage 
    // var numbers = new List<int>{1,2,3,4};
    // var sum = numbers.Sum();
    // Console.WriteLine($"sum {sum}");
    // var max = numbers.Max();
    // Console.WriteLine($"max {max}");
    // var min = numbers.Min();
    // Console.WriteLine($"min {min}");
    // var average = numbers.Average();
    // Console.WriteLine($"agerage {average}");
    // var count = numbers.Count();
    // Console.WriteLine($"count {count}");

    // sorting with OrderBy and ThenBy
    // var students = new List<Student>{
    //     new Student { Name="Avis",Grade="B"},
    //     new Student { Name = "Charlie", Grade = "C" },
    //     new Student { Name = "Bob", Grade = "C" },
    //     new Student { Name = "David", Grade = "A" }
    // };
    // var sortedStudent = students.OrderBy(s=>s.Grade).ThenBy(s=>s.Name);
    // foreach(var student in sortedStudent){
    //     Console.WriteLine($"{student.Name} - {student.Grade}");
    // }

    // quantifiers with All, Any, and Contains
    // it will check the true or false
    // var numbers = new List<int>{1,2,3,4,5,6};
    // bool hasNumberGreateThanFour = numbers.Any(x=>x>4);
    // Console.WriteLine(hasNumberGreateThanFour);
    // bool allNumbersArePositive =numbers.All(x=>x>0);
    // Console.WriteLine(allNumbersArePositive);
    // bool contansThree = numbers.Contains(3);
    // Console.WriteLine(contansThree);

    
     


    }

    public sealed class Person{
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public sealed class Order{
        public int PersonId { get; set; }
        public string Product { get; set; }
    }
    public sealed class Student{
        public string Name { get; set; }
        public string Grade { get; set; }
    }
}
