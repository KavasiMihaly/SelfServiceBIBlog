string tsv = "Dependent Measure Table\tDependent Measure Folder\tDependent Measure\tTable\tReportingFolder\tObject\tObject Type"; 
// TSV file header row


// Loop through all measures:
foreach(var m in Selected.Measures) {
    
    // Get a list of ALL objects referenced by this measure (both directly and indirectly through other measures):
    var allReferences = m.DependsOn.Deep();
  
    // Filter the previous list of references to table references only. For column references, let's get th
    // table that each column belongs to. Finally, keep only distinct tables:
       var allMeasureReferences = allReferences.OfType<Measure>().Distinct();
        
    //allMeasureReferences.Output();
      
     foreach(var dm in allMeasureReferences)
         tsv += string.Format("\r\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", 
            m.Table.Name, m.DisplayFolder, m.Name,
            dm.Table.Name, dm.DisplayFolder, dm.Name, "Measure"
            );
            
       var allColumnReferences = allReferences.OfType<Column>().Distinct();
       
     foreach(var dc in allColumnReferences)
         tsv += string.Format("\r\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", 
            m.Table.Name, m.DisplayFolder, m.Name,
            dc.Table.Name, dc.DisplayFolder, dc.Name, "Column"
            );
  }    
tsv.Output();