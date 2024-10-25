using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
var result = vm.GetAllQuery();

// Display Results
vm.Display(result);