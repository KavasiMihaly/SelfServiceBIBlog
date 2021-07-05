//Name: Default Measure Description
//Tooltip: Adds expression to the description
//Enable: Model
//Created by Mihaly Kavasi (updated by Ed Hansberry's idea)
//Tabular Editor version 2.16.0

//It is better to format DAX before adding it into the descriptions
foreach(var m in Model.AllMeasures)
{
    if(m.Description == "")
    {    
        m.Description =  "Expression:" + "\n" + m.Expression;
    }
    else if (!m.Description.Contains("Expression"))
    {
        m.Description = m.Description + "\n" + "Expression:" + "\n" + m.Expression;
    }
}