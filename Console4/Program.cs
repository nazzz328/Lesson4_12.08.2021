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

            for (int i = 0; i <= 25; i++)
            {
            System.Console.Write("* ");
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


            for (int i = 0; i <= 25; i++)

            {
            System.Console.Write("* ");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine();

        // Right triangle //

          for ( int i = 1; i <= 7; i++ ){
                        if ( i == 1 || i == 7 ){
                            if ( i == 1 ){
                                Console.Write("*"); 
                            }
                            else{
                                for ( int j = 1; j <= 13; j++ ){
                                    Console.Write("*"); 
                                }
                            }
                            Console.Write("\n"); 
                        }
                        else{
                            Console.Write("*"); 
                            for ( int j = 1; j <= i-1; j++ ){
                                Console.Write("  "); 
                            }
                            Console.Write("*\n"); 
                        }
                    }
                    {   
                    



        // Triangle
        
for ( int i = 1; i <= 5; i++ ){
                            if ( i == 1){
                                for ( int j = 1; j <= 9; j++ ){
                                    if ( j == 6 ){
                                        Console.Write('*'); 
                                    }
                                    else{
                                        Console.Write(" "); 
                                    }
                                }
                                Console.Write("\n"); 
                            }
                            else if ( i == 5 ){
                                for ( int j = 1; j <= 11; j++ ){
                                    Console.Write("*"); 
                                }
                                Console.Write("\n"); 
                            }
                            else{
                                int r = 6 - i; 
                                int l = 6 + i; 
                                for ( int j = 1; j <= 10; j++ ){
                                    if ( j == r || j == l ){
                                        Console.Write("*"); 
                                    }else{
                                        Console.Write(" "); 
                                    }
                                }
                                Console.Write("\n"); 
                            }
                        }
                    }

                    {

            // Rhomb

            {
                        
                        int l = 8, r = 8; 
                        for ( int i = 1; i <= 3; i++ ){
                            for ( int j = 1; j <= 16; j++ ){
                                if ( l == j || r == j ){
                                System.Console.Write("*");
                                }
                                else{
                                System.Console.Write(" ");
                                }
                            }
                            Console.Write("\n"); 
                            l-=2; r+=2; 
                        } 
                        l = 8+(3*-2); r = (8+3*2); 
                        for ( int i = 4; i >= 1; i-- ){
                            for ( int j = 1; j <= 14; j++ ){
                                if ( l == j || r == j ){
                                System.Console.Write("*");
                                }
                                else{
                                System.Console.Write(" ");
                                }
                            }
                            Console.Write("\n"); 
                            l+=2; r-=2; 
                        } 
              

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
}
}
