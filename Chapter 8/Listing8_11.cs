public class ModelInput 
{
	[ColumnName("userId"), LoadColumn(0)]
	public float UserId {get;set;}
	
	[ColumnName("movieId"), LoadColumn(1)]
	public float MovieId {get;set;}
	
	[ColumnName("rating"),LoadColumn(2)]
	public float Rating {get;set;}
	
	[ColumnName("timestamp"),LoadColumn(3)]
	public float Timestamp {get;set;}
}