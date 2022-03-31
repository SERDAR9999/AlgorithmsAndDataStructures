using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    /// <summary>
    /// Шейкерная сортировка.
    /// </summary>
    public class CocktailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        // Время: лучшее - O(n), худшее - O(n^2)

        public CocktailSort(List<T> items) : base(items)
        {
        }

        protected override void MakeSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                // Счетчик перемещений за один цикл
                // Если не произошло ни одного перемещения, то выходим из цикла
                var sc = SwopCount;

                for (int i = left; i < right; i++)
                {
                    ComparisonCount++;
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                right--;

                if (sc == SwopCount) break;

                for (int i = right; i > left; i--)
                {
                    ComparisonCount++;
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                    }
                }
                left++;

                if (sc == SwopCount) break;
            }
        }
    }
}
