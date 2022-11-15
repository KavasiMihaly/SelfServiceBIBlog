//Name: Create Base Column folders
//Tooltip: Puts columns into an other columns folder. ID columns in an id folder and hides them.
//Enable: Model
 
foreach(var c in Model.AllColumns)
{
    c.DisplayFolder = "Other Columns";
    
    if(c.Name.ToLower().Contains("id"))
    {
        c.DisplayFolder = "IDs";
        c.IsHidden = true;
    }
   
}