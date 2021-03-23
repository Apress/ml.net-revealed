var loader = mlContext.Data.CreateTextLoader(
	columns: new[]
	{
		new TextLoader.Column("Feature1", DataKind.Single, 0)
		new TextLoader.Column("Feature2", DataKind.Single, 1)
		new TextLoader.Column("Feature3", DataKind.String, 2)
	},
	separatorChar: ',',
	hasHeader: false
);
