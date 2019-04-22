using System;
using System.Collections.Generic;

namespace NumberCheck {

  public class Numbers
  {
    static int maxNumber = 100;
    static int minNumber = 1;



    public static void Main()
    {


      NumberChecker myNumber = new NumberChecker(minNumber, maxNumber);
      Console.WriteLine("Is your number higher or lower than " + myNumber.Result());
      string userInput = Console.ReadLine();
      bool check  = myNumber.IsCorrect(userInput);
      if (check == true)
      {
        Console.WriteLine("Great! I guessed your number.");
      }
      else
      {
          Main();
      }

    }
  }
}
