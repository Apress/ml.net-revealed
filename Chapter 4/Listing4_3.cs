public static IEstimator<ITransformer> BuildTrainingPipeline(MLContext mlContext)
{
	// Data process configuration with pipeline data transformations
	var dataProcessPipeline = mlContext.Transforms.IndicateMissingValues(new[] 
	  { new InputOutputColumnPair("horsepower_MissingIndicator","horsepower")})
	  
	.Append(mlContext.Transforms.Conversion.ConvertType(
		new[] { new InputOutputColumnPair("horsepower_MissingIndicator",
		                                   "horsepower_MissingIndicator")}))
	.Append(mlContext.Transforms.ReplaceMissingValues(
		new[] { new InputOutputColumnPair("horsepower","horsepower")}))
	.Append(mlContext.Transforms.Concatenate("Features",
	    new[]{ "horsepower_MissingIndicator",
		       "horsepower",
			   "cylinders",
			   "displacement",
			   "weight",
			   "acceleration","model year","origin"}));
	
	// Set the training algorithm 
	
	var trainer = mlContext.Regression.Trainers.FastTreeTweedie(
	  new FastTreeTweedieTrainer.Options()
	  {
			NumberOfLeaves = 7,
			MinimumExampleCountPerLeaf = 1,
			NumberOfTrees = 100,
			LearningRate  = 0.1908787f,
			Shrinkage = 0.3315645f,
			LabelColumnName = "mpg",
			FeatureColumnName = "Features"
		});
	
	var trainingPipeline = dataProcessPipeline.Append(trainer);
	