VBuffer<float>[] centroids = default;
var modelParams = model.LastTransformer.Model;
modelParams.GetClusterCentroids(ref centroids, out int k);
//Printing coordinates of the centroids
for (int i = 0; i < centroids.Length; i++)
{
 Console.WriteLine($"Centroid #{i + 1} is located at " +  $@"({centroids[i].GetValues().ToArray()
				  .Select(t => t.ToString("F2"))
				  .Aggregate((f, s) => f + "," + s)})");
}