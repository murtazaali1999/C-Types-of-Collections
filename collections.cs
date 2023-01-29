using System;
using System.Collections.Generic;

namespace CollectionsAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public List<string> list()
        {
            var names = new List<string>();
            names.Add("Usama");
            names.Add("Ali");
            names.Add("Johar");
            names.Add("Nazmabad");

            return names;
        }

        public HashSet<string> hashset()
        {
            var names = new HashSet<string>();
            names.Add("Usama");
            names.Add("Ali");
            names.Add("Johar");
            names.Add("Nazmabad");

            return names;
        }

        public Stack<int> stack()
        {
            var nums = new Stack<int>();
            nums.Push(1);
            nums.Push(2);
            nums.Push(3);
            nums.Push(4);

            return nums;
        }

        public Queue<int> queue()
        {
            var nums = new Queue<int>();
            nums.Enqueue(1);
            nums.Enqueue(2);
            nums.Enqueue(3);
            nums.Enqueue(4);

            return nums;
        }

        public LinkedList<int> linkedList()
        {
            var nums = new LinkedList<int>();
            nums.AddFirst(1);
            nums.AddFirst(2);
            nums.AddLast(1);
            nums.AddLast(1);

            return nums;
        }

        public Dictionary<int,string> dictionary()
        {
            var nums = new Dictionary<int,string>();
            nums.Add(1, "Hi");
            nums.Add(2, "Sup");
            nums.Add(3, "Dope");
            nums.Add(4, "Zawawa");

            return nums;
        }

        public void displayIterateDictionary()
        {
            var nums = dictionary();

            foreach (KeyValuePair<int,string> num in nums)
            {
                Console.WriteLine(num.Key+" "+num.Value); //key value
            }

        }

        public void displayIterateLinkedList()
        {
            var nums = linkedList();

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

        }

        public void displayIterateQueue()
        {
            var nums = queue();

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

        }

        public void displayIterateStack()
        {
            var nums = stack();
           
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

        }


        public void displayIterateList()
        {
           var names = list();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        public void displayIterateHashList()
        {
            var names = hashset();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }


    }
}
