using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Pyramid Pattern");
        fncTrianglePattern();
    }
    public static void fncTrianglePattern()
    {
        int n = 7;
        for(int i=1;i<=n;i++){
            for(int j=1;j<=2*n-1;j++)
            {
                if(j>=n-(i-1) && j<=n+(i-1))
                {
                    Console.Write("8");
                }
                else
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        return;
    }
}