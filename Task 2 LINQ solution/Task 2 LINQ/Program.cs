using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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


            //3. Sort a list of products by units in stock from highest to lowest.
            //var Result03 = ProductList.OrderByDescending(x => x.UnitsInStock);

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}


            ////4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", 
            //                "four", "five", "six", "seven", "eight","nine" };
            //var Result04 = Arr.OrderBy(x => x.Length)
            //                  .ThenBy(x => x);

            //foreach (var item in Result04)
            //{
            //    Console.WriteLine(item);
            //}


            ////5. Sort first by word length and then by a case-insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var Result05 = words.OrderBy(x => x.Length)
            //                    .ThenBy(x => x,StringComparer.OrdinalIgnoreCase);

            //foreach(var item in Result05)
            //{
            //    Console.WriteLine(item);
            //}


            ////6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result06 = ProductList.OrderBy(x => x.Category)
            //                          .ThenByDescending(x => x.UnitPrice);

            //foreach(var item in Result06)
            //{
            //    Console.WriteLine(item);
            //}

            ////7. Sort first by word length and then by a case-insensitive descending sort of the words in 
            ////an array. 
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result07 = Arr.OrderBy(x => x.Length).ThenByDescending(x => x,StringComparer.OrdinalIgnoreCase);

            //foreach(var item in Result07)
            //{
            //    Console.WriteLine(item);
            //}

            ////8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the
            ////order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", 
            //                "five", "six", "seven", "eight","nine" };

            //var Result08 = Arr.Where(x => x[1] == 'i')
            //                  .Reverse();

            //foreach (var item in Result08)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Transformation Operators 
            ////1.Return a sequence of just the names of a list of products.
            //var Result01 = ProductList.Select(x => x.ProductName);

            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}

            ///*2. Produce a sequence of the uppercase and lowercase versions of each word in the 
            //original array(Anonymous Types).*/

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result02 = words.Select(x => new { UpperCase = x.ToUpper() , LowerCase = x.ToLower() });

            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}


            ////3. Produce a sequence containing some properties of Products, including UnitPrice which 
            ////is renamed to Price in the resulting type.

            //var Result03 = ProductList.Select(x => new { x.ProductName,x.UnitsInStock,Price = x.UnitPrice });

            //foreach (var result in Result03)
            //{
            //    Console.WriteLine(result);
            //}

            ////4. Determine if the value of ints in an array match their position in the array. 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result04 = Arr.Select((value, index) => new { value , y =(value == index)});

            //foreach (var item in Result04)
            //{
            //    Console.WriteLine($"{item.value} : {item.y}");
            //}



            #endregion


            #region  Partitioning Operators
            ////1.Get the first 3 orders from customers in Washington
            //var Result01 = CustomerList.SelectMany(x => x.Orders).Take(3);

            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}

            ////2. Get all but the first 2 orders from customers in Washington.
            //var Result02 = CustomerList.SelectMany(x => x.Orders).Take(2);

            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}

            ////3. Return elements starting from the beginning of the array until a number is hit that is 
            ////less than its position in the array. 
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result03 = numbers.TakeWhile((x, index) => x > index);

            //foreach (var result in Result03)
            //{
            //    Console.WriteLine(result);
            //}

            ////4.Get the elements of the array starting from the first element divisible by 3. 
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result04 = numbers.SkipWhile(x => x % 3 != 0);

            //foreach (var item in Result04)
            //{
            //    Console.WriteLine(item);
            //}

            ////5. Get the elements of the array starting from the first element less than its position. 
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result05 = numbers.SkipWhile((value, index) => value > index);

            //foreach (var value in Result05)
            //{
            //    Console.WriteLine(value);
            //}
            #endregion

        }
    }
}
