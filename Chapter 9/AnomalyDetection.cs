using Microsoft.ML;


MLContext ml = new MLContext();

private class TimeSeriesData
{
 public double Value { get; set; }
}
private class SrCnnAnomalyDetection
{
 [VectorType]
 public double[] Prediction { get; set; }
}

private static List<TimeSeriesData> LoadDataFromFile(string fileName)
{
 return File.ReadAllLines(fileName)
 .Skip(1)
 .Select(f => new TimeSeriesData()
 { Value = Convert.ToDouble(f.Split(new char[] { ',' },
 StringSplitOptions.RemoveEmptyEntries)[1])
 })
 .ToList();
}

var data = LoadDataFromFile(@"D:\product-sales.csv");

var dataView = ml.Data.LoadFromEnumerable(data);

string outputColumnName = nameof(SrCnnAnomalyDetection.Prediction);
string inputColumnName = nameof(TimeSeriesData.Value);
// Do batch anomaly detection

var outputDataView = ml.AnomalyDetection.DetectEntireAnomalyBySrCnn
 (dataView,
 outputColumnName,
 inputColumnName,
 threshold: 0.30,
 batchSize: -1,
 sensitivity: 91,
 detectMode: SrCnnDetectMode.AnomalyAndExpectedValue);
 
var predictionColumn = ml.Data.CreateEnumerable<SrCnnAnomalyDetection>(
 outputDataView, reuseRowObject: false);

Step 12: Loop through the predicted column to find the spikes.
 foreach (var prediction in predictionColumn)
 {
 if(prediction.Prediction[2]>0.3)
 {
	Console.WriteLine($"Detected spike at {data[k].Value}");
 }
 k++;
 }