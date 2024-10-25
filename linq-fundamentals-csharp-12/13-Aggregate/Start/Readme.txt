To run this project in Visual Studio Code, open the LINQSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the LINQSamples.sln
  Run the project
  A console window shows the output


SampleViewModel Samples
--------------------------------------------------
Count() - Count all rows in collection
CountFiltered() - Count all rows after where clause is applied
Minimum() - Get the minimum value from a numeric column in a collection
Maximum() - Get the maximum value from a numeric column in a collection
MinBy() - Get the minimum value from a numeric column in a collection, return object
MaxBy() - Get the maximum value from a numeric column in a collection, return object
Average() - Get the average value from a numeric column in a collection
Sum() - Get a sum of a numeric column in a collection
AggregateSum() - Use the Aggregate() function to simulate the Sum() operation
AggregateCustom() - Use Sales Orders and calculate the total Sales by multiplying OrderQty * UnitPrice for each order
AggregateUsingGroupBy() - Group products by Size property and calculate min/max/average prices
AggregateMoreEfficient() - Use an accumulator class to be more efficient