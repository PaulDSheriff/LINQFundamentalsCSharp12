To run this project in Visual Studio Code, open the LINQSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the LINQSamples.sln
  Run the project
  A console window shows the output


SampleViewModel Samples
--------------------------------------------------
GroupBy() - Group all products by size.
GroupByInto() - Same as GroupBy just uses the 'into' keyword.
GroupByUsingKey() - Order by the 'Key' property
GroupByWhere() - Search for those sizes with 2 or more products. Simulates a SQL HAVING clause.
GroupedSubquery() - Group Sales by SalesOrderID, add Products into new Sales Order object using a subquery.

Extra Sample Not Recorded
GroupByDistinct() - The Distinct() operator can be simulated using the GroupBy() and FirstOrDefault() operators