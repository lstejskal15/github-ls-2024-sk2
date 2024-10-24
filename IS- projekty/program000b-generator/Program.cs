// See https://aka.ms/new-console-template for more information
using System;

class Program {

    static void Main() {
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
                Console.Clear();
                Console.WriteLine("********************");
                Console.WriteLine("*********Výpis řady***********");
                Console.WriteLine("********************");
                Console.WriteLine("**********Lucie Stejskalová**********");
                Console.WriteLine("********************");
                Console.WriteLine("*****************\n\n");
                Console.WriteLine();



        
        Console.Write("Zadejte počet generovaných čísel (celé číslo):");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n)) {
            Console.Write("Nezadali jste celé číslo. Zadejte poče čísel znovu (celé číslo):");

        Console.Write("Zadejte dolní mez (celé číslo):");
        int dm;
        while(!int.TryParse(Console.ReadLine(), out dm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):");

        Console.Write("Zadejte horní mez (celé číslo):");
        int hm;
        while(!int.TryParse(Console.ReadLine(), out hm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):");
       }

        Console.WriteLine("\n\n===================");
        Console.WriteLine("\n\n Uživatelský vstup:");
        Console.WriteLine("\n\n Počet čísel :{0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
        Console.WriteLine("===================\n\n");

        
        //deklarace pole
        int[] myArray = new int[n];

        //příprava pro generování náhodných čísel
        Random randomNumber = new Random();

        int kladna = 0;
        int zaporna = 0;
        int nuly = 0;
        int suda = 0;
        int licha = 0;

        
        Console.WriteLine ("Náhodná čísla: ");

        for (int i=0; i<n;i++) {
            myArray [i] = randomNumber.Next(dm, hm);
            Console.Write("{0};", myArray[i]);
       
           // if(myArray[i]>0)
           //         kladna++;

           // if(myArray[i]<0)
           //         zaporna++;

            //if(myArray[i]>0)
            //       nuly++;

            if(myArray[i]>0)
                kladna++;
            else if (myArray[i]<0)
                zaporna++;
            else
                nuly++;
            
            if(myArray[i] % 2 == 0)
                suda++;
            else
                licha++;

        }
        
        
        Console.WriteLine("\n\nPočet kladných čísel:{0}", kladna);
        Console.WriteLine("Počet záporných čísel:{0}", zaporna);
        Console.WriteLine("Počet nul:{0}", nuly);

        Console.WriteLine("\n\nPočet sudych čísel:{0}", suda);
        Console.WriteLine("\n\nPočet lichych čísel:{0}", licha);

       
        
        


        Console. WriteLine ("Program opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        

        
        

     }

 }
    }
}
}