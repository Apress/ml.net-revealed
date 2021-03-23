string csvFile = @"C:\MLDOTNET\iris.csv";
var columns = File.ReadLines(csvFile)
				 .Take(1)
				 .First()
				 .Split(new char[]{','});
var firstLine = File.ReadLines(csvFile)
				 .Skip(1)
				 .Take(1)
				 .First()
				 .Split(new char[] { ','});
StringBuilder propertyBuilder = new StringBuilder();
for (int i = 0; i < columns.Length; i++)
{
	string column = columns[i];
	propertyBuilder.AppendLine($"[ColumnName(\"{column},LoadColumn({i})]");
	if(firstLine.ElementAt(i).ToCharArray()
		.All(m => Char.IsDigit(m) || m == '.'))
	{

		propertyBuilder
		.AppendLine($"public float {column.Substring(0, 1).ToUpper() + column.Substring(1)}");
	}
	else
	{
		propertyBuilder.AppendLine($"public string 
		{
			column.Substring(0,1).ToUpper() + column.Substring(1)}");
	}
	propertyBuilder.AppendLine("{ get; set;}");
}
string classCode = @"public class ModelInput " + Environment.NewLine
 + "{" + Environment.NewLine + propertyBuilder.ToString()
 + Environment.NewLine + "}";
 
Console.WriteLine(classCode);