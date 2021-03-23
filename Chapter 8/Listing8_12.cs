public class ModelOutput
{
 public float Score { get; set; }
}
This can be used as shown in the generated code.
// Create single instance of sample data from
//first line of dataset for model input
ModelInput sampleData = new ModelInput()
{
 UserId = 1F,
 MovieId = 1F,
};
// Make a single prediction on the sample data and print results
var predictionResult = ConsumeModel.Predict(sampleData);