using System;
using System.Collections.Generic;

namespace LINQSamples
{
  public static class LinqHelper
  {
    #region FilterSimple
    /// <summary>
    /// DO NOT write a LINQ filter this way.
    /// The query executes immediately
    ///    Can't add on any additional operators
    ///    Must go through the whole list of data
    /// The code can not be run asynchronously.
    /// Requires you to create a variable to hold the new list.
    /// </summary>
    public static IEnumerable<T> FilterSimple<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      var result = new List<T>();

      foreach (var item in source) {
        if (predicate(item)) {
          result.Add(item);
        }
      }

      return result;
    }
    #endregion

    #region Filter
    /// <summary>
    /// Always use the 'yield' statement when writing a LINQ filter
    /// Allows for lazy execution
    /// Releases control to calling program each time 'yield' is called
    /// Helps with async processes
    /// No need to create an additional variable to hold the new list.
    /// </summary>
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      foreach (var item in source) {
        if (predicate(item)) {
          yield return item;
        }
      }
    }
    #endregion
  }
}
