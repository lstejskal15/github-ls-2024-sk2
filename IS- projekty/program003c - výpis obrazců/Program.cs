

int n = 8;
bool[,] array = new bool[n,n];

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
Console.ReadKey();