To run this project in Visual Studio Code, open the LINQSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the LINQSamples.sln
  Run the project
  A console window shows the output


SampleViewModel Samples
--------------------------------------------------
InnerJoin() - Join a Sales Order Detail collection with Products into anonymous class. This is an equijoin or an inner join.
InnerJoinTwoFields() - Join a Sales Order Detail collection with Products using two fields.
JoinIntoQuery() - Use 'into' to create a new object with a Sales collection for each Product
LeftOuterJoin() - Perform a left join between Products and Sales using DefaultIfEmpty() and SelectMany().
