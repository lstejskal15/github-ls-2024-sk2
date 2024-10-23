// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program {

    static void Main() {
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
                Console.Clear();
                Console.WriteLine("****************************");
                Console.WriteLine("*********obdélník***********");
                Console.WriteLine("****************************");
                Console.WriteLine("******Lucie Stejskalová*****");
                Console.WriteLine("****************************");
                Console.WriteLine("************************\n\n");
                Console.WriteLine();
        // Vstup od uživatle - TO DO

    

        // Vstup od uživatele - lepší varianta
        Console.Write("Zadejte šířku obrazce (celé číslo):");
        int wight;
        while(!int.TryParse(Console.ReadLine(), out number)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo):");
        }
        
        Console.Write("Zadejte výšku obrazce (celé číslo):");
        int height;
        while(!int.TryParse(Console.ReadLine(), out number)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo):");
        }



        //for (int = 1; i <=10; int++) {
        //    Console.WriteLine (i);
        
        //}
        
        //int j = 1;
        //while (int <= 10) {
        //    Console.WriteLine();
        //    j++;
        //}
        
        
        Console.WriteLine();
        for(int i = 1;i<=height;i++) {
            for(int j = 1; j<= width;j++) {
                Console.Write("* ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
            Console.WriteLine();
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        
        
        
    