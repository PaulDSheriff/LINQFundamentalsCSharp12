namespace LINQSamples
{
  public static class ProductHelper
  {
    #region ByColor
    public static IEnumerable<Product> ByColor(this IEnumerable<Product> query, string color)
    {
      return query.Where(p => p.Color == color);
    }
    #endregion
  }
}
