//Name: Create AVG
//Tooltip: Creates a AVG measure for every currently selected column and hide the column.
//Enable: Column
 
foreach(var c in Selected.Columns)
{
    c.Table.AddMeasure(
        "Avg of " + c.Name,                    // Name
        "AVERAGE(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder                        // Display Folder
    );
    c.IsHidden = true;
}