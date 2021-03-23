void Main()
{
 var sentiWordList = System.IO.File.ReadAllLines(@"SentiWordNet_3.0.0.txt")
	.Where(line => !line.StartsWith("#"))
	.Select(line => line.Split('\t'))
	.Where(tokens => tokens.Length >= 5)
	.Select(lineTokens => new
	 {
		POS = lineTokens[0],
		ID = lineTokens[1],
		PositiveScore = lineTokens[2].Trim(),
		NegativeScore = lineTokens[3].Trim(),
		Words = lineTokens[4]
	 })
	.Select(item => new string[]
	 {
		item.Words.Substring(0, item.Words.LastIndexOf('#')+ 1),
		item.PositiveScore,
		item.NegativeScore
	 });

 foreach (var element in sentiWordList.Take(5))
 {
	 //The following line should be in a single line
	 Console.WriteLine($@"{element.Lexicon} {element.PositiveScoe} {element.NegativeScore}");
 }