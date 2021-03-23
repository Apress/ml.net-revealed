ClusteringMetrics metrics = mlContext.Clustering.Evaluate(model.Transform(dataView),"PredictedLabel", "Score", "Features");
Console.WriteLine(metrics.AverageDistance);
Console.WriteLine(metrics.DaviesBouldinIndex);
Console.WriteLine(metrics.NormalizedMutualInformation);