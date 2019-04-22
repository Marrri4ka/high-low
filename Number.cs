using System;

namespace NumberCheck {

  class NumberChecker
  {
    private int MinNumber;
    private int MaxNumber;//Fiels

    public NumberChecker (int minNumber, int maxNumber) //constructor
    {
      MinNumber = minNumber;
      MaxNumber = maxNumber;
    }

    public int Result()
    {
      return (MinNumber+MaxNumber) / 2;
    }


    public bool IsCorrect(string userInput)
    {
      if(userInput == "Correct")
      {
        return true;
      }

     if(userInput == "Higher")
     {
       MinNumber = Result();
       return false;
     }

     else if (userInput == "Lower")
     {
       MaxNumber = Result();
       return false;
     }

     else
     {
       return false;
     }
}

}
}
