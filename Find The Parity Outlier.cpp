/*
Find The Parity Outlier.cpp
Name: Nely Nehemia
Date: 05/02/19
Kata: https://www.codewars.com/kata/find-the-parity-outlier
*/

int FindOutlier(std::vector<int> arr)
{
	int i = 0;
	int countEven = 0, countOdd = 0;
	int resultEven, resultOdd;

	while ((countEven + countOdd) < 3 || countOdd == 0 || countEven == 0)
	{
		if (arr[i] % 2 == 0)// even
		{
			countEven++;
			resultEven = arr[i++];
		}
		else
		{
			countOdd++;
			resultOdd = arr[i++];
		}
	}

	if (countOdd == 1)
		return resultOdd;
	else
		return 	resultEven;
}
