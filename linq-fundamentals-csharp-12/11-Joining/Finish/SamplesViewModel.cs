namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region InnerJoinQuery
    /// <summary>
    /// Join a Sales Order collection with Products into an anonymous class
    /// NOTE: This is an equijoin or an inner join
    /// </summary>
    public List<ProductOrder> InnerJoinQuery()
    {
      List<ProductOrder> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
              join sale in sales
              on prod.ProductID equals sale.ProductID
              select new ProductOrder
              {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color,
                StandardCost = prod.StandardCost,
                ListPrice = prod.ListPrice,
                Size = prod.Size,
                SalesOrderID = sale.SalesOrderID,
                OrderQty = sale.OrderQty,
                UnitPrice = sale.UnitPrice,
                LineTotal = sale.LineTotal
              }).OrderBy(p => p.Name).ToList();

      return list;
    }
    #endregion

    #region InnerJoinMethod
    /// <summary>
    /// Join a Sales Order collection with Products into anonymous class
    /// NOTE: This is an equijoin or an inner join
    /// </summary>
    public List<ProductOrder> InnerJoinMethod()
    {
      List<ProductOrder> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      list = products.Join(sales, prod => prod.ProductID,
              sale => sale.ProductID,
              (prod, sale) => new ProductOrder
              {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color,
                StandardCost = prod.StandardCost,
                ListPrice = prod.ListPrice,
                Size = prod.Size,
                SalesOrderID = sale.SalesOrderID,
                OrderQty = sale.OrderQty,
                UnitPrice = sale.UnitPrice,
                LineTotal = sale.LineTotal
              }).OrderBy(p => p.Name).ToList();

      return list;
    }
    #endregion

    #region InnerJoinTwoFieldsQuery
    /// <summary>
    /// Join a Sales Order collection with Products collection using two fields
    /// </summary>
    public List<ProductOrder> InnerJoinTwoFieldsQuery()
    {
      List<ProductOrder> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
              join sale in sales on
                new { prod.ProductID, Qty = (short)6 }
                  equals
                new { sale.ProductID, Qty = sale.OrderQty }
              select new ProductOrder
              {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color,
                StandardCost = prod.StandardCost,
                ListPrice = prod.ListPrice,
                Size = prod.Size,
                SalesOrderID = sale.SalesOrderID,
                OrderQty = sale.OrderQty,
                UnitPrice = sale.UnitPrice,
                LineTotal = sale.LineTotal
              }).OrderBy(p => p.Name).ToList();

      return list;
    }
    #endregion

    #region InnerJoinTwoFieldsMethod
    /// <summary>
    /// Join a Sales Order collection with Products collection using two fields
    /// </summary>
    public List<ProductOrder> InnerJoinTwoFieldsMethod()
    {
      List<ProductOrder> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      list = products.Join(sales,
              prod => new { prod.ProductID, Qty = (short)6 },
              sale => new { sale.ProductID, Qty = sale.OrderQty },
              (prod, sale) => new ProductOrder
              {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color,
                StandardCost = prod.StandardCost,
                ListPrice = prod.ListPrice,
                Size = prod.Size,
                SalesOrderID = sale.SalesOrderID,
                OrderQty = sale.OrderQty,
                UnitPrice = sale.UnitPrice,
                LineTotal = sale.LineTotal
              }).OrderBy(p => p.Name).ToList();

      return list;
    }
    #endregion

    #region JoinIntoQuery
    /// <summary>
    /// Use 'into' to create a new object with a Sales collection for each Product
    /// This is like a combination of an inner join and left outer join
    /// The 'into' keyword allows you to put the sales into a 'sales' variable 
    /// that can be used to retrieve all sales for a specific product
    /// </summary>
    public List<ProductSales> JoinIntoQuery()
    {
      List<ProductSales> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.ProductID
              join sale in sales
              on prod.ProductID equals sale.ProductID
              into newSales
              select new ProductSales
              {
                Product = prod,
                Sales = newSales.OrderBy(s => s.SalesOrderID).ToList()
              }).ToList();

      return list;
    }
    #endregion

    #region JoinIntoMethod
    /// <summary>
    /// Use 'into' to create a new object with a Sales collection for each Product
    /// This is like a combination of an inner join and left outer join
    /// The GroupJoin() method replaces the into keyword
    /// </summary>
    public List<ProductSales> JoinIntoMethod()
    {
      List<ProductSales> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      list = products.OrderBy(p => p.ProductID).GroupJoin(sales,
              prod => prod.ProductID,
              sale => sale.ProductID,
              (prod, newSales) => new ProductSales
              {
                Product = prod,
                Sales = newSales.OrderBy(s => s.SalesOrderID).ToList()
              }).ToList();

      return list;
    }
    #endregion

    #region LeftOuterJoinQuery
    /// <summary>
    /// Perform a left join between Products and Sales using DefaultIfEmpty()
    /// </summary>
    public List<ProductOrder> LeftOuterJoinQuery()
    {
      List<ProductOrder> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
              join sale in sales
              on prod.ProductID equals sale.ProductID
                into newSales
              from sale in newSales.DefaultIfEmpty()
              select new ProductOrder
              {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color,
                StandardCost = prod.StandardCost,
                ListPrice = prod.ListPrice,
                Size = prod.Size,
                SalesOrderID = sale?.SalesOrderID,
                OrderQty = sale?.OrderQty,  // Use the null-conditional operator
                UnitPrice = sale?.UnitPrice,
                LineTotal = sale?.LineTotal
              }).OrderBy(p => p.Name).ToList();

      return list;
    }
    #endregion

    #region LeftOuterJoinMethod
    /// <summary>
    /// Perform a left join between Products and Sales using DefaultIfEmpty() and SelectMany()
    /// </summary>
    public List<ProductOrder> LeftOuterJoinMethod()
    {
      List<ProductOrder> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      list = products.SelectMany(
              prod => sales.Where(s => s.ProductID == prod.ProductID).DefaultIfEmpty(),
              (prod, sale) => new ProductOrder
              {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color,
                StandardCost = prod.StandardCost,
                ListPrice = prod.ListPrice,
                Size = prod.Size,
                SalesOrderID = sale?.SalesOrderID,  // Use the null-conditional operator
                OrderQty = sale?.OrderQty,
                UnitPrice = sale?.UnitPrice,
                LineTotal = sale?.LineTotal
              }).OrderBy(p => p.Name).ToList();

      return list;
    }
    #endregion
  }
}
