using System.Text;

namespace LINQSamples
{
  public partial class ProductOrder
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string Size { get; set; }
    public int? SalesOrderID { get; set; }
    public short? OrderQty { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? LineTotal { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"{Name}  ID: {ProductID}");
      sb.AppendLine($"   Color: {Color}   Size: {(Size ?? "n/a")}");
      sb.AppendLine($"   Cost: {StandardCost:c}   Price: {ListPrice:c}");
      sb.AppendLine($"   Size: {Size}");
      if (SalesOrderID.HasValue)
      {
        sb.AppendLine($"   Order ID: {SalesOrderID}");
      }
      else
      {
        sb.AppendLine("   ** NO SALES FOR THIS PRODUCT **");
      }    
      if (OrderQty.HasValue)
      {
        sb.AppendLine($"   Order Qty: {OrderQty}");
      }
      if (LineTotal.HasValue)
      {
        sb.AppendLine($"   Total: {LineTotal:c}");
      }
      return sb.ToString();
    }
    #endregion
  }
}
