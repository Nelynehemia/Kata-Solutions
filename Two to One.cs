 /*
 name:Nely Nehemia
 06/05/2019
 Two to One.cs
 https://www.codewars.com/kata/two-to-one/csharp
 */
 
     public static string Longest(string s1, string s2)
    {
        string[] Letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string result = "";
        s1 += s2;
        for (int i = 0; i < Letters.Length; ++i)
        {
            if (s1.Contains(Letters[i]))
                result += Letters[i];
        }

        return result;
    }
