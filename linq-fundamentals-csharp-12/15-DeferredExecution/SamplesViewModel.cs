namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region DeferredExecution
    /// <summary>
    /// Illustrate the concept of LINQ deferred execution using foreach()
    /// </summary>
    public string DeferredExecution()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      // Bring up 'Autos' window in debugger
      System.Diagnostics.Debugger.Break();

      // Write LINQ Query Here
      query = products.Where(p => p.Color == "Red");
      
      // Query is executed here
      //query = query.ToList();

      // Query is executed here
      foreach (ProductSimple product in query)
      {
        Console.WriteLine(product);
      }

      return "Query Executed";
    }
    #endregion

    #region DeferredExecutionEnumerator
    /// <summary>
    /// Illustrate the concept of LINQ deferred execution using GetEnumerator()
    /// </summary>
    public string DeferredExecutionEnumerator()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      // Bring up 'Autos' window in debugger
      System.Diagnostics.Debugger.Break();

      // Write LINQ Query Here
      query = products.Where(p => p.Color == "Red");

      // The following code is equivalent to the foreach()
      // Query is executed here
      IEnumerator<ProductSimple> enumerator = query.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Console.WriteLine(enumerator.Current);
      }

      return "Query Executed";
    }
    #endregion

    #region UsingWhereAndTake
    /// <summary>
    /// Using Where() to filter the collection and adding on Take()
    /// </summary>
    public string UsingWhereAndTake()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      System.Diagnostics.Debugger.Break();

      // Create LINQ query
      query = products.Where(prod => prod.Color == "Red").Take(1);

      // Query is executed here
      // All the products are accessed
      // Only the ones that match the condition are returned
      // The query stops after the number specified in the Take()
      foreach (ProductSimple product in query)
      {
        Console.WriteLine(product);
      }

      return "Query Executed";
    }
    #endregion

    #region UsingSimpleFilter
    /// <summary>
    /// Create a generic filter to illustrate how NOT to write a filter
    /// When written this way, the query executes immediately
    /// Non-Streaming operation
    /// </summary>
    public string UsingSimpleFilter()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      System.Diagnostics.Debugger.Break();

      // Create LINQ query
      // Query is executed here
      query = products.FilterSimple(prod => prod.Color == "Red");

      foreach (ProductSimple product in query)
      {
        Console.WriteLine(product);
      }

      return "Query Executed";
    }
    #endregion

    #region UsingSimpleFilterAndTake
    /// <summary>
    /// Using FilterSimple() to filter the collection and adding on Take()
    /// Non-Streaming operation
    /// </summary>
    public string UsingSimpleFilterAndTake()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      System.Diagnostics.Debugger.Break();

      // Create LINQ query
      // Query is executed here
      // All the products are accessed immediately
      query = products.FilterSimple(prod => prod.Color == "Red").Take(1);

      // Here is where you get the first product from the query
      foreach (ProductSimple product in query)
      {
        Console.WriteLine(product);
      }

      return "Query Executed";
    }
    #endregion

    #region UsingYield
    /// <summary>
    /// Using 'yield' to filter the collection
    /// Streaming operation
    /// </summary>
    public string UsingYield()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      System.Diagnostics.Debugger.Break();

      // Create LINQ query      
      query = products.Filter(prod => prod.Color == "Red");

      // Query is executed here
      // The 'yield' now acts like the Where() operator
      // All products are accessed,
      // but only the ones that match the condition are returned
      foreach (ProductSimple product in query)
      {
        Console.WriteLine(product);
      }

      return "Query Executed";
    }
    #endregion

    #region UsingYieldAndTake
    /// <summary>
    /// Using 'yield' to filter the collection and adding on Take()
    /// Streaming operation
    /// </summary>
    public string UsingYieldAndTake()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      System.Diagnostics.Debugger.Break();

      // Create LINQ query
      query = products.Filter(prod => prod.Color == "Red").Take(1);

      // Query is executed here
      // You see the products are accessed in order
      // Only the ones that match the condition are returned
      // The query stops after the number specified in the Take()
      foreach (ProductSimple product in query)
      {
        Console.WriteLine(product);
      }

      return "Query Executed";
    }
    #endregion

    #region UsingYieldAndOrderBy
    /// <summary>
    /// Adding the OrderBy() forces one complete iteration through collection to sort the data before the filtering can happen
    /// Non-Streaming operation because of the OrderBy
    /// </summary>
    public string UsingYieldAndOrderBy()
    {
      IEnumerable<ProductSimple> query;
      // Load all Product Data
      List<ProductSimple> products = ProductSimpleRepository.GetAll();

      System.Diagnostics.Debugger.Break();

      // Create LINQ query
      query = products.Filter(prod => prod.Color == "Red").ToList();

   query = query.OrderBy(prod => prod.Name);

      // Query is executed here
      // Products are all ordered first
      // Only the ones that match the condition are returned
      foreach (ProductSimple product in query)
      {
        Console.WriteLine(product);
      }

      return "Query Executed";
    }
    #endregion  
  }
}
