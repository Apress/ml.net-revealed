string _dataPath = @"C:\Users\Sudipta\Downloads\iris.data";
IDataView dataView = mlContext.Data.LoadFromTextFile<IrisData>(_dataPath, hasHeader: true, separatorChar: ',');

var options = new Microsoft.ML.Trainers.KMeansTrainer.Options
{
	 InitializationAlgorithm =
	 Microsoft.ML.Trainers.KMeansTrainer.
	 InitializationAlgorithm.KMeansYinyang,
	 MaximumNumberOfIterations = 100,
	 NumberOfThreads = 4,
	 NumberOfClusters = 3,
	 OptimizationTolerance = 0.002F,
	 FeatureColumnName = featuresColumnName
};

var pipeline =
mlContext.Transforms.Concatenate(featuresColumnName, "SepalLength", "SepalWidth", "PetalLength", "PetalWidth")
                    .Append(mlContext.Clustering.Trainers.KMeans(options));

var model = pipeline.Fit(dataView);

IrisData Setosa = new IrisData
{
	 SepalLength = 5.1f,
	 SepalWidth = 3.5f,
	 PetalLength = 1.4f,
	 PetalWidth = 0.2f
};

var predictor = mlContext.Model.CreatePredictionEngine<IrisData, ClusterPrediction>(model);
var prediction = predictor.Predict(Setosa);
Console.WriteLine($"Cluster:{prediction.PredictedClusterId}");
Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances)}");