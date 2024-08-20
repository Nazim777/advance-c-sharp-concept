namespace demo_console_app;

class Program
{

    
    
    static void Main(string[] args)
     {
        // Publisher publisher = new Publisher();
        // Subscriber subscriber = new Subscriber();

        // // Subscribe to the event
        // publisher.NotifyEvent +=  subscriber.OnNotify;


        // // trigger the event
        // publisher.ExecuteSomething();


        // event with EventHandler and EventArgs
        // Publisher publisher = new Publisher();
        // Subscriber subscriber = new Subscriber();
        // // subscribe the event 
        // publisher.MyEvent +=subscriber.OnEventReceived;

        // // trigger the event
        // publisher.TriggerEvent();


        // custom event argument
        // Publisher publisher = new Publisher();
        // Subscriber subscriber = new Subscriber();
        // // subcribe the event
        // publisher.MyEvent += subscriber.OnEventReceived;

        // // trigger event
        // publisher.TriggerEvent("Hello from custom event!");



        // multiple event subscriber
        Publisher publisher = new Publisher();
        SubscriberX subscriberx = new SubscriberX();
        SubscriberY subscribery = new SubscriberY();

        // subscribe the multiple event

        publisher.MyEvent += subscriberx.OnEventReceived;
        publisher.MyEvent += subscribery.OnEventReceived;

        // unsubscribe the event (No output since subscriber is unsubscibed)
        // publisher.MyEvent -= subscriberx.OnEventReceived;
        // publisher.MyEvent -= subscribery.OnEventReceived;

        // trigger the event 
        publisher.TriggerEvent("Habib Islam","Teacher","Bangladesh","Hello from Custom Event!");



        



       
      
    

    }

   
}

// public class Publisher{
//     // declare the delegate
//     public delegate void NotifyDelegate(string message);
//     // declare the event
//     public event NotifyDelegate NotifyEvent;
//     public void ExecuteSomething(){
//         // check if there are any subscripber
//         if(NotifyEvent != null){
//             NotifyEvent("The event has been triggered!");

//         }
//     }
// }

// public class Subscriber{
//     public void OnNotify(string meessage){
//         Console.WriteLine("message received "+ meessage);
//     }
// }




// event with EventHandler and EventArgs
// public class Publisher {

//     // declare a event handler with built-in event-delegate
//     public event EventHandler MyEvent;
//     public void TriggerEvent(){
//         if(MyEvent !=null){
//             MyEvent(this,EventArgs.Empty);
//         }
//     }
// }

// public class Subscriber{
//     public void OnEventReceived(Object sender, EventArgs e){
//         Console.WriteLine("Event Received");
//     }
// }



// custom event argument

// public class CustomEventArgs:EventArgs{
//     public string message { get; }
//     public CustomEventArgs(string _message)
//     {
//         message = _message;
        
//     }
// }

// public class Publisher{
//     public event EventHandler<CustomEventArgs> MyEvent;
//     public void TriggerEvent(string message){
//         if(MyEvent !=null){
//             MyEvent(this,new CustomEventArgs(message));
//         }
//     }
// }

// public class Subscriber{
//     public void OnEventReceived(Object sender, CustomEventArgs e){
//         Console.WriteLine($"Event Received : " + e.message);

//     }
// }



// multiple event subscriber with custom EventArgs

public class CustomEventArgs:EventArgs {
    
    public string Name { get; }
      public string Profession { get; }
    public string Country { get; }
  
    public string Message { get; }
    public CustomEventArgs(string name, string profession, string country,string message)
    {
        Name = name;
       Profession = profession;
        Country= country;
       Message = message;

        
    }

}
public class Publisher{
    public event EventHandler<CustomEventArgs> MyEvent;
    public void TriggerEvent(string name, string profession, string country, string message){
        if(MyEvent !=null){
            MyEvent(this,new CustomEventArgs(name,profession,country,message));
        }

    }
}

public class SubscriberX{
    public void OnEventReceived(Object sender, CustomEventArgs e){
        Console.WriteLine($"Event Received 1 : "+ "Hello my name is " + e.Name+" and i'm from "+e.Country +" my profession is "+e.Profession + " and the message:  "+ e.Message );

    }
}

public class SubscriberY{
    public void OnEventReceived(Object sender , CustomEventArgs e){
         Console.WriteLine($"Event Received 2 : "+ "Hello my name is " + e.Name+" and i'm from "+e.Country +" my profession is "+e.Profession + " and the message:  "+ e.Message );


    }
}