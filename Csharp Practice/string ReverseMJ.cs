using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string greetings = "Hello my name is MJ";
       reverseString(greetings);
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
}