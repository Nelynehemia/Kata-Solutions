/*
Highest and Lowest.cs
Name: Nely Nehemia
Date: 03/05/2019
https://www.codewars.com/kata/highest-and-lowest
*/


public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        string[] arrNumbers = numbers.Split(' ');
        Int32.TryParse(arrNumbers[0], out int min);
        int max = min;

        for (int i = 1; i < arrNumbers.Length; ++i)
        {
            Int32.TryParse(arrNumbers[i], out int currentNumber);
            if (min > currentNumber)
            {
                min = currentNumber;
            }
            else if (max < currentNumber)
            {
                max = currentNumber;
            }
        }

        string result = max.ToString() + " " + min.ToString();
        return result;
    }
}
