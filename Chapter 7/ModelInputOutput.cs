public class ModelInput
{
 [ColumnName("col0"), LoadColumn(0)]
 public string Col0 { get; set; }
 [ColumnName("col1"), LoadColumn(1)]
 public float Col1 { get; set; }
 [ColumnName("col2"), LoadColumn(2)]
 public string Col2 { get; set; }
 [ColumnName("col3"), LoadColumn(3)]
 public string Col3 { get; set; }
 [ColumnName("col4"), LoadColumn(4)]
 public string Col4 { get; set; }
 [ColumnName("col5"), LoadColumn(5)]
 public string Col5 { get; set; }
}
public class ModelOutput
{
 // ColumnName attribute is used to change the column name from
 // its default value, which is the name of the field.
 [ColumnName("PredictedLabel")]
 public String Prediction { get; set; }
 public float[] Score { get; set; }
}
Then, this model can obviously be saved, loaded, and consumed to predict the
sentiment of the new-coming entry like this:
var sampleData = new ModelInput()
{
 Col5 = @"@stellargirl I loooooooovvvvvveee my Kindle2.
 Not that the DX is cool, but the 2 is fantastic in its own right.",
 };
// Make a single prediction on the sample data and print results
var predictionResult = ConsumeModel.Predict(sampleData);
