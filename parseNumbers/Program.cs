namespace parseNumbers
{
	class Program
    {
        static void Main(string[] args)
        {
			char[] delims = { ',' };
			ParseNumbers pn = new ParseNumbers();
			string fileName = args.Length < 1 ? "input.txt" : args[0];
			pn.ParseFileContent(fileName, delims);
			pn.SumThemUp();
			pn.PrintResult();
        }
    }
}
