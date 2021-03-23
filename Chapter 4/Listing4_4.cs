 public class BostonHouse
 {
	 /// <summary>
	 /// CRIM - per capita crime rate by town
	 /// </summary>
	 [LoadColumn(0), ColumnName("crim") ]
	 public float CRIM { get; set; }
	 /// <summary>
	 /// proportion of residential land zoned for lots over 25,000 sq. ft.
	 /// </summary>
	 [LoadColumn(1), ColumnName("zn")]
	 public float ZN { get; set; }
	 /// <summary>
	 /// proportion of nonretail business acres per town
	 /// </summary>
	 [LoadColumn(2), ColumnName("indus")]
	 public float INDUS { get; set; }
	 /// <summary>
	 /// Charles River dummy variable (1 if tract bounds river; 0 otherwise)
	 /// </summary>
	 [LoadColumn(3),ColumnName("chas")]
	 public float CHAS { get; set; }
	 /// <summary>
	 /// nitric oxides concentration (parts per 10 million)
	 /// </summary>
	 [LoadColumn(4), ColumnName("nox")]
	 public float NOX { get; set; }
	 /// <summary>
	 /// average number of rooms per dwelling
	 /// </summary>
	 [LoadColumn(5), ColumnName("rm")]
	 public float RM { get; set; }
	 /// <summary>
	 /// proportion of owner-occupied units built prior to 1940
	 /// </summary>
	 [LoadColumn(6), ColumnName("age")]
	 public float Age { get; set; }
	 /// <summary>
	 /// weighted distances to five Boston employment centers
	 /// </summary>
	 [LoadColumn(7), ColumnName("dis")]
	 public float DIS { get; set; }
	 /// <summary>
	 /// index of accessibility to radial highways
	 /// </summary>
	 [LoadColumn(8),ColumnName("rad")]
	 public float RAD { get; set; }
	 /// <summary>
	 /// full-value property-tax rate per $10,000
	 /// </summary>
	 [LoadColumn(9), ColumnName("tax")]
	 public float TAX { get; set; }
	 /// <summary>
	 /// pupil-teacher ratio by town
	 /// </summary>
	 [LoadColumn(10) , ColumnName("ptratio")]
	 public float PTRATIO { get; set; }
	 /// <summary>
	 /// 1000(Bk - 0.63)^2 where Bk is the proportion of blacks by town
	 /// </summary>
	 [LoadColumn(11), ColumnName("b")]
	 public float B { get; set; }
	 /// <summary>
	 /// % lower status of the population
	 /// </summary>
	 [LoadColumn(12), ColumnName("lstat")]
	 public float LSTAT { get; set; }
	 [LoadColumn(13), ColumnName("medv")]
	 public float Medv { get; set; }
 }