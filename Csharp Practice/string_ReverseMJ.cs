using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string greetings = "Hello my name is MJ";
       reverseString(greetings);

        string john = "Hello my name is John";
        Reverse(john);

    }
    public static void reverseString(string name)
    {
        string reverseS = string.Empty;
        for(int i= name.Length-1;i>=0;i--){
            reverseS+=name[i];
        }
         Console.WriteLine("This is Original:"+"\n"+name);
         Console.WriteLine(" ");
        Console.WriteLine("This is Reverse:"+"\n"+reverseS);
    }

    public static void Reverse(string name)
    {
        string[] nameArr = name.Split(" ");
        string reverseString = string.Empty;

        for (int x = 0; x <= nameArr.Length - 1; x++)
        {
            for (int y = nameArr[x].Length - 1; y >= 0; y--)
            {
                reverseString += nameArr[x][y];
            }
            reverseString += " ";
        }
        Console.Write($"Reverse String is : {reverseString} ");
    }
}