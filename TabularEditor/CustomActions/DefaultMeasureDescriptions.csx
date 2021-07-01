//Name: Default Measure Description
//Tooltip: Adds expression to the description
//Enable: Model
//Created by Mihaly Kavasi
//Tabular Editor version 2.16.0

//It is better to format DAX before adding it into the descriptions
foreach(var m in Model.AllMeasures)
{
    if(m.Description == "")
    {    
        m.Description = "Expression: " + m.Expression;
    }
    else if (!m.Description.Contains("Expression"))
    {
        m.Description = m.Description + " Expression: " + m.Expression;
    }
}