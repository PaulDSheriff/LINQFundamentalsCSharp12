namespace LINQSamples
{
  public class ProductSimpleRepository
  {
    #region GetAll Method
    public static List<ProductSimple> GetAll()
    {
      return new List<ProductSimple>
      {
        new ProductSimple {
          Name = "Sport-100 Helmet",
          Color = "Red"
        },
        new ProductSimple {
          Name = "Road Frame",
          Color = "Black",
        },
        new ProductSimple {
          Name = "Long Sleeve Logo Jersey",
          Color = "Red"
        },
        new ProductSimple {
          Name = "Mountain Frame",
          Color = "Silver"
        }
      };
    }
    #endregion
  }
}