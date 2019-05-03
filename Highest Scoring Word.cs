   
/*
Highest Scoring Word.cpp
Name: Nely Nehemia
Date: 03/05/19
https://www.codewars.com/kata/highest-scoring-word
*/
  
  
  public static string High(string s)
    {
        string[] words = s.Split(' ');
        int wordMax = 0, indexMax = 0;

        for (int i = 0; i < words.Length; ++i)
        {
            int count = 0;
            for (int j = 0; j < words[i].Length; ++j)
            {
                count += (words[i][j] - 'a' + 1);
            }

            if (wordMax < count)
            {
                wordMax = count;
                indexMax = i;
            }
        }
        return words[indexMax];
    }
