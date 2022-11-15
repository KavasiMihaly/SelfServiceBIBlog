//Name: Show Dependency Tree
//Tooltip: Outputs all the measures and columns needed to create the all measures
//Enable: Model
//Created by Mihaly Kavasi (adapting the script of Elliot Gross https://www.linkedin.com/in/elliot-gross-b440b9120/)
//Tabular Editor version 2.16.1

// Output header row
string output = "Dependent Measure Table\tDependent Measure Folder\tDependent Measure\tDependent Measure Expression\tTable\tReportingFolder\tObject\tObject Type"; 

// Loop through all selected measures:
foreach(var m in Model.AllMeasures) {
    
    // Get a list of ALL objects this measure is dependent on (both directly and indirectly through other measures):
    var allReferences = m.DependsOn.Deep();
  
    // Filter the previous list of references to measure references only and keep only distinct measures:
       var allMeasureReferences = allReferences.OfType<Measure>().Distinct();

    // Add the rows to the output  
     foreach(var dm in allMeasureReferences)
         output += string.Format("\r\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", 
     m.Table.Name, m.DisplayFolder, m.Name, "\"" + m.Expression + "\"",
            dm.Table.Name, dm.DisplayFolder, dm.Name, "Measure"
            );
    // Filter the previous list of references to column references only and keep only distinct columns:        
       var allColumnReferences = allReferences.OfType<Column>().Distinct();
     
     // Add the rows to the output    
     foreach(var dc in allColumnReferences)
         output += string.Format("\r\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", 
            m.Table.Name, m.DisplayFolder, m.Name, "\"" + m.Expression + "\"",
            dc.Table.Name, dc.DisplayFolder, dc.Name, "Column"
            );
  }  
//Output the results to screen    
output.Output();