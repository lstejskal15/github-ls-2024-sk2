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
            Console.WriteLine("*****************Lucie Stejskalová ***************");
            Console.WriteLine("************************************************\n\n");    
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
            
           //příprava pro generování náhodných čísel
           Random randomNumber = new Random();
            

 

            Console.WriteLine("Náhodná čísla: ");
            for(int i = 0; i < n;i++){
                myArray[i] = randomNumber.Next(dm, hm);
                Console.WriteLine("{0}", myArray[i]);

            }

            int max = myArray[0];
            int min = myArray[0];
            int posMax = 0;
            int posMin = 0;
            int countMax
            int countMin



            for(int i = 1;i < n;i++){
                if(myArray[i]>max){
                    max = myArray[i];
                    posMax = i;
                }
                if(myArray[i]>min){
                    min = myArray[i];
                    posMin = i;
                }
            
            }


            Console.WriteLine("Maximum je: {0}", max);
            Console.WriteLine("pozice maxima je: {0}", posMax);
            Console.WriteLine("Minimum je: {0}" , min);
            Console.WriteLine("Pozice minima je: {0}" , posMin);


 

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
