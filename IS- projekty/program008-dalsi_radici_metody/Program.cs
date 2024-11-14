
﻿using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;
using System.Reflection.Metadata;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Další metody **************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Lucie Stejskalová ******************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            
            Stopwatch myStopwatch = new Stopwatch(); 
            myStopwatch.Start();

            int numberCompare = 0;
            int numberChange = 0;

            for(int i=0; i<n-1; i++) {
                for(int j=0 ; j<n-i-1; j++) {
                    numberCompare++;
                    if(myArray[i] < myArray[j]) {
                        int tmp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = tmp;
                        numberChange++;
                    }
                }
            }
            myStopwatch.Stop();

            Stopwatch myStopwatch2 = new Stopwatch(); 
            
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            myStopwatch2.Start();

            int numberCompare2 = 0;
            int numberChange2 = 0;

            for(int i=0; i<n-1; i++) {
                for(int j=0 ; j<n-i-1; j++) {
                    numberCompare2++;
                    if(myArray[j] < myArray[j+1]) {
                        int tmp = myArray[j];
                        myArray[j] = myArray[j+1];
                        myArray[j+1] = tmp;
                        numberChange2++;
                    }
                }
            }
            myStopwatch2.Stop();

            Stopwatch myStopwatch3 = new Stopwatch(); 
            
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            myStopwatch3.Start();

            int numberCompare3 = 0;
            int numberChange3 = 0;

            for(int i=1; i<n-1; i++) {
                int tmp = myArray[i];
                int j = i - 1;
                numberCompare3++;
                while(j>=0 && myArray[j]>tmp){
                    myArray[j+1] = myArray[j];
                    j--;
                    numberCompare3++;
                }
                    myArray[j+1] = tmp;
                    numberChange3++;
                }
        

            myStopwatch3.Stop();

             Stopwatch myStopwatch4 = new Stopwatch(); 
            
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            myStopwatch4.Start();

            int numberCompare4 = 0;
            int numberChange4 = 0;

            for (int i = 0; i < myArray.Length / 2; i++){
       bool swapped = false;
        for (int j = i; j < myArray.Length - i - 1; j++)
        {
            numberCompare4++;
            if (myArray[j] < myArray[j + 1])
            {
                int tmp = myArray[j];
                myArray[j] = myArray[j + 1];
                myArray[j + 1] = tmp;
                swapped = true;
                 numberChange4++;
            }
        }
        for (int j = myArray.Length - 2 - i; j > i; j--)
        {
            numberCompare4++;
            if (myArray[j] > myArray[j - 1])
            {
                int tmp = myArray[j];
                myArray[j] = myArray[j - 1];
                myArray[j - 1] = tmp;
                swapped = true;
                numberChange4++;
            }
        }
        if (!swapped) break;
    }
            myStopwatch4.Stop();

             Stopwatch myStopwatch5 = new Stopwatch(); 
            
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            myStopwatch5.Start();

            int numberCompare5 = 0;
            int numberChange5 = 0;

            int gap = myArray.Length / 2;
    while (gap > 0) 
    { 
        for (int i = 0; i < myArray.Length - gap; i++) 
        { 
            numberCompare5++;
            int j = i + gap;
            int tmp = myArray[j];
            while (j >= gap && tmp > myArray[j - gap])
            {
                numberChange5++;
                myArray[j] = myArray[j - gap];
                j -= gap;
            }
            myArray[j] = tmp;
        }
        if (gap == 2) 
        { 
            gap = 1;
        }
        else
        {
            gap = (int)(gap / 2.2);
        }
    }
        myStopwatch5.Stop();

                 Stopwatch myStopwatch6 = new Stopwatch(); 
            
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            myStopwatch6.Start();

            int numberCompare6 = 0;
            int numberChange6 = 0;

                bool swapped2 = true;
        gap = myArray.Length;
        double shrinkFactor = 1.3;

        
        while (gap > 1 || swapped2)
        {
            numberCompare6++;
            gap = (int)(gap / shrinkFactor);
            if (gap < 1)
            {
                gap = 1; 
            }

            swapped2 = false;

            
            for (int i = 0; i + gap < myArray.Length; i++)
            {
                
                if (myArray[i] < myArray[i + gap])
                {
                    numberChange6++;
                    int tmp = myArray[i];
                    myArray[i] = myArray[i + gap];
                    myArray[i + gap] = tmp;
                    swapped2 = true;
                }
            }
        }
            

            myStopwatch6.Stop();



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Bubble sort: {0}", myStopwatch2.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare2);
            Console.WriteLine("Počet výměn: {0}", numberChange2);
            
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Selection sort: {0}", myStopwatch.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
            Console.WriteLine("Počet výměn: {0}", numberChange);
            
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Insertion sort: {0}", myStopwatch3.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare3);
            Console.WriteLine("Počet výměn: {0}", numberChange3);
            
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Shaker sort: {0}", myStopwatch4.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare4);
            Console.WriteLine("Počet výměn: {0}", numberChange4);
            
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Shell sort: {0}", myStopwatch5.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare5);
            Console.WriteLine("Počet výměn: {0}", numberChange5);
            
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Comb sort: {0}", myStopwatch6.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare6);
            Console.WriteLine("Počet výměn: {0}", numberChange6);
            
            Console.ResetColor();


            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
