//Name: Hide all relationship columns
//Tooltip: Hide all columns on many side of a join
//Enable: Model
//Created by Mihaly Kavasi (originally from Matt Allington, https://exceleratorbi.com.au)
//Tabular Editor version 2.16.0

foreach (var r in Model.Relationships)
{
    var c = r.FromColumn.Name;
    var t = r.FromTable.Name;
    Model.Tables[t].Columns[c].IsHidden = true;
}