public class ModelInput
{
	[ColumnName("mpg"), LoadColumn(0)]
	public float Mpg {get;set;}
	
	[ColumnName("cylinders"), LoadColumn(1)]
	public float Cylinders {get;set;}
	
	[ColumnName("displacement"), LoadColumn(2)]
	public float Displacement {get;set;}
	
	[ColumnName("horsepower"), LoadColumn(3)]
	public float Horsepower {get;set;}
	
	[ColumnName("weight"), LoadColumn(4)]
	public float Weight {get;set;}
	
	[ColumnName("acceleration"). LoadColumn(5)]
	public float Acceleration {get;set;}
	
	[ColumnName("model year"), LoadColumn(6)]
	public float Model_year {get;set;}
	
	[ColumnName("origin"),LoadColumn(7)]
	public float Origin {get;set;}
	
	[ColumnName("car name"),LoadColumn(8)]
	public string Car_name {get;set;}
}
	
	