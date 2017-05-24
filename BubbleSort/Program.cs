using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");

            int[] ItemList = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("Unsorted List");
            DisplayItems(ItemList);

            Sort(ref ItemList);

            Console.WriteLine("Sorted List");
            DisplayItems(ItemList);

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        private static void Sort(ref int[] itemList)
        {
            int temp = 0;
            bool swappedOccurred = false;

            // Step 1 - If there is one item in the list then stop.
            if (itemList.Length > 1)
            {
                do
                {
                    // Step 2 - Make one pass along the list, compare each item with the one beside (adjacent to) it, swapping if necessary.
                    swappedOccurred = false;
                    for (int i = 0; i < itemList.Length; i++)
                    {
                        if (i < (itemList.Length - 1))
                        {
                            if (itemList[i] > itemList[i + 1])
                            {
                                // Swap Items
                                swappedOccurred = true;
                                temp = itemList[i];
                                itemList[i] = itemList[i + 1];
                                itemList[i + 1] = temp;

                                Console.WriteLine("Swapped Item {0} with Item {1}", itemList[i + 1], itemList[i]);
                            }
                        }
                    }
                    Console.WriteLine("Pass Complete");
                    DisplayItems(itemList);
                }
                // Step 3 - If no swaps occur then stop(the list is now in order) otherwise ignore the last item in the list go back to Step 1.
                while (swappedOccurred);
            }
        }


        private static void DisplayItems(int[] unsortedItems)
        {
            foreach (var item in unsortedItems)
            {
                Console.Write(item);
                Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
}
