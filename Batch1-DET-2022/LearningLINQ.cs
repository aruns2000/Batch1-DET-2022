using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
     class LearningLINQ
    {
        public static void Main()
        {
            //SampleIntList();
            //NewLinqIntems();
            /* NewOrderBy();
             NewOrderByDesc();
             NewThenBy();
             //NewThenByDescending();*/
            // SampleForSkip();
            //SampleForSkipWhile();
            //SampleForTake();
            //SampleForTakeWhile();
            //SampleForAggregate();
            //SampleForAvrage();

            //SampleForMax();
            //SampleForAll();
            //SampleForContain();
            //SampleForDistinct();
            //SampleForExcept();
            //SampleForElementAt();



            SampleForCount();


            //SampleToFindLetter();
            //SampleToFindLength();

            String_groupby();





        }
        //public static void SampleIntList()
        //    {
        //        //The Three Parts of a linq Query: deffers execution
        //        //1 . data sources
        //        List<int> numbers = new List<int>();
        //        numbers.Add(100);
        //        numbers.Add(102);
        //        numbers.Add(105);
        //        numbers.Add(110);

        //    ////2.Query creation. sql type
        //    //var numQuery = from num in numbers
        //    //               where num > 102
        //    //               select num;
        //   /// var numQuery = numbers.Select(x => x);
        //    var numQuery = numbers.Where(x => x > 102);


        //    //2.Query creation. sql type

        //    /*  // Early execution
        //      var numQuery = (from num in numbers
        //                     select num).ToList();*/

        //    //numbers.Add(12232);
        //    //numbers.Add(10235);

        //    // 3 .Query execution
        //    foreach (int num in numQuery)
        //        {
        //            Console.WriteLine("{0}", num);
        //        //num.Dump(); //this is fore LINQpsd not for vs

        //    }
        //        Console.ReadLine();

        //}
        public static void NewOrderBy()
        {
            int[] numbers = { 4, 6, 3, 5, 1, 6, };

            var result = numbers.OrderBy(x => x);

            Console.WriteLine("orderd list of numbers:");
            foreach (int number in result)
                Console.WriteLine(number);

        }
        public static void NewOrderByDesc()
        {
            char[] characters = {'k', 't', 'r', 'y' };

            //var Expected = names.OrderByDescending(x => x);

            var Expected = characters.Reverse();

            foreach(char name in Expected)
                Console.WriteLine(name);
        }
        public static void NewThenBy()
        {
            string[] capitals = { "Virat", "Sonata", "Soeul", "Tokyo", "London" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }

        public static void NewThenByDescending()
        {
            var dates = new DateTime[] {
        new DateTime(2015, 3, 1),
        new DateTime(2014, 7, 1),
        new DateTime(2013, 5, 1),
        new DateTime(2015, 1, 1),
        new DateTime(2015, 7, 1)
            };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }






        public static void SampleForSkip()
        {
            string[] words = { "Virat", "Kohli", "Arun", "Bengalore", "GV", "Sonata" };

            var result = words.Skip(4);

            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in result)
                Console.WriteLine(word);
        }

        public static void SampleForAggregate()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }

        public static void SampleForAvrage()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);

        }
        public static void SampleForCount()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim","Aruns" };

            var result = names.Where(c => c.Length==5).Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }
        public static void SampleForMax()
        {
            int[] numbers = { 2, 8, 5, 6, 1 };

            //var result = numbers.Max();
            //Console.WriteLine("Highest number is:");
            
            //var result = numbers.Min();
            //Console.WriteLine("Lowest number is:");

            var result = numbers.Sum();
            Console.WriteLine("Addition of the  number is:");


            Console.WriteLine(result);
        }

        public static void SampleForAll()
        {
            string[] names = { "Bob", "Ned", "amy", "Bill" };

           // var result = names.All(n => n.StartsWith("B"));

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);

        }

        public static void SampleForContain()
        {
            int[] numbers = { 1, 3, 2, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }
        
        public static void SampleForDistinct()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        public static void SampleForExcept()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            //  var result = numbers1.Except(numbers2);

            //  Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");

            //var result = numbers1.Intersect(numbers2);

            //Console.WriteLine("Intersect creates a single sequence with only the duplicates:");

            var result = numbers1.Union(numbers2);

            // Console.WriteLine(" Union Numbers:");
            foreach (int number in result)
               Console.WriteLine(number);
        }

        public static void SampleForElementAt()
        {
            
            string[] words = { "Helo",  "How", "Are", "you" , "Royal" };
            // Element At----------------------------------------

            //var result = words.ElementAt(1);
            //Console.WriteLine(result);


            //ElementsAtOrDefault----------------------------------

            //var result1 = words.ElementAtOrDefault(1);
            //Console.WriteLine(result1);
            //var result10 = words.ElementAtOrDefault(10);
            //Console.WriteLine(result10==null);

            //Elements First(Simple)--------------------
            //var result = words.First();
            //Console.WriteLine(result);

            //Elemtns First(Condition)----------------------------------------
            // var result = words.First(c => c.Length == 5);
            //Console.WriteLine(result.ToString());

            //Elements For FirstOrDefault------------------------------------

            //string[] words2 = { };

            //var result = words.FirstOrDefault();
            //Console.WriteLine( result );

            //var result1 = words2.FirstOrDefault();
            //Console.WriteLine(result1 == null);

            //Elements At Last------------------------------------------
            //var result = words.Last();

            //Console.WriteLine(result);

            //LastOrDefault----------------------------

            //string[] words2 = { };

            //var result = words.LastOrDefault();
            //Console.WriteLine(result);

            //var result2 = words2.LastOrDefault();
            //Console.WriteLine(result2 == null);


        }

        public static void SampleToFindLetter()
        {
            string[] names = { " John", "Peter", "Jacob", "Harry", "Jackson" };

            if(names.Any(x => x.Contains("o")))
                Console.WriteLine(names);





        }

        public static void SampleToFindLength()
        {
            List<String> list = new List<String>();

            list.Add("John ");
            list.Add("Peter");
            list.Add("Jacob ");
            list.Add("Harry ");
            list.Add("Jackson");

            String maxString = list.OrderByDescending(x => x.Length).First();


            Console.WriteLine(maxString);
        }

        public static void SampleReplace()
        {
            string[] oldString = { "believe", "relief", "receipt", "field" };




             
        }

        public static void String_groupby()
        {
            List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacus", "banana", "cheese" };

            var wordGroup = words.GroupBy(x => x[0]).Select(y => new { FirstLetter = y.Key, Words = y });
            foreach (var item in wordGroup)
            {
                Console.WriteLine("WORDS THAT START WITH THE " + "LETTER'{0}':", item.FirstLetter);
                foreach(var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            
            }

   
        }
























        //public static void SampleForSkipWhile()
        //    {
        //    string[] words = { "Vir", "Ben", "Sonata", "four", "Kohli", "six","nan" };

        //    var result = words.SkipWhile(w => w.Length == 3);

        //    Console.WriteLine("Skips words while the condition is met:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}






        //public static void SampleForTake()
        //{
        //    int[] numbers = { 101, 201, 301, 423, 552, 622, 755, 8888, 97, 104 };

        //    var result = numbers.Take(5);

        //    Console.WriteLine("Takes the first 5 numbers only:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}




        //public static void SampleForTakeWhile()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.TakeWhile(n => n < 5);

        //    Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}







        //public static void NewLinqIntems()
        //{
        //    List<string> names = new List<string>();
        //    names.Add("Arun");
        //    names.Add("Kiran");
        //    names.Add("Vinay");
        //    names.Add("Abhi");

        //    var names1 = names.Select(x => x);


        //    foreach (string name in names1)
        //    {
        //        Console.WriteLine("{0}", name);
        //    }
        //    Console.ReadLine();
        //}
    }
}

        //   public static void NewIntems()
        //{
        //    List<int> numb = new List<int>();
        //    numb.Add(100);
        //    numb.Add(200);

        //    var Query = numb.Where(y=> y);

        //}




     
 

