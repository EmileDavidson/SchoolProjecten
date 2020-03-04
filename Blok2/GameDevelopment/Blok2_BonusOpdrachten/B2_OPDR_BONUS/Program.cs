using System;
using System.Timers;

public class Program
{
   private static System.Timers.Timer aTimer;
   
   static public int i = 11;
   public static void Main()
   {
      SetTimer();
      Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
      Console.WriteLine("press any key to stop the applicatie");
      Console.ReadKey();
      
   }

   private static void SetTimer()
   {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(1000);

        //zorgt dat de timer elke seconde afgaat (functie)
        aTimer.Elapsed += OnTimedEvent;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        if(i <= 1){
            Console.WriteLine("The application ended at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.WriteLine("boem");
            aTimer.Stop();
        }else{
            i--;
            Console.WriteLine(i);
        }
    }
}