namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region WhereQuery
    /// <summary>
    /// Filter products using where. If the data is not found, an empty list is returned
    /// </summary>
    public List<Product> WhereQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list;

      // Write Query Syntax Here
      list = (from prod in products
              where prod.Name.StartsWith("S")
              select prod).ToList();

      return list;
    }
    #endregion

    #region WhereMethod
    /// <summary>
    /// Filter products using where. If the data is not found, an empty list is returned
    /// </summary>
    public List<Product> WhereMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list;

      // Write Method Syntax Here
      list = products.Where(prod => prod.Name.StartsWith("S")).ToList();

      return list;
    }
    #endregion

    #region WhereTwoFieldsQuery
    /// <summary>
    /// Filter products using where with two fields. If the data is not found, an empty list is returned
    /// </summary>
    public List<Product> WhereTwoFieldsQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list;

      // Write Query Syntax Here
      list = (from prod in products
              where prod.Name.StartsWith("L") && prod.StandardCost > 200
              select prod).ToList();

      return list;
    }
    #endregion

    #region WhereTwoFieldsMethod
    /// <summary>
    /// Filter products using where with two fields. If the data is not found, an empty list is returned
    /// </summary>
    public List<Product> WhereTwoFieldsMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list;

      // Write Method Syntax Here
      list = products.Where(prod => prod.Name.StartsWith("L") &&
                                    prod.StandardCost > 200).ToList();

      return list;
    }
    #endregion

    #region WhereExtensionQuery
    /// <summary>
    /// Filter products using a custom extension method
    /// </summary>
    public List<Product> WhereExtensionQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list;

      // Write Query Syntax Here
      list = (from prod in products
              select prod).ByColor("Red").ToList();

      return list;
    }
    #endregion

    #region WhereExtensionMethod
    /// <summary>
    /// Filter products using a custom extension method
    /// </summary>
    public List<Product> WhereExtensionMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list;

      // Write Method Syntax Here
      list = products.ByColor("Red").ToList();

      return list;
    }
    #endregion
  }
}
