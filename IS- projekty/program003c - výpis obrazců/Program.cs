
//První obrazec (2)
Console.Write("Zadejte délku strany čtverce: ");
int n = int.Parse(Console.ReadLine());
bool[,] array = new bool[n,n];

Console.WriteLine();

for(int y = 0; y<n;y++){
    for(int x = 0; x<n;x++){
        if(x == 0 || x == n/2 || x+1 == n)
        {
            array [x,y] = true;
            
        }
        if(y == 0 || y == n/2 || y+1 == n)
        {
            array [x,y] = true;
            
        }
    }
}

for(int y = 0; y<n;y++){
    for(int x = 0; x < n; x++){
       if(array[x,y] == true){
        Console.Write("* ");
       }
       else{
        Console.Write("  ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine();

for(int y = 0; y<n;y++){
    for(int x = 0; x < n; x++){
       array[x,y] = false;
    }
}

//Druhý obrazec (12)



for (int y = 1; y < n; y++)
{
    for (int x = 0; x < n-1; x++)
    {
        array[0, y-1] = (y % 2) == 0;

        array[x + 1,y-1] = (array[x, y - 1] == false);
    }
}

for(int y = 0; y<n;y++){            //výpis 
    for(int x = 0; x < n; x++){
       if(array[x,y] == true){
        Console.Write("* ");
       }
       else{
        Console.Write("  ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine();


// Třetí obrazec (20)
double temp = n/2;
n = (int)Math.Round(temp);
bool[,] array_dve = new bool[n,n];
for (int y = 1; y <= n; y++)
{
    for (int x = 0; x < n-1; x++)
    {
        array[0, y-1] = (y % 2) == 1;

        array[x + 1,y-1] = (array[x, y - 1] == false);
    }
}

for(int y = 0; y<n;y++){            //výpis 
    for(int x = 0; x < n; x++){
       if(array[x,y] == true){
        Console.Write("* ");
        Console.Write("* ");
       }
       else{
        Console.Write("  ");
        Console.Write("  ");
        }
    }
    Console.WriteLine();
    for(int x = 0; x < n; x++){
       if(array[x,y] == true){
        Console.Write("* ");
        Console.Write("* ");
       }
       else{
        Console.Write("  ");
        Console.Write("  ");
        }
    }
    Console.WriteLine();
}




Console.ReadKey();