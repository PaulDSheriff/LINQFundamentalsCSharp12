namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region SequenceEqualIntegersQuery
    /// <summary>
    /// SequenceEqual() compares two different collections to see if they are equal
    /// When using simple data types such as int, string, a direct comparison between values is performed
    /// </summary>
    public bool SequenceEqualIntegersQuery()
    {
      bool value = false;
      // Create a list of numbers
      List<int> list1 = new() { 5, 2, 3, 4, 5 };
      // Create a list of numbers
      List<int> list2 = new() { 1, 2, 3, 4, 5 };

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region SequenceEqualIntegersMethod
    /// <summary>
    /// SequenceEqual() compares two different collections to see if they are equal
    /// When using simple data types such as int, string, a direct comparison between values is performed
    /// </summary>
    public bool SequenceEqualIntegersMethod()
    {
      bool value = false;
      // Create a list of numbers
      List<int> list1 = new() { 5, 2, 3, 4, 5 };
      // Create a list of numbers
      List<int> list2 = new() { 1, 2, 3, 4, 5 };

      // Write Method Syntax Here
     

      return value;
    }
    #endregion

    #region SequenceEqualObjectsQuery
    /// <summary>
    /// When using a collection of objects, SequenceEqual() performs a comparison to see if the two object references point to the same object
    /// </summary>
    public bool SequenceEqualObjectsQuery()
    {
      bool value = false;
      // Create a list of products
      List<Product> list1 = new()
      {
        new Product { ProductID = 1, Name = "Product 1" },
        new Product { ProductID = 2, Name = "Product 2" },
      };
      // Create a list of products
      List<Product> list2 = new()
      {
        new Product { ProductID = 1, Name = "Product 1" },
        new Product { ProductID = 2, Name = "Product 2" },
      };

      // Make Collections the Same
      // list2 = list1;

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region SequenceEqualObjectsMethod
    /// <summary>
    /// When using a collection of objects, SequenceEqual() performs a comparison to see if the two object references point to the same object
    /// </summary>
    public bool SequenceEqualObjectsMethod()
    {
      bool value = false;
      // Create a list of products
      List<Product> list1 = new()
      {
        new Product { ProductID = 1, Name = "Product 1" },
        new Product { ProductID = 2, Name = "Product 2" },
      };
      // Create a list of products
      List<Product> list2 = new()
      {
        new Product { ProductID = 1, Name = "Product 1" },
        new Product { ProductID = 2, Name = "Product 2" },
      };

      // Make Collections the Same
      // list2 = list1;

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region SequenceEqualUsingComparerQuery
    /// <summary>
    /// Use an EqualityComparer class to determine if the objects are the same based on the values in properties
    /// </summary>
    public bool SequenceEqualUsingComparerQuery()
    {
      bool value = false;
      ProductComparer pc = new ProductComparer();
      // Load all Product Data From Data Source 1
      List<Product> list1 = ProductRepository.GetAll();
      // Load all Product Data From Data Source 2
      List<Product> list2 = ProductRepository.GetAll();

      // Remove an element from 'list1' to make the collections different
      //list1.RemoveAt(0);

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region SequenceEqualUsingComparerMethod
    /// <summary>
    /// Use an EqualityComparer class to determine if the objects are the same based on the values in properties
    /// </summary>
    public bool SequenceEqualUsingComparerMethod()
    {
      bool value = false;
      ProductComparer pc = new ProductComparer();
      // Load all Product Data From Data Source 1
      List<Product> list1 = ProductRepository.GetAll();
      // Load all Product Data From Data Source 2
      List<Product> list2 = ProductRepository.GetAll();

      // Remove an element from 'list1' to make the collections different
      //list1.RemoveAt(0);

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region ExceptIntegersQuery
    /// <summary>
    /// Find all values in one list that are not in the other list
    /// </summary>
    public List<int> ExceptIntegersQuery()
    {
      List<int> list = null;
      // Create a list of numbers
      List<int> list1 = new() { 5, 2, 3, 4, 5 };
      // Create a list of numbers
      List<int> list2 = new() { 3, 4, 5 };

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptIntegersMethod
    /// <summary>
    /// Find all values in one list that are not in the other list
    /// </summary>
    public List<int> ExceptIntegersMethod()
    {
      List<int> list = null;
      // Create a list of numbers
      List<int> list1 = new() { 5, 2, 3, 4, 5 };
      // Create a list of numbers
      List<int> list2 = new() { 3, 4, 5 };

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptProductSalesQuery
    /// <summary>
    /// Find all products that do not have sales
    /// </summary>
    public List<int> ExceptProductSalesQuery()
    {
      List<int> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptProductSalesMethod
    /// <summary>
    /// Find all products that do not have sales
    /// </summary>
    public List<int> ExceptProductSalesMethod()
    {
      List<int> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion

    #region ExceptUsingComparerQuery
    /// <summary>
    /// Find all products that are in one list but not the other using a comparer class
    /// </summary>
    public List<Product> ExceptUsingComparerQuery()
    {
      List<Product> list = null;
      ProductComparer pc = new();
      // Load all Product Data From Data Source 1
      List<Product> list1 = ProductRepository.GetAll();
      // Load all Product Data From Data Source 2
      List<Product> list2 = ProductRepository.GetAll();

      // Remove all products with color = "Black" from 'list2'
      // to give us a difference in the two lists
      list2.RemoveAll(prod => prod.Color == "Black");

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptUsingComparerMethod
    /// <summary>
    /// Find all products that are in one list but not the other using a comparer class
    /// </summary>
    public List<Product> ExceptUsingComparerMethod()
    {
      List<Product> list = null;
      ProductComparer pc = new();
      // Load all Product Data
      List<Product> list1 = ProductRepository.GetAll();
      // Load all Product Data
      List<Product> list2 = ProductRepository.GetAll();

      // Remove all products with color = "Black" from 'list2'
      // to give us a difference in the two lists
      list2.RemoveAll(prod => prod.Color == "Black");

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptByQuery
    /// <summary>
    /// ExceptBy() finds products within a collection that DO NOT compare to a List<string> against a specified property in the collection.
    /// The default comparer for ExceptBy() is 'string'
    /// </summary>
    public List<Product> ExceptByQuery()
    {
      List<Product> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // The list of colors to exclude from the list
      List<string> colors = new() { "Red", "Black" };

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptByMethod
    /// <summary>
    /// ExceptBy() finds products within a collection that DO NOT compare to a List<string> against a specified property in the collection.
    /// The default comparer for ExceptBy() is 'string'
    /// </summary>
    public List<Product> ExceptByMethod()
    {
      List<Product> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // The list of colors to exclude from the list
      List<string> colors = new() { "Red", "Black" };

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptByProductSalesQuery
    /// <summary>
    /// Find all products that do not have sales
    /// Change the default comparer for ExceptBy()
    /// </summary>
    public List<Product> ExceptByProductSalesQuery()
    {
      List<Product> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region ExceptByProductSalesMethod
    /// <summary>
    /// Find all products that do not have sales
    /// Change the default comparer for ExceptBy()
    /// </summary>
    public List<Product> ExceptByProductSalesMethod()
    {
      List<Product> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion

    #region IntersectIntegersQuery
    /// <summary>
    /// Intersect() finds all values in one list that are also in the other list
    /// </summary>
    public List<int> IntersectIntegersQuery()
    {
      List<int> list = null;
      // Create a list of numbers
      List<int> list1 = new() { 5, 2, 3, 4, 5 };
      // Create a list of numbers
      List<int> list2 = new() { 3, 4, 5 };

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region IntersectIntegersMethod
    /// <summary>
    /// Intersect() finds all values in one list that are also in the other list
    /// </summary>
    public List<int> IntersectIntegersMethod()
    {
      List<int> list = null;
      // Create a list of numbers
      List<int> list1 = new() { 5, 2, 3, 4, 5 };
      // Create a list of numbers
      List<int> list2 = new() { 3, 4, 5 };

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region IntersectProductSalesQuery
    /// <summary>
    /// Find all products that have sales
    /// </summary>
    public List<int> IntersectProductSalesQuery()
    {
      List<int> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region IntersectProductSalesMethod
    /// <summary>
    /// Find all products that have sales
    /// </summary>
    public List<int> IntersectProductSalesMethod()
    {
      List<int> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion

    #region IntersectUsingComparerQuery
    /// <summary>
    /// Intersect() finds all products that are in common between two collections using a comparer class
    /// </summary>
    public List<Product> IntersectUsingComparerQuery()
    {
      List<Product> list = null;
      ProductComparer pc = new();
      // Load all Product Data
      List<Product> list1 = ProductRepository.GetAll();
      // Load all Product Data
      List<Product> list2 = ProductRepository.GetAll();

      // Remove 'black' products from 'list1'
      list1.RemoveAll(prod => prod.Color == "Black");
      // Remove 'red' products from 'list2'
      list2.RemoveAll(prod => prod.Color == "Red");

      // Write Query Syntax Here
     

      return list;
    }
    #endregion

    #region IntersectUsingComparerMethod
    /// <summary>
    /// Intersect() finds all products that are in common between two collections using a comparer class
    /// </summary>
    public List<Product> IntersectUsingComparerMethod()
    {
      List<Product> list = null;
      ProductComparer pc = new();
      // Load all Product Data
      List<Product> list1 = ProductRepository.GetAll();
      // Load all Product Data
      List<Product> list2 = ProductRepository.GetAll();

      // Remove 'black' products from 'list1'
      list1.RemoveAll(prod => prod.Color == "Black");
      // Remove 'red' products from 'list2'
      list2.RemoveAll(prod => prod.Color == "Red");

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region IntersectByQuery
    /// <summary>
    /// Find products within a collection by comparing a List<string> against a specified property in the collection.
    /// </summary>
    public List<Product> IntersectByQuery()
    {
      List<Product> list = null;
      List<Product> products = ProductRepository.GetAll();

      // The list of colors to locate in the list
      List<string> colors = new() { "Red", "Black" };

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region IntersectByMethod
    /// <summary>
    /// IntersectBy() finds DISTINCT products within a collection by comparing a List<string> against a specified property in the collection.
    /// </summary>
    public List<Product> IntersectByMethod()
    {
      List<Product> list = null;
      List<Product> products = ProductRepository.GetAll();

      // The list of colors to locate in the list
      List<string> colors = new() { "Red", "Black" };

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region IntersectByProductSalesQuery
    /// <summary>
    /// Find all products that have sales using a 'int' key selector
    /// Change the default comparer for IntersectBy()
    /// </summary>
    public List<Product> IntersectByProductSalesQuery()
    {
      List<Product> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region IntersectByProductSalesMethod
    /// <summary>
    /// Find all products that have sales using a 'int' key selector
    /// Change the default comparer for IntersectBy()
    /// </summary>
    public List<Product> IntersectByProductSalesMethod()
    {
      List<Product> list = null;
      List<Product> products = ProductRepository.GetAll();
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion
  }
}
