void Main()
{
	 var p = new List<double>(){1,2,3};
	 var q = new List<double>() { 1, 3, 4 };
	 var r = new List<double>() { 1, 2, 31 };
	 var s = new List<double>() { 1, 3, 41 };
	 var t = new List<double>() { 11, 2, 3 };
	 var u = new List<double>() { 1, 31, 4 };
	 var centroid = CentroidLocations(new List<List<double>>()
	 {
		p, q, r, s, t
	 });
	 var distance_centroid_p = EuclideanDistance(centroid,p);
	 var distance_centroid_q = EuclideanDistance(centroid,q);
	 Console.WriteLine($"distance p and centroid =  {distance_centroid_p}");
	 Console.WriteLine($"distance q and centroid =  {distance_centroid_q}");
}