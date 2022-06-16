
using System;
using System.Collections.Generic;

namespace BlackjackHighest;

public class Program
{
     public static string[] IsHigh(string[] highest, int value, string str) {
    if(value > Convert.ToInt32(highest[0])) {
      highest[0] = value + "";
      highest[1] = str;
    }
    return highest;
  }

  public static string BlackjackHighest(string[] strArr) {
    int total = 0;
    int aceCount = 0;
    string result = "";
    string[] highest = new string[] {"1", "ace"};

    List<string> strList = new List<string>(strArr);

    while(strList.Contains("ace")) {
      strList.Remove("ace");
      aceCount++;
    }

    while(aceCount != 0) {
      strList.Add("ace");
      aceCount--;
    }
foreach(string card in strList) {
      switch(card) {
          case "two": 
            total += 2;
            highest = IsHigh(highest, 2, "two");
            break;
          case "three": 
            total += 3;
            highest = IsHigh(highest, 3, "three");
            break;
          case "four": 
            total += 4;
            highest = IsHigh(highest, 4, "four");
            break;
          case "five": 
            total += 5;
            highest = IsHigh(highest, 5, "five");
            break;
          case "six": 
            total += 6;
            highest = IsHigh(highest, 6, "six");
            break;
          case "seven": 
            total += 7;
            highest = IsHigh(highest, 7, "seven");
            break;
          case "eight": 
            total += 8;
            highest = IsHigh(highest, 8, "eight");
            break;
          case "nine": 
            total += 9;
            highest = IsHigh(highest, 9, "nine");
            break;
          case "ten": 
            total += 10;
            highest = IsHigh(highest, 10, "ten");
            break;
          case "jack": 
            total += 10;
            highest = IsHigh(highest, 11, "jack");
            break;
          case "queen": 
            total += 10;
            highest = IsHigh(highest, 12, "queen");
            break;
          case "king": 
            total += 10;
            highest = IsHigh(highest, 13, "king");
            break;
          case "ace":
            if(total + 11 > 21) {
              total += 1;
              highest = IsHigh(highest, 1, "ace");
            } else {
              total += 11;
              highest = IsHigh(highest, 14, "ace");
            }
            break;
      }
    }
if(total > 21) {
      result = "above " + highest[1];
    } else if(total < 21) {
      result = "below " + highest[1];
    } else {
      result = "blackjack " + highest[1];
    }

    // code goes here
    return result;

  }

  static void Main() {
    // keep this function call here
    Console.WriteLine(BlackjackHighest(Console.ReadLine()));
  } 

}