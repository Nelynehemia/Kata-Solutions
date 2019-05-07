/*
Name: Nely Nehemia
Date: 07/05/2019
Title: Vasya - Clerk
Kata: https://www.codewars.com/kata/vasya-clerk/train/csharp
*/

using System;

public class Line
{   
    public static string Tickets(int[] peopleInLine)
    {
        int numOf25 = 0, numOf50 = 0;

        for (int i = 0; i < peopleInLine.Length; ++i)
        {
            switch (peopleInLine[i])
            {
                case 25:
                    numOf25++;
                    break;

                case 50:
                    if (numOf25 == 0)
                        return "NO";
                    else
                    {
                        numOf25--;
                        numOf50++;
                    }
                    break;

                case 100:
                    if (numOf25 >= 1 && numOf50 >= 1)
                    {
                        numOf50--;
                        numOf25--;
                    }
                    else if (numOf25 > 2)
                        numOf25 -= 3;
                    else
                        return "NO";
                    break;
            }
        }
        return "YES";
    }
}
