//Name of the provider has to be given as "System.Data.SqlClient"
DbProviderFactory factory =  DbProviderFactories.GetFactory("System.Data.SqlClient");
DatabaseSource = new DatabaseSource(factory, "<connection string>","select * from IRIS");
IDataView trainingView = mlContext.Data.CreateDatabaseLoader<ModelInput>()
                                       .Load(databaseSource);
