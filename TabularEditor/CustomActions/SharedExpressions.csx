// Collect Share Expressions information:
var objects = Model.Expressions;
 
// Get their properties:
var tsv = ExportProperties(objects,"Name, Expression, Annotations");
 
// Output to screen (can then be copy-pasted into Excel):
 tsv.Output();