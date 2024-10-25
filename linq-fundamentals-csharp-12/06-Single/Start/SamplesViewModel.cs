namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region FirstQuery
    /// <summary>
    /// Locate a specific product using First(). First() searches forward in the collection.
    /// NOTE: First() throws an exception if the result does not produce any values
    /// Use First() when you know or expect the sequence to have at least one element.
    /// Exceptions should be exceptional, so try to avoid them.
    /// </summary>
    public Product FirstQuery()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Query Syntax Here

      // Test the exception handling

      return value;
    }
    #endregion

    #region FirstMethod
    /// <summary>
    /// Locate a specific product using First(). First() searches forward in the collection.
    /// NOTE: First() throws an exception if the result does not produce any values
    /// Use First() when you know or expect the sequence to have at least one element.
    /// Exceptions should be exceptional, so try to avoid them.
    /// </summary>
    public Product FirstMethod()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Method Syntax Here
      
      return value;
    }
    #endregion

    #region FirstOrDefaultQuery
    /// <summary>
    /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
    /// NOTE: FirstOrDefault() returns a null if no value is found
    /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
    /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
    /// </summary>
    public Product FirstOrDefaultQuery()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Query Syntax Here

      // Test the exception handling

      return value;
    }
    #endregion

    #region FirstOrDefaultMethod
    /// <summary>
    /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
    /// NOTE: FirstOrDefault() returns a null if no value is found
    /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
    /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
    /// </summary>
    public Product FirstOrDefaultMethod()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Method Syntax Here

      return value;
    }
    #endregion

    #region FirstOrDefaultWithDefaultQuery
    /// <summary>
    /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
    /// NOTE: You may specify the return value with FirstOrDefault() if not found
    /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
    /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
    /// </summary>
    public Product FirstOrDefaultWithDefaultQuery()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Query Syntax Here
     
      // Test the exception handling
      
      return value;
    }
    #endregion

    #region FirstOrDefaultWithDefaultMethod
    /// <summary>
    /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
    /// NOTE: You may specify the return value with FirstOrDefault() if not found
    /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
    /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
    /// </summary>
    public Product FirstOrDefaultWithDefaultMethod()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Method Syntax Here

      return value;
    }
    #endregion

    #region LastQuery
    /// <summary>
    /// Locate a specific product using Last(). Last() searches from the end of the list backwards.
    /// NOTE: Last returns the last value from a collection, or throws an exception if no value is found
    /// </summary>
    public Product LastQuery()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Query Syntax Here
      
      // Test the exception handling
      
      return value;
    }
    #endregion

    #region LastMethod
    /// <summary>
    /// Locate a specific product using Last(). Last() searches from the end of the list backwards.
    /// NOTE: Last returns the last value from a collection, or throws an exception if no value is found
    /// </summary>
    public Product LastMethod()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region LastOrDefaultQuery
    /// <summary>
    /// Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards.
    /// NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
    /// </summary>
    public Product LastOrDefaultQuery()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Query Syntax Here
     

      // Test the exception handling
     
      return value;
    }
    #endregion

    #region LastOrDefaultMethod
    /// <summary>
    /// Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards.
    /// NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
    /// </summary>
    public Product LastOrDefaultMethod()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region SingleQuery
    /// <summary>
    /// Locate a specific product using Single().
    /// NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
    /// Single() always searches the complete collection
    /// </summary>
    public Product SingleQuery()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Query Syntax Here

      // Test the exception handling for finding multiple values

      // Test the exception handling for the list is null

      return value;
    }
    #endregion

    #region SingleMethod
    /// <summary>
    /// Locate a specific product using Single().
    /// NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
    /// Single() always searches the complete collection
    /// </summary>
    public Product SingleMethod()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Method Syntax Here

      return value;
    }
    #endregion

    #region SingleOrDefaultQuery
    /// <summary>
    /// Locate a specific product using SingleOrDefault()
    /// NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.
    /// SingleOrDefault() always searches the complete collection
    /// </summary>
    public Product SingleOrDefaultQuery()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Query Syntax Here


      // Test the exception handling for finding multiple values


      // Test the exception handling for the list is empty

      // Test the exception handling for the list is empty and a default value is supplied

      // Test the exception handling for the list is null
     

      return value;
    }
    #endregion

    #region SingleOrDefaultMethod
    /// <summary>
    /// Locate a specific product using SingleOrDefault()
    /// NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.
    /// SingleOrDefault() always searches the complete collection
    /// </summary>
    public Product SingleOrDefaultMethod()
    {
      List<Product> products = GetProducts();
      Product value = null;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion
  }
}
