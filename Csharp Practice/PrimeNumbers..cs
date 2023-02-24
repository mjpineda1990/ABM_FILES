using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Prime Numbers");
        PrimeNumb();
    }public static void PrimeNumb(){
        bool prime = true;
        int A = 2;
        while(A<=100){
            int B = 2;
            while(B<A - 1){
                if(A%B ==0){
                    prime=false;
                    break;
                }
                B++;
            }
            if(prime){
                Console.WriteLine(A);
            }
            prime=true;
            A++;
        }
    }