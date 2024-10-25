using System.Text;

namespace LINQSamples
{
  public class ProductStats
  {
    #region Constructor
    public ProductStats()
    {
      TotalProducts = 0;
      TotalListPrice = 0;
      MinListPrice = decimal.MaxValue;
      MaxListPrice = decimal.MinValue;
      AverageListPrice = decimal.MaxValue;
    }
    #endregion

    public string Size { get; set; }
    public int TotalProducts { get; set; }
    public decimal TotalListPrice { get; set; }
    public decimal MinListPrice { get; set; }
    public decimal MaxListPrice { get; set; }
    public decimal AverageListPrice { get; set; }

    #region Accumulate Method
    public ProductStats Accumulate(Product prod)
    {
      // Increment total number of products
      TotalProducts += 1;

      // Add to total list price
      TotalListPrice += prod.ListPrice;

      // Calculate Min and Max
      MinListPrice = Math.Min(MinListPrice, prod.ListPrice);
      MaxListPrice = Math.Max(MaxListPrice, prod.ListPrice);

      return this;
    }
    #endregion

    #region ComputeAverage Method
    public ProductStats ComputeAverage()
    {
      AverageListPrice = TotalListPrice / TotalProducts;

      return this;
    }
    #endregion

    #region ToString Override
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"Size: {Size}");
      sb.AppendLine($"Total Products: {TotalProducts}");
      sb.AppendLine($"Minimum List Price: {MinListPrice:c}");
      sb.AppendLine($"Maximum List Price: {MaxListPrice:c}");
      sb.AppendLine($"Average List Price: {AverageListPrice:c}");

      return sb.ToString();
    }
    #endregion
  }
}
