namespace LINQSamples {
  public class ViewModelBase {
    #region GetProducts Method
    protected List<Product> GetProducts() {
      // Load all Product Data
      return ProductRepository.GetAll();
    }
    #endregion

    #region GetSales Method
    protected List<SalesOrder> GetSales() {
      // Load all Sales Data
      return SalesOrderRepository.GetAll();
    }
    #endregion

    #region Display Methods
    protected void DisplayStop() {
      Console.ReadKey();
    }

    public void Display(List<Product> products) {
      foreach (Product product in products) {
        Console.Write(product);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {products.Count}");
      DisplayStop();
    }

    public void Display(List<SalesOrder> sales)
    {
      foreach (SalesOrder sale in sales)
      {
        Console.Write(sale);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Sales: {sales.Count}");
      DisplayStop();
    }

    public void Display(List<Product[]> collection) {
      int count = 1;
      foreach (Product[] products in collection) {
        Console.WriteLine($"Chunk: {count++}");
        Console.WriteLine(new string('-', 40));
        foreach (Product product in products) {
          Console.Write(product);
        }
      }
      DisplayStop();
    }

    public void Display(List<IGrouping<string, Product>> collection) {
      // Loop through each size
      foreach (var group in collection) {
        // The value in the 'Key' property is 
        // whatever data you grouped upon
        Console.WriteLine($"Size: {group.Key}  Count: {group.Count()}");

        // Loop through the products in each size
        foreach (Product product in group) {
          Console.Write($"  ProductID: {product.ProductID}");
          Console.Write($"  Name: {product.Name}");
          Console.WriteLine($"  Color: {product.Color}");
        }
      }
      DisplayStop();
    }

    public void Display(List<ProductOrder> products) {
      foreach (ProductOrder product in products) {
        Console.Write(product);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products: {products.Count}");
      DisplayStop();
    }

    public void Display(List<ProductStats> products) {
      foreach (ProductStats product in products) {
        Console.WriteLine(product);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Product Sizes: {products.Count}");
      DisplayStop();
    }

    public void Display(List<SaleProducts> sales) {
      foreach (SaleProducts sale in sales) {
        Console.WriteLine($"Sales ID: {sale.SalesOrderID}");

        if (sale.Products.Count > 0) {
          // Loop through the products in each sale
          foreach (Product prod in sale.Products) {
            Console.Write($"  ProductID: {prod.ProductID}");
            Console.Write($"  Name: {prod.Name}");
            Console.WriteLine($"  Color: {prod.Color}");
          }
        } else {
          Console.WriteLine("   Product ID not found for this sale.");
        }
      }

      Console.WriteLine();
      Console.WriteLine($"Total Sales: {sales.Count}");
      DisplayStop();
    }

    public void Display(List<ProductSales> products) {
      foreach (ProductSales product in products) {
        Console.Write(product.Product);

        if (product.Sales.Any()) {
          Console.WriteLine("** Orders for this Product **");
          // Loop through the products in each sale
          foreach (SalesOrder sale in product.Sales) {
            Console.Write(sale);
          }
        } else {
          Console.WriteLine("   ** No Sales for this Product **");
        }
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine($"Total Products/Sales: {products.Count}");
      DisplayStop();
    }

    public void Display(List<string> items) {
      foreach (string item in items) {
        Console.WriteLine(item);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Items: {items.Count}");
      DisplayStop();
    }

    public void Display(List<int> items) {
      foreach (int item in items) {
        Console.WriteLine(item);
      }

      Console.WriteLine();
      Console.WriteLine($"Total Items: {items.Count}");
      DisplayStop();
    }

    public void Display(Product product) {
      Console.WriteLine(product);
      DisplayStop();
    }

    public void Display(Exception ex)
    {
      Console.WriteLine(ex.ToString());
      DisplayStop();
    }

    public void Display(string value) {
      Console.WriteLine($"Value is '{value}'");
      DisplayStop();
    }

    public void Display(int value) {
      Console.WriteLine($"Value is '{value}'");
      DisplayStop();
    }

    public void Display(decimal value) {
      Console.WriteLine($"Value is '{value:c}'");
      DisplayStop();
    }

    public void Display(bool value) {
      Console.WriteLine($"Value is '{value}'");
      DisplayStop();
    }
    #endregion
  }
}
