using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    /// <summary>
    /// Сортировка пузырьком.
    /// </summary>
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable 
    {
        // Время: лучшее - O(n), худшее - O(n^2)

        public BubbleSort(List<T> items) : base(items)
        {
        }

        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];

                    ComparisonCount++;
                    if (a.CompareTo(b) == 1)
                    {
                        Swop(j, j + 1);
                    }
                }
            }
        }
    }
}
