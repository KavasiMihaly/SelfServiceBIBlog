//Name: Hide numeric Columns
//Tooltip: Hide all numeric columns from selected tables
//Enable: Table
//Created by Mihaly Kavasi
//Tabular Editor version 2.16.0

//This could be used to hide all the numeric columns from fact tables to encourage to use of explicit measures instead.
foreach(var t in Selected.Tables)
{
    foreach(var c in t.Columns)
    {
        if(c.DataType == DataType.Decimal || c.DataType == DataType.Double || c.DataType == DataType.Int64)
        {    
        c.IsHidden = true;
        }
    }
}