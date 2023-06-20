// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class Learn
{
    static void Main(string[] args)
    {
        //LIST
        List<String> food = new List<String>()
        {
         food.Add('Orange');
        food.Add("Tea");
        food.Add("Pizza");
    }
        
          

       
        foreach (String data in food)
        {
            
            Console.WriteLine(data);
        }


        int[] arrayData = { 1, 2, 3 };

        double[] doublesArray = { 0.3, 0.1, 7.0 };

        displayData(arrayData);
        displayData(doublesArray);
      
  

    }
    public static void displayData<Tdata>(Tdata[] array)
    {
        foreach(Tdata item in array)
        {

            Console.WriteLine(item);
        }
    }
}
