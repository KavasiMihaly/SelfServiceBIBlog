// Collect Relationship information:
var objects = Model.Relationships;
 
// Get their properties:
var tsv = ExportProperties(objects,"Name");
 
// Output to screen (can then be copy-pasted into Excel):
 tsv.Output();