using System;

namespace Algorithms.Sort
{
    public class InsertionSort<T> : AlgorithmBase<T> where T : IComparable //сортировка вставками
    {
        // Хорошо - когда частично отсортированный массив

        // Время: худшее - O(n^2)
        //        среднее - О(n * log(n))

        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                var temp = Items[i];

                for (var j = i;  j > 0 && temp.CompareTo(Items[j - 1]) == -1; j--, ComparisonCount++)
                {
                    SwopCount++;
                    Items[j] = Items[j - 1];
                }

                Items[j] = temp; 
            }
        }
    }
}
