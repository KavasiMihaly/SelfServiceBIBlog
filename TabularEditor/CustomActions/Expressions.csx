// Collect Share Expressions information:
var objects = Model.Expressions.Cast<ITabularNamedObject>().Concat(Model.AllPartitions);
 
// Get their properties:
var tsv = ExportProperties(objects,"Name,Expression");
 
// Output to screen (can then be copy-pasted into Excel):
 tsv.Output();