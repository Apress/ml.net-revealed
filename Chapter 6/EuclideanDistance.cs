double EuclideanDistance(List<double> p, List<double> q)
 => Math.Sqrt(p.Zip(q,(px,qx) =>
 Math.Pow(px - qx,2)).Sum());