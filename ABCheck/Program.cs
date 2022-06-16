using System;

namespace ABCheck;

public class Program
{
    public static string ABCheck(string str) {


        char[] letters = str.ToCharArray();

        bool findTarget = false;

        for(int i=0; i < str.Length; i++){



            if(letters[i] == 'a' ||  letters[i] == 'b'){
                char couple = 'b';
                if(letters[i] == 'b'){ couple = 'a'; }

                for(int j=0; j < str.Length; j++){
                    if(letters[j] == couple){

                        //Console.WriteLine("Nums: "+i+" "+j);
                        int spaceBetween = Math.Abs(j - i)-1;
                        if(spaceBetween == 3){
                            findTarget = true;
                        }
                        //Console.WriteLine(spaceBetween);

                    }
                }
            }
        }

        string returnString = "false";
        if(findTarget == true){
            returnString = "true";
        }





        // code goes here
        return returnString;

    }

    static void Main() {
        // keep this function call here
        Console.WriteLine(ABCheck(Console.ReadLine()));
    } 
    
    
  //  public static string ABCheck(string str) {

   //     for (int i = 0; i < str.Length; i++) {
    //        if ((str[i] == 'a') && ((i + 4) < str.Length) && (str[i+4] == 'b')) {
     //           return "true";
     //       }
     //   }

    //    return "false";

 //   }

 //   static void Main() {
        // keep this function call here
     //   Console.WriteLine(ABCheck(Console.ReadLine()));
  //  } 

}

}