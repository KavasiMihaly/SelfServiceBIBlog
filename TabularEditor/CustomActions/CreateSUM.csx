//Name: Create SUM
//Tooltip: Creates a SUM measure for every currently selected column and hide the column.
//Enable: Column
 
foreach(var c in Selected.Columns)
{
    c.Table.AddMeasure(
        "Sum of " + c.Name,                    // Name
        "SUM(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder                        // Display Folder
    );
    c.IsHidden = true;
}