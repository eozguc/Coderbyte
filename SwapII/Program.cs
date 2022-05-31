namespace SwapII;

public class Program
{
    public static string SwapII(string str) {

       

            // code goes here  
            for(int i=0 ; i<str.Length ; i++)
            {
                if(char.IsLower(str , i))
                    Console.Write(char.ToUpper(str[i]));
      
                else if(char.IsUpper(str , i))
                    Console.Write(char.ToLower(str[i]));
      
                else
                    Console.Write(str[i]);
            }
            return str;

        }

        static void Main() {  
            // keep this function call here
            Console.WriteLine(SwapII(Console.ReadLine()));
        } 
}