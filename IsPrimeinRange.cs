using System;

public class arr{
    static bool IsPrime(int num){
    if (num<1){
        return false;
    }
    
    for (int i =2; i*i <= num; i++) {
        if (num % i == 0) {
            return false;
        }
    }
    return true;
}
static void PrimeRange(int I, int J){
        int primeCount = 0;
        Console.WriteLine($"The prime numbers between {I} and {J} are: ");
        for (int num = I; num <= J; num++){
            if (IsPrime(num))
            {
                Console.WriteLine(num);
                primeCount++;
            }
        }
        Console.WriteLine($"Total Prime found {primeCount} ");
}

static void Main()
    {
        Console.Write("Enter the start of the range:");
        int I = int.Parse(Console.ReadLine());
        Console.Write("Enter the end of the range:");
        int J = int.Parse(Console.ReadLine());
        PrimeRange(I, J);
    }
}
