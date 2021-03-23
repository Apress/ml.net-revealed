//Ground truth verification
string[] labels = new string[]{ "Iris-setosa","Iris-versicolor", "Iris-virginica" };
var sepalLengths = dataView.GetColumn<float>("SepalLength");
var petalLengths = dataView.GetColumn<float>("PetalLength");
var sepalWidths = dataView.GetColumn<float>("SepalWidth");
var petalWidths = dataView.GetColumn<float>("PetalWidth");
Func<string, int> toIndex = p => Array.IndexOf(labels, p) + 1;
var groundTruths = File.ReadAllLines(@"iris.data")
 .Skip(1)//Skip header
 .Select(t => toIndex( t.Split(',')[4]));
int count = 0;
for (int index = 0; index < sepalLengths.Count(); index++)
{
	 IrisData temp = new IrisData
	 {
		 SepalLength = sepalLengths.ElementAt(index),
		 SepalWidth = sepalWidths.ElementAt(index),
		 PetalLength = petalLengths.ElementAt(index),
		 PetalWidth = petalWidths.ElementAt(index)
	 };

	var predicted = predictor.Predict(temp);
	//Ground truth check
	if (predicted.PredictedClusterId != groundTruths.ElementAt(index))
	 count++;
}
var totalRows = sepalLengths.Count();
double correctlyClustered = Math.Round( 100*(double)(totalRows - count) / totalRows,2);
Console.WriteLine($"{correctlyClustered}% belong to the right cluster");