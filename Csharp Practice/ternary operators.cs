<<<<<<< HEAD
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] Age = { 13, 42, 15, 20, 18, 25, 14, 55 };
        findAge(Age);
    }
    public static void findAge(int[] Age)
    {

        for (int i = 0; i < Age.Length; i++)
        {
            Console.WriteLine((Age[i] <= 18) ? +Age[i] + " Is a Teenager" : Age[i] + " Is an Adult");
        }
    }
=======
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] Age = { 13, 42, 15, 20, 18, 25, 14, 55 };
        findAge(Age);
    }
    public static void findAge(int[] Age)
    {

        for (int i = 0; i < Age.Length; i++)
        {
            Console.WriteLine((Age[i] <= 18) ? +Age[i] + " Is a Teenager" : Age[i] + " Is an Adult");
        }
    }
>>>>>>> 5df0d126d2640df069411d252129b3f1a3f2b42c
}