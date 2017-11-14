using System;
using System.Collections.Generic;

namespace parseNumbers
{
	public class ParseNumbers
	{
		private List<int> mNumbers;
		private List<string> mResults;

		public ParseNumbers() {
			mNumbers = new List<int>();
			mResults = new List<string>();
		}

		public void ParseFileContent(string fileName, char[] delimiters)
		{
			try
			{
				string fileContent = System.IO.File.ReadAllText(fileName);
				string[] words = fileContent.Split(delimiters);

				mNumbers = new List<int>();
				foreach (string word in words)
				{
					int n;
					bool isNumeric = int.TryParse(word, out n);
					if (isNumeric)
					{
						mNumbers.Add(n);
					}
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public void SumThemUp()
		{
			int sum = 0;
			foreach (int num in mNumbers)
			{
				sum += num;
			}
			string result = "Sum of numbers: " + sum;
			mResults.Add(result);
		}
		
		public void PrintResult()
		{
			foreach (string message in mResults)
			{
				Console.WriteLine(message);
			}
		}
	}
}
