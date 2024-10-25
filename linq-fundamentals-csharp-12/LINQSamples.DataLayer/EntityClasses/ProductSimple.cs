using System.Text;

namespace LINQSamples
{
  public class ProductSimple
  {
    private string _Name;
    private string _Color;

    public string Name
    {
      get
      {
        Console.WriteLine($"** Product: {_Name} **");
        return _Name;
      }
      set { _Name = value; }
    }

    public string Color
    {
      get
      {
        Console.WriteLine($"** Color is {_Color} for {_Name} **");
        return _Color;
      }
      set { _Color = value; }
    }

    public override string ToString()
    {
      return $"From Query: {_Name}";
    }
  }
}
