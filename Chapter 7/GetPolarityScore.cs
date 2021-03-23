private int GetPolarityScore(string sentence, IEnumerable<string[]> sentiWordNetList)
{
    var words = sentence.Split (' ');
    var polarities = words.Select( word => GetPolarity (sentiWordNetList,word));
	var totalPositivity = polarities.Sum(p => p.Item1);
	var totalNegativity = polarities.Sum(p => p.Item2);
	Console.WriteLine($"Positive polarity of this sentence is
	{totalPositivity}");
	Console.WriteLine($"Negative polarity of this sentence is
	{totalNegativity}");
	if (totalPositivity > totalNegativity) return 1;
	else if( totalNegativity == totalPositivity) return 0;
	else return -1;
}