//Name: Numeric column to Do not summarize
//Tooltip: Change all numeric columns to do not summarize
//Enable: Model
//Created by Mihaly Kavasi
//Tabular Editor version 2.16.0

foreach (var c in Model.AllColumns)
{
    if(c.DataType == DataType.Decimal ||  c.DataType == DataType.Double || c.DataType == DataType.Int64)
    {  
    c.SummarizeBy = AggregateFunction.None;
    }
}