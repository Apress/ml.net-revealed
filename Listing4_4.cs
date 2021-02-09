public class BostonHouse   
{ 
  /// <summary>        
  /// CRIM - per capita crime rate by town       
  /// </summary>        
  [LoadColumn(0), ColumnName("crim") ]        
  public float CRIM { get; set; }        
  /// <summary>        
  ///  proportion of residential land zoned for lots over  25,000 sq. ft.        
  /// </summary>        
  [LoadColumn(1), ColumnName("zn")]
  public float ZN { get; set; }
 }
