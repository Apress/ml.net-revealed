//change your path accordingly
string DATA_FILEPATH = @"C:\MLDOTNET\housing.csv";

MLContext context = new MLContext(seed: 1);

IDataView trainingDataView = context.Data.LoadFromTextFile<BostonHouse>
(
	 path: DATA_FILEPATH,
	 hasHeader: true, 
	 separatorChar: ',', 
	 allowQuoting: true,
	 allowSparse: false
);

var pipeLine = context.Transforms.NormalizeMinMax("crim", "crim")
 .Append(context.Transforms.NormalizeMinMax("zn", "zn"))
 .Append(context.Transforms.NormalizeMinMax("indus","indus"))
 .Append(context.Transforms.NormalizeMinMax("chas", "chas"))
 .Append(context.Transforms.NormalizeMinMax("nox", "nox"))
 .Append(context.Transforms.NormalizeMinMax("rm", "rm"))
 .Append(context.Transforms.NormalizeMinMax("age", "age"))
 .Append(context.Transforms.Concatenate("Features", "crim", "zn", "indus", "chas", "nox", "rm", "age"));
 
// Set the training algorithm
var trainer = context.Regression.Trainers.Sdca(labelColumnName: "medv");
var trainingPipeline = pipeLine.Append(trainer);
var model = trainingPipeline.Fit(trainingDataView);
var engine = context.Model.CreatePredictionEngine<BostonHouse, BostonHousePrice>(model);
var input = CreateSingleDataSample(DATA_FILEPATH);
var result = engine.Predict(input);

Console.WriteLine($"Actual MEDV is {sampleData.Medv}");
Console.WriteLine($"Predicted MEDV is {result.Medv}");
