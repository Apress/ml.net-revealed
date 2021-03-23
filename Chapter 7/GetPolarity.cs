private Tuple<float, float> GetPolarity(IEnumerable<string[]>
sentiWordNetList, string word)
{
 var matchedItem = sentiWordNetList
 .FirstOrDefault(item => item.ElementAt(0).Contains(word));
 if (matchedItem != null)
 {
 return new Tuple<float,
 float>(Convert.ToSingle(matchedItem[1]),//positive
 Convert.ToSingle(matchedItem[2]));//negative
 }
 else
 return new Tuple<float, float>(0F, 0F);
}