using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            #region SortedList
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Remove(1);

            numberNames.RemoveAt(0);

            Console.WriteLine("--------------------------------");
            for (int i = 0; i < numberNames.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
            }


            if (numberNames.ContainsKey(4))
            {
                numberNames[4] = "four";
            }

            string result;
            if (numberNames.TryGetValue(4, out result))
                Console.WriteLine("Key: {0}, Value: {1}", 4, result);
            #endregion

            #region Hashtable
            var cities = new Hashtable(){
                     {"UK", "London, Manchester, Birmingham"},
                     {"USA", "Chicago, New York, Washington"},
                     {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            string citiesOfUSA = (string)cities["USA"];

            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol";

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }
            cities.Remove("UK");

            if (cities.ContainsKey("France"))
            {
                cities.Remove("France");
            }

            cities.Clear();
            #endregion

            #region Stack
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack = new Stack<int>(arr);

            foreach (var item in myStack)
                Console.Write(item + ",");

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek());
                Console.WriteLine(myStack.Peek());
            }

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.Write("Number of elements in Stack: {0}", myStack.Count);
            #endregion

            #region Queue
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id);

            while (callerIds.Count>0)
            {
                Console.WriteLine(callerIds.Dequeue()); //prints Hello

            }
            #endregion
        }
    }
}
