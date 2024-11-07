using System;
using System.Security.Cryptography;

 

class Program {
    static void Main() {
       
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********Generátor pseudováhodných čísel*******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* Lucie Stejskalová ***************");
            Console.WriteLine("*******************************************\n\n");    
            Console.WriteLine();    
           
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(),out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo): ");
            }

 

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(),out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

 

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(),out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

 

            Console.WriteLine("\n\n================");
            Console.WriteLine("Uživatel zadal počet: {0}, dolní mez: {1}, horní mez: {2}",n, dm, hm);
            Console.WriteLine("================\n\n");

 

            //declare pole
            int[]myArray = new int[n];
            int max=0;
            int min=hm;
            //příprava pro generování náhodných čísel
            Random randomNumber = new Random();

 

            Console.WriteLine("Náhodná čísla: ");
            for(int i = 0; i < n;i++){
                myArray[i] = randomNumber.Next(dm, hm);
                Console.WriteLine("{0}", myArray[i]);
                if(myArray[i]>max){
                    max = myArray[i];
                }
                if(myArray[i]<min){
                    min = myArray[i];
                }

 

            }
            Console.WriteLine("Maximum je: {0}", max);
            Console.WriteLine("Minimum je: {0}" , min);


 

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}