using System;

namespace Console4
{
    class Program
    {
        static void Main(string[] args)
        {

        // Task 1  //


             System.Console.WriteLine ("Task 1");
             System.Console.WriteLine ();
            System.Console.Write ("Enter A: ");
            int.TryParse(Console.ReadLine(), out var a);
            System.Console.Write ("Enter B: ");
            int.TryParse(Console.ReadLine(), out var b);
            System.Console.WriteLine ();
            int sum = 0;

            for (int i = a + 1; i < b; i++)

            {

            sum = sum + i;

            if (i % 2 == 1)

                {
                System.Console.Write($"{i}, ");
                }
            
            }
            System.Console.WriteLine ();
            System.Console.WriteLine ();
            System.Console.WriteLine($"Sum of the numbers is: {sum}");




             
            System.Console.WriteLine ();
            System.Console.WriteLine ();


        // Task 2  // 

            

            System.Console.WriteLine ("Task 2");
            System.Console.WriteLine (); 

                // Square // 

            for (int i = 0; i <= 50; i++)
            {
            System.Console.Write("*");
            }

            System.Console.WriteLine();


           for (int j = 0; j <= 5; j++)
           {
            for (int i = 0; i <= 50; i++)
            {

            if (i == 0)
            {
            System.Console.Write("*");
            }

            else if (i == 50)
            {
            System.Console.Write("* \n");
            }

            else 
            {
            System.Console.Write(" ");    
            }

            }

           }


            for (int i = 0; i <= 50; i++)

            {
            System.Console.Write("*");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine();

                // Right triangle //

            int val = 10;  
            int g, r;  
            for (g = 1; g <= val; g++)  

            {  

             for (r = 1; r <= g; r++)  
             {  
               Console.Write("*");  
             }  

             Console.WriteLine("");

            }  

            System.Console.WriteLine();
            System.Console.WriteLine();




        // Остальные фигуры не получились

              

        // Task 3  //


             System.Console.WriteLine ("Task 3");
             System.Console.WriteLine ();
            System.Console.Write ("Enter P: % ");
            double.TryParse(Console.ReadLine(), out double p);

            int k = 0;
            double money = 1000;
            
            do

            {
            money = money + money*(p/100);
            k = k+1;   
            }

            while (money < 1100);

            System.Console.WriteLine($"Number of months: {k}, deposit = {Math.Round(money, 2)}");



        }    
        
    }
}
