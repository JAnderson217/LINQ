using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ test
            string likes = "I like fruit";
            string[] fruits = { "Orange", "Apple", "Grapefruit", "Pear", "Pineapple","Grapes", "Peach"
                    ,"Melon","Coconut" };
            int[] numbers = {5,6,3,8,2,9,1,6,15,66,34,23,32,45,29,30};
            //get numbers less than 10 into one var
            var getNumbers = from number
                   in numbers
                   where number < 10
                   select number;
            Console.WriteLine(string.Join(", ", getNumbers) + "\n");
            //query to get all fruits with G in name, and length < 8, also print all even numbers
            //from numbers array in ascending order
            var numQuery = from number
                    in numbers
                    where number % 2 == 0
                    orderby number
                    select number;  
            Console.WriteLine(string.Join(", ", numQuery));
            var fruitwithG = from fruit in fruits
                    where
                    fruit.Contains("G") && (fruit.Length < 8)
                    select fruit;
            Console.WriteLine(string.Join(", ", fruitwithG));
            Console.ReadLine();

        }
    }
}
