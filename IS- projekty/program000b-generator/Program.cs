// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
﻿// See https://aka.ms/new-console-template for more information
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
        
        Console.WriteLine ("Náhodná čísla: ");

        for (int i=0; i<n;i++) {
            myArray [i] = randomNumber.Next(dm, hm);
            Console.Write("{0};", myArray[i]);
        }
        


        Console. WriteLine ("Program opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        

        
        

     }

 }
    }
}