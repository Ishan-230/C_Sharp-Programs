using System;

class TrianglePattern
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++) // Loop for rows
        {
            for (int j = 1; j <= i; j++) // Loop for numbers in each row
            {
                Console.Write(j + " ");
            }
            Console.WriteLine(); // Move to the next line
        }
    }
}
