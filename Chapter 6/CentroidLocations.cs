List<double> CentroidLocations(List<List<double>> points)
=> Enumerable.Range(0,points[0].Count)
 .Select(z => points.Select(p =>p[z]).ToList())
 .Select(z => z.Average())
 .ToList();