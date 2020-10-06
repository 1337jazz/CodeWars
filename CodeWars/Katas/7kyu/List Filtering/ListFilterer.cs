using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Katas._7kyu
{
    /// <summary>
    /// In this kata you will create a function that takes a list of non-negative integers
    /// and strings and returns a new list with the strings filtered out.
    ///
    /// Examples:
    /// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
    /// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
    /// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
    /// </summary>
    public class ListFilterer
    {
        // My way
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) =>
            Enumerable.Cast<int>(listOfItems.Where(x => x.GetType() == typeof(int)));

        // Best way
        public static IEnumerable<int> Best_GetIntegersFromList(List<object> listOfItems) =>
            listOfItems.OfType<int>();
    }
}