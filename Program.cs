void positiveCount()
{
    int size = 6;
    int count = 0;
    int[] arr = manualArray(size);
    PrintArray(arr);
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.WriteLine($"{count} numbers bigger then zero");
}

void intersectionPoint()
{
    int size = 4;
    int[] arr = manualArray(size);
    double b1 = arr[0];
    double k1 = arr[1];
    double b2 = arr[2];
    double k2 = arr[3];

    if (k1 == k2) Console.WriteLine("Lines are parallel");
    else
    {
        double y = (b2 - b1) / (k1 - k2);
        double x = (y - b2) / k2;
        if (k1 * x + b1 == k2 * x + b2) 
        {
            Console.WriteLine($"Intersection points x: {Math.Round(x, 2)} ; y: {Math.Round(y, 2)}");
            
        }
        else Console.WriteLine($"No intersection");        
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("\b]");
    Console.WriteLine();
}
int[] manualArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter number");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}

// positiveCount();
intersectionPoint();