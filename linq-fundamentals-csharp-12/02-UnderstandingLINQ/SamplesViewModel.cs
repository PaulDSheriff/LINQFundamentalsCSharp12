namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region FilterRows
    /// <summary>
    /// Write Non-LINQ code to get a subset of products
    /// </summary>
    public List<Product> FilterRows()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      foreach (Product product in products)
      {
        if (product.ListPrice > 1000)
        {
          list.Add(product);
        }
      }

      return list;
    }
    #endregion

    #region GetUniqueColors
    /// <summary>
    /// Find all of the distinct/unique colors in the product list
    /// </summary>
    public List<string> GetUniqueColors()
    {
      List<Product> products = GetProducts();
      List<string> list = new();

      foreach (Product product in products)
      {
        if (!list.Contains(product.Color))
        {
          list.Add(product.Color);
        }
      }

      return list;
    }
    #endregion

    #region GetMinimumPriceOfAllProducts
    /// <summary>
    /// Find the lowest price in all products
    /// </summary>
    public decimal GetMinimumPriceOfAllProducts()
    {
      List<Product> products = GetProducts();
      decimal ret = decimal.MaxValue;

      foreach (Product product in products)
      {
        if (product.ListPrice < ret)
        {
          ret = product.ListPrice;
        }
      }

      return ret;
    }
    #endregion
  }
}
