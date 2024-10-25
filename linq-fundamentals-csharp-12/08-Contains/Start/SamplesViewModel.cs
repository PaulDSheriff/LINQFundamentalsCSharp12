namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region AllQuery
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllQuery()
    {
      List<Product> products = GetProducts();
      bool value = false;

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region AllMethod
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllMethod()
    {
      List<Product> products = GetProducts();
      bool value = false;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region AllSalesQuery
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllSalesQuery()
    {
      List<SalesOrder> sales = GetSales();
      bool value = false;

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region AllSalesMethod
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllSalesMethod()
    {
      List<SalesOrder> sales = GetSales();
      bool value = false;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region AnyQuery
    /// <summary>
    /// Use Any() to see if at least one item in a collection meets a specified condition
    /// </summary>
    public bool AnyQuery()
    {
      List<SalesOrder> sales = GetSales();
      bool value = false;

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region AnyMethod
    /// <summary>
    /// Use Any() to see if at least one item in a collection meets a specified condition
    /// </summary>
    public bool AnyMethod()
    {
      List<SalesOrder> sales = GetSales();
      bool value = false;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region ContainsQuery
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value
    /// </summary>
    public bool ContainsQuery()
    {
      List<int> numbers = new() { 1, 2, 3, 4, 5 };
      bool value = false;

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region ContainsMethod
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value
    /// </summary>
    public bool ContainsMethod()
    {
      List<int> numbers = new() { 1, 2, 3, 4, 5 };
      bool value = false;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region ContainsComparerQuery
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value
    /// </summary>
    public bool ContainsComparerQuery()
    {
      List<Product> products = GetProducts();
      ProductIdComparer pc = new();
      bool value = false;

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region ContainsComparerMethod
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value.
    /// When comparing classes, you need to write a EqualityComparer class.
    /// </summary>
    public bool ContainsComparerMethod()
    {
      List<Product> products = GetProducts();
      ProductIdComparer pc = new();
      bool value = false;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion
  }
}
