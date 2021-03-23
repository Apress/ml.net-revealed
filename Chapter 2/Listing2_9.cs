var pipeLine  = context.Transforms.NormalizeMinMax("crim","crim")
                       .Append(context.Transforms.NormalizeMinMax("zn","zn"))
					   .Append(context.Transforms.NormalizeMinMax("indus","indus"))
					   .Append(context.Transforms.NormalizeMinMax("indus","chas"))
					   .Append(context.Transforms.NormalizeMinMax("indus","chas"))
					   .Append(context.Transforms.NormalizeMinMax("indus","nox"))
					   .Append(context.Transforms.NormalizeMinMax("indus","rm"))
					   .Append(context.Transforms.NormalizeMinMax("indus","age"))
					   .Append(context.Transforms.Concatenate("Features","crim","zn","indus","chas","nox","rm","age"))
					   .Append(context.Regression.Trainers.OnlineGradientDescent(labelColumnName:"medv", featureColumnName:"Features",
                            lossFunction: null, learningRate:0.24f, decreaseLearningRate:true));

var model = pipeLine.Fit(trainingDataView);
var predEngine = context.Model.CreatePredictionEngine<BostonHouse,BostonHousePrice>(model);

					   
					   
					   
					   