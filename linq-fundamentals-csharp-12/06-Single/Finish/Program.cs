using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

try
{
  // Call Sample Method
  var result = vm.SingleOrDefaultQuery();

  // Display Results
  vm.Display(result);
}
catch (ArgumentNullException ex)
{
  // This collection was null
  vm.Display(ex);
}
catch (InvalidOperationException ex)
{
  // First()/Last() methods = No item was found that matches the criteria
  // Single*() methods = Multiple values were found
  vm.Display(ex);
}
catch (Exception ex)
{
  // Catch-all exception
  vm.Display(ex);
}