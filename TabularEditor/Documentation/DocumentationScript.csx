// Collect all measures, columns, hierarchies and tables (ignore automatically generated entities):
var objects = Model.AllMeasures.Cast<ITabularNamedObject>()
      .Concat(Model.AllColumns.Where(c => !c.Table.Name.Contains("Template") 
                                       && !c.Table.Name.Contains("LocalDate"))
              )
      .Concat(Model.AllHierarchies.Where(h => !h.Table.Name.Contains("Template") 
                                       && !h.Table.Name.Contains("LocalDate"))
              )
      .Concat(Model.AllLevels.Where(h => !h.Table.Name.Contains("Template") 
                                       && !h.Table.Name.Contains("LocalDate"))
              )
      .Concat(Model.Tables);
 
// Get their properties:
var tsv = ExportProperties(objects,"Name,ObjectType,Parent,Description,FormatString,DataType,Expression,IsHidden,DisplayFolder,Synonyms,DataCategory,SourceColumn");
 
// Output to screen (can then be copy-pasted into Excel):
 tsv.Output();