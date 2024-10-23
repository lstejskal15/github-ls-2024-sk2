// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program {

    static void Main() {
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
                Console.Clear();
                Console.WriteLine("********************");
                Console.WriteLine("*********Součet a součin cifer***********");
                Console.WriteLine("********************");
                Console.WriteLine("**********Lucie Stejskalová**********");
                Console.WriteLine("********************");
                Console.WriteLine("*****************\n\n");
                Console.WriteLine();
        // Vstup od uživatle - TO DO

    

        // Vstup od uživatele - lepší varianta
        Console.Write("Zadejte první číslo řady (celé číslo):");
        int number;
        while(!int.TryParse(Console.ReadLine(), out number)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):");
        }

        //Výpis vstupní hodnoty 
        Console.WriteLine ("================");
        Console.WriteLine ("Uživatel zadal: {0}", number);
        Console.WriteLine ("================"\n\n);

        int suma = 0;
        int multi = 1;
        int numberBackup = number;
        int digit;

        //Pokud je číslo záporné tak minus odstraníme
        if (number < 0){
            number = - number;
        }
        
        
        while(number >= 10) {
            digit = number % 10; //% opearátor mod
            number = (number - digit) / 10;
            Console.WriteLine("Digit = {0}", digit);
            Console.WriteLine("Digit = {0}, number");
            suma = suma + digit;
            multi = multi * digit;
        }
        Console.WriteLine("Digit = {0}, number");
        suma = suma + number;
        multi = multi * number;
        
        
        Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
        Console.WriteLine("\n\nSoučin cifer čísla {0} je {1}", numberBackup, suma);
        
        
        
        
        
        
      



        // Opakování programu
        Console. WriteLine ("Program opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
            }
          }      
