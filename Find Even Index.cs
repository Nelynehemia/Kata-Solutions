/*
Find Even Index.cs
Name: Nely Nehemia
Date: 05/05/19
https://www.codewars.com/kata/equal-sides-of-an-array/csharp
*/
  
  public static int FindEvenIndex(int[] arr)
    {
        int sumArr = arr.Sum();
        if (sumArr == 0) { return 0;}

        int sumL = 0;

        for (int i = 1; i < arr.Length; ++i)
        {
            int sumR = 0;
            sumL += arr[i - 1];
            sumR = sumArr - sumL - arr[i];

            if (sumL == sumR) {return i;}
        }

        return -1;
    }
