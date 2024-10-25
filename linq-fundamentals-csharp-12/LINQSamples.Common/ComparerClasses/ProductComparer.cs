namespace LINQSamples
{
  public class ProductComparer : EqualityComparer<Product>
  {
    public override bool Equals(Product x, Product y)
    {
      // Compare each property to the other to determine equality
      return (x.ProductID == y.ProductID &&
              x.Name == y.Name &&
              x.Color == y.Color &&
              x.Size == y.Size &&
              x.ListPrice == y.ListPrice &&
              x.StandardCost == y.StandardCost);
    }

    public override int GetHashCode(Product obj)
    {
      string value = obj.ProductID.ToString() + 
        obj.Name + 
        obj.Color + 
        obj.Size + 
        obj.ListPrice.ToString() + 
        obj.StandardCost.ToString();

      return value.GetHashCode();
    }
  }
}
