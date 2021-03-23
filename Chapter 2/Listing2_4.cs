public class ModelInput
{
 [ColumnName("sepallength"), LoadColumn(0)]
 public float Sepallength { get; set; }
 [ColumnName("sepalwidth"), LoadColumn(1)]
 public float Sepalwidth { get; set; }
 [ColumnName("petallength"), LoadColumn(2)]
 public float Petallength { get; set; }
 [ColumnName("petalwidth"), LoadColumn(3)]
 public float Petalwidth { get; set; }
 [ColumnName("variety"), LoadColumn(4)]
 public string Variety { get; set; }
}