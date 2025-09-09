using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static Task_2_LINQ.ListGenerators;

namespace Task_2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            ////1. Find all products that are out of stock. 
            //var Result01 = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach(var Unit in Result01)
            //{
            //    Console.WriteLine(Unit);
            //}

            ////2. Find all products that are in stock and cost more than 3.00 per unit. 
            //var Result02 = ProductList.Where( p => p.UnitsInStock != 0 && p.UnitPrice > 3);
            //foreach(var Unit in Result02)
            //{
            //    Console.WriteLine(Unit);
            //}

            //3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", 
            //                "five", "six", "seven", "eight","nine" };
            //var Result03 = Arr.Where((name,index) => name.Length < index);
            //foreach (var result in Result03)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion



            #region Element Operators 
            ////1.Get first Product out of Stock
            //var Result01 = ProductList.FirstOrDefault((P) => P.UnitsInStock == 0);
            //Console.WriteLine(Result01);

            ////2.Return the first product whose Price > 1000, unless there is no match, in which case null
            ////is returned.
            //var Result02 = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result02);

            ////3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result03 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(Result03);
            #endregion



            #region Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int Result01 = Arr.Count(P => P % 2 == 0);
            //Console.WriteLine(Result01);

            //2. Return a list of customers and how many orders each has.
            //2. Return a list of customers and how many orders each has.
            //var Result02 = CustomerList.Select(P => new { P.Name , P.Orders.Length });
            //foreach (var Result03 in Result02)
            //{
            //    Console.WriteLine(Result03);
            //}

            //3. Return a list of categories and how many products each has
            //var Result03 = ListGenerators.ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new { Category = g.Key, ProductsCount = g.Count() })
            //.OrderBy(x => x.ProductsCount);


            //foreach (var item in Result03)
            //{
            //    Console.WriteLine($"{item.Category} - Products: {item.ProductsCount}");
            //}

            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result04 = Arr.Sum(x => x);
            //Console.WriteLine(Result04);

            #endregion


            #region Ordering Operators 
            //1. Sort a list of products by name
            //var Result01 = ProductList.OrderBy(x => x.ProductName);
            //foreach (var Result in Result01)
            //{
            //    Console.WriteLine(Result);
            //}

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result02 = Arr.OrderBy(x => x.ToLower()).ToList();
            //foreach (var Result03 in Result02)
            //{
            //    Console.WriteLine(Result03);
            //}

            //another solution
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result02 = Arr.OrderBy(x => x,StringComparer.OrdinalIgnoreCase).ToList();
            //foreach (var Result03 in Result02)
            //{
            //    Console.WriteLine(Result03);
            //}
            #endregion

        }
    }
}
