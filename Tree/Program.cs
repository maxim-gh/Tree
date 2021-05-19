using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            var counter = 0;

            int[] mas = new int[]
            {
                31,49,98,66,60,12,41,50,38,80,49,49,98,66,41,47
            };
            foreach (var element in mas)
            {
                tree.AddElement(element);
            }

            foreach (var element in mas)
            {
                var chel = tree.Search(element, out counter);
                Console.WriteLine($"Значение: {element}, кол-во повторений {counter}");
            }
            Console.ReadKey();
        }
    }
}
