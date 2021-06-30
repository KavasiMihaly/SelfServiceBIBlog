//Name: Organize ID Columns
//Tooltip: Puts ID columns in an id folder and hides them.
//Enable: Model
//Created by Mihaly Kavasi
//Tabular Editor version 2.16.0

foreach(var c in Model.AllColumns)
{
    if(c.Name.ToLower().Contains("id"))
    {
        c.DisplayFolder = "_IDs";
        c.IsHidden = true;
    }
   
}