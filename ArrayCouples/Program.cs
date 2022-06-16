
using System;
using System.Collections.Generic;

namespace ArrayCouples;

public class Program
{
    public static string ArrayCouples(int[] arr) {

        // code goes here
        string answer = "";
        int length = arr.Length - 1;
        List<string> foundOnes = new List<string>();

        string checkedPair;
        string currentPair;
        bool found;

        for (int i = 0; i < length; i += 2)
        {
            checkedPair = $"{arr[i]},{arr[i+1]}";

            if (foundOnes.Contains($"{arr[i+1]},{arr[i]}"))
                continue;
        
            found = false;
    
            for (int j = i+2; j < length; j += 2)
            {
                currentPair = $"{arr[j+1]},{arr[j]}";

                if (currentPair.Equals(checkedPair))
                {
                    found = true;
                    foundOnes.Add(checkedPair);
                    break;
                } 
            }

            if (!found)
                answer += checkedPair + ",";
        }

        return answer.Length>0? answer.TrimEnd(',') : "yes";

    }

}