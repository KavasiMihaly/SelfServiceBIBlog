//Name: Available in MDX (on/off)
//Tooltip: Turn on or off the Available in MDX feature
//Enable: Column,Table
 
foreach(var c in Selected.Columns)
{
  if (c.IsAvaliableInMDX)
  {
      c.IsAvaliableInMDX = false;
  }
  else c.IsAvaliableInMDX = true;
}