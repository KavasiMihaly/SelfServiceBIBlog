//Name: Format measures
//Tooltip: Format measures that does not have a format already
//Enable: Model
//Created by Mihaly Kavasi
//Tabular Editor version 2.16.0

foreach(var m in Model.AllMeasures)
{
    if (m.FormatString == "" && m.DataType == DataType.Decimal || m.FormatString == "" && m.DataType == DataType.Double)
    {  
        m.FormatString = "#,0.00";
    }
    if (m.FormatString == "" && m.DataType == DataType.Int64)
    {   
        m.FormatString = "#,0";
    }
    if (m.FormatString == "" && m.Name.Contains("%"))
    {
        m.FormatString = "0.0%;-0.0%;0.0%";
    }
}
