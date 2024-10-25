namespace LINQSamples {
  public class SamplesViewModel : ViewModelBase {
    #region ForEachQuery
    /// <summary>
    /// ForEach allows you to iterate over a collection to perform assignments within each object.
    /// Assign the LineTotal from the OrderQty * UnitPrice
    /// When using the Query syntax, assign the result to a temporary variable.
    /// </summary>
    public List<SalesOrder> ForEachQuery() {
      // Get all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      (from sale in sales
       let tmp = sale.LineTotal = sale.OrderQty * sale.UnitPrice
       select sale).ToList();

      return sales;
    }
    #endregion

    #region ForEachMethod
    /// <summary>
    /// ForEach allows you to iterate over a collection to perform assignments within each object.
    /// Assign the LineTotal from the OrderQty * UnitPrice
    /// </summary>
    public List<SalesOrder> ForEachMethod() {
      // Get all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      sales.ForEach(sale => sale.LineTotal = sale.OrderQty * sale.UnitPrice);

      return sales;
    }
    #endregion

    #region ForEachSubQueryQuery
    /// <summary>
    /// Iterate over each object in the collection and call a sub query to calculate total sales
    /// </summary>
    public List<Product> ForEachSubQueryQuery() {
      // Get all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Get all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      (from prod in products
       let tmp = prod.TotalSales =
         sales.Where(sale => sale.ProductID == prod.ProductID).Sum(sale => sale.LineTotal)
       select prod).ToList();

      return products;
    }
    #endregion

    #region ForEachSubQueryMethod
    /// <summary>
    /// Iterate over each object in the collection and call a sub query to calculate total sales
    /// </summary>
    public List<Product> ForEachSubQueryMethod() {
      // Get all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Get all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      products.ForEach(p => p.TotalSales = sales.Where(sale => sale.ProductID == p.ProductID)
                  .Sum(sale => sale.LineTotal));

      return products;
    }
    #endregion

    #region ForEachQueryCallingMethodQuery
    /// <summary>
    /// Iterate over each object in the collection and call a method to set a property.
    /// This method passes in each Product object into the SalesForProduct() method.
    /// In the CalculateTotalSalesForProduct() method, the total sales for each Product is calculated.
    /// The total is placed into each Product objects' TotalSales property.
    /// </summary>
    public List<Product> ForEachQueryCallingMethodQuery() {
      // Get all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Get all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      var list = (from prod in products
                  let tmp = prod.TotalSales = CalculateTotalSalesForProduct(prod, sales)      
                  select prod);

       list = list.Where(prod => prod.TotalSales > 0);

      return list.ToList();
    }
    #endregion

    #region CalculateTotalSalesForProduct Method
    /// <summary>
    /// Helper method called by LINQ to sum sales for a product
    /// </summary>
    /// <param name="prod">A product</param>
    /// <returns>Total Sales for Product</returns>
    private decimal CalculateTotalSalesForProduct(Product prod, List<SalesOrder> sales) {
      return sales.Where(sale => sale.ProductID == prod.ProductID)
                  .Sum(sale => sale.LineTotal);
    }
    #endregion

    #region ForEachQueryCallingMethod
    /// <summary>
    /// Iterate over each object in the collection and call a method to set a property.
    /// This method passes in each Product object into the SalesForProduct() method.
    /// In the CalculateTotalSalesForProduct() method, the total sales for each Product is calculated.
    /// The total is placed into each Product objects' TotalSales property.
    /// </summary>
    public List<Product> ForEachQueryCallingMethod() {
      // Get all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Get all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      products.ForEach(p => p.TotalSales = CalculateTotalSalesForProduct(p, sales));
      products = products.Where(p => p.TotalSales > 0).ToList();

      return products;
    }
    #endregion







    #region Extra Example
    public List<Product> ForEachQueryCalculateNameLength() {
      List<Product> products = GetProducts();
      List<Product> list;

      // Write Query Syntax Here
      list = (from prod in products
              let tmp = prod.NameLength = prod.Name.Length
              select prod).ToList();

      return list;
    }
    #endregion
  }
}
