using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    /// <summary>
    /// Сортировка вставками.
    /// </summary>
    public class InsertionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        // Хорошо - когда частично отсортированный массив

        // Время: худшее - O(n^2)
        //        среднее - О(n * log(n))

        public InsertionSort(List<T> items) : base(items)
        {
        }

        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                var temp = Items[i];

                var j = i;

                for(; j > 0 && temp.CompareTo(Items[j - 1]) == -1; j--, ComparisonCount++)
                {
                    SwopCount++;
                    Items[j] = Items[j - 1];
                }
                if(j != 0) ComparisonCount++;

                Items[j] = temp; 
            }
        }
    }
}
