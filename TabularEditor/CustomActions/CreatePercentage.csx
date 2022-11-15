//Name: Create %
//Tooltip: Creates a % calculation based on the selected measures. (Order of selection matters)
//Enable: Measure

var m = Selected.Measures;
if (m.Count() == 2)
{
    var first = m.First();
    var last = m.Last();
    var newMeasure = first.Table.AddMeasure(
        "% " + first.Name,                                                                  // Name
        "DIVIDE(" + first.DaxObjectFullName + "," + last.DaxObjectFullName + ")",           // DAX expression
        m.First().DisplayFolder                                                             // Display Folder   
        );
        // Set the format string on the new measure:
    newMeasure.FormatString = "0.00%;-0.00%;0.00%";

        // Provide some documentation:
    newMeasure.Description = "Expression: " +newMeasure.Expression;
};
if (m.Count() != 2)
{    
    Output("Select 2 Measures to perform the action");
}