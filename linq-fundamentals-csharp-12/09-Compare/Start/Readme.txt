To run this project in Visual Studio Code, open the LINQSamples.code-workspace
  When prompted to add "Required Assets", Click the 'Yes' button
  Run the project
  Check the DEBUG CONSOLE window for the output
To run this project in Visual Studio 2022, open the LINQSamples.sln
  Run the project
  A console window shows the output


SampleViewModel Samples
--------------------------------------------------
SequenceEqualIntegers() - SequenceEqual() compares two different collections to see if they are equal
SequenceEqualObjects() - When using a collection of objects, SequenceEqual() performs a comparison to see if the two object references point to the same object
SequenceEqualUsingComparer() - Use an EqualityComparer class to determine if the objects are the same based on the values in properties

ExceptIntegers() - Find all values in one list that are not in the other list
ExceptProductSales() - Find all products that do not have sales
ExceptUsingComparer() - Find all products that are in one list but not the other using a comparer class

ExceptBy() - Find products within a collection that DO NOT compare to a List<string> against a specified property in the collection.
ExceptByProductSales() - Find all products that do not have sales using a 'int' key selector

IntersectIntegers() - Intersect() finds all values in one list that are also in the other list
IntersectProductSales() - Find all products that have sales
IntersectUsingComparer() - Find all products that are in common between two collections using a comparer class

IntersectBy() - Find products within a collection by comparing a List<string> against a specified property in the collection.
IntersectByProductSalesMethod() - Find all products that have sales using a 'int' key selector