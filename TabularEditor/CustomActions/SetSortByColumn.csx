//Name: Set sort by
//Tooltip: Select 2 columns to set sort the first by the last
//Enable: Column
//Created by Mihaly Kavasi
//Tabular Editor version 2.16.5

var c = Selected.Columns;
if (c.Count() == 2)
{
    var first = c.First();
    var last = c.Last();
    first.SortByColumn = last;
    
};
if (c.Count() != 2)
{    
    Output("Select 2 Column to perform the action");
}