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
            Console.WriteLine("**************Lucie Stejskalová ***************");
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
            
           //příprava pro generování náhodných čísel
           Random randomNumber = new Random();
            

 

            Console.WriteLine("Náhodná čísla: ");
            for(int i = 0; i < n;i++){
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.WriteLine("{0}", myArray[i]);

            }

            int max = myArray[0];
            int min = myArray[0];
            int posMax = 0;
            int posMin = 0;
            int countMax = 1;
            int countMin = 1;
            


            for(int i = 1;i < n;i++){
                if(myArray[i]>max){
                    max = myArray[i];
                    posMax = i;
                    countMax = 1;
                }
                else if (myArray [i] == max){
                    countMax++;
                }
                if(myArray[i]<min){
                    min = myArray[i];
                    posMin = i;
                    countMin = 1;
                }
                 else if (myArray [i] == min){
                    countMin++;
                
                }
            
            }

            int[] poziceMax = new int[countMax];
            int[] poziceMin = new int[countMin];
            int index = 0;

             for(int i = 1;i < n;i++){
                if (myArray[i] == max){
                    poziceMax[index] = i; index++;
                }
            
            }
            
            index = 0;

            for(int i = 1;i < n;i++){
                if (myArray[i] == min){
                    poziceMin[index] = i; index++;
                }
            
            }

            Console.WriteLine("Maximum je: {0}", max);
            Console.Write("pozice maxim je: ");
            foreach(int i in poziceMax){
                Console.Write(i+" ");
            }
            Console.WriteLine("\nPočet maxim je: {0}", countMax);
            Console.WriteLine("Minimum je: {0}" , min);
            Console.Write("pozice minim je: ");
            foreach(int i in poziceMin){
                Console.Write(i+" ");
            }
            Console.WriteLine("\nPočet minim je: {0}", countMin);


 

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
