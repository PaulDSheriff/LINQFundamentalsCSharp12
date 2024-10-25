To run this project in Visual Studio Code, open the LINQSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the LINQSamples.sln
  Run the project
  A console window shows the output


For these demos, the ProductSimple and ProductSimpleRepository classes are used


SampleViewModel Samples
--------------------------------------------------
DeferredExecution() - Illustrate the concept of LINQ deferred execution using foreach method
DeferredExecutionEnumerator() - Illustrate the concept of LINQ deferred execution using the GetEnumerator() method

UsingWhere() - Use Where() to filter the collection (Streaming Operation)
UsingWhereAndTake() - Using Where() to filter the collection and adding on Take() (Streaming Operation)

UsingSimpleFilter() - Create a generic filter to illustrate how NOT to write a filter (Non-Streaming Operation)
UsingSimpleFilterAndTake() - Use FilterSimple() and Take(1) - (Non-Streaming Operation)

UsingYield() - The correct way to write a generic filter is to use the 'yield' keyword (Streaming Operation)
UsingYieldAndTake() - Apply the Take(1) expression to your custom filter using 'yield' (Streaming Operation)

UsingOrderBy() - Adding OrderBy() forces one complete iteration through collection to sort the data before the filtering can happen (Non-Streaming Operation)


Streaming vs. Non-Streaming Expressions
--------------------------------------------------
Streaming: Concat(), Except(), GroupJoin, Intersect, Join, OfType, Range, Repeat, Select, SelectMany, Skip, SkipWhile, Take, TakeWhile, Union, Where
Non-Streaming: Except, GroupBy, GroupJoin, Intersect, Join, OrderBy, OrderByDescending, Reverse, ThenBy, ThenByDescending

For those methods that are in both lists, they will be evaluated in a streaming manner first