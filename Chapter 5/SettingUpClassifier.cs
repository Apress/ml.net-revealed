var trainer = mlContext.MulticlassClassification.Trainers.OneVersusAll
(
mlContext.BinaryClassification.Trainers.FastTree
 (new FastTreeBinaryTrainer.Options()
 {
 NumberOfLeaves = 26,
 MinimumExampleCountPerLeaf = 1,
 NumberOfTrees = 20,
 LearningRate = 0.05887203f,
 Shrinkage = 3.070639f,
 LabelColumnName = "Salary",
 FeatureColumnName = "Features"
 }),
 labelColumnName: "Salary"
)