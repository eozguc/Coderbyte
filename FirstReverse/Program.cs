namespace FirstReverse;

public class Program
{
    public static string FirstReverse(string str) {

        // code goes here  
        //return str;
        
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);

    }

    static void Main() {  
        // keep this function call here
        Console.WriteLine(FirstReverse(Console.ReadLine()));
    } 
}