using System;

namespace AlphabetSoup;

public class Program
{
    public static char[] AlphabetSoup(string str) { 
  
        // code goes here  
        /* Note: In C# the return type of a function and the 
           parameter types being passed are defined, so this return 
           call must match the return type of the function.
           You are free to modify the return type. */
        //string result = str;
        char[] res= str.ToCharArray();

    
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length-1; j++)
            {
                if (res[j] > res[j+1])
                {
                    char tmp = res[j];
                    res[j] = res[j+1];
                    res[j+1] = tmp;
                }

            }
        }
    
        return res;
            
    }

    static void Main() {  
        // keep this function call here
        Console.WriteLine(AlphabetSoup(Console.ReadLine()));
    } 
}