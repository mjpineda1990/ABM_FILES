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
}