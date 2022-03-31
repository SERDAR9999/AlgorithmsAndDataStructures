using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    public class AlgorithmBase<T> where T : IComparable
    {
        /// <summary>
        /// Список элементов.
        /// </summary>
        public List<T> Items { get; set; }

        /// <summary>
        /// Количество обменов.
        /// </summary>
        public int SwopCount { get; protected set; }

        /// <summary>
        /// Количество сравнений.
        /// </summary>
        public int ComparisonCount { get; protected set; }

        /// <summary>
        /// Время сортировки.
        /// </summary>
        public TimeSpan SortingTime { get; protected set; }

        public AlgorithmBase(List<T> items)
        {
            Items = items;
        }

        public void Sort()
        {
            SwopCount = 0;
            ComparisonCount = 0;

            var time = Stopwatch.StartNew();
            MakeSort();
            time.Stop();

            SortingTime = time.Elapsed;
        }

        // Переопределяется для каждого отдельного алгоритма сортировки
        protected virtual void MakeSort()
        {
            Items.Sort();
        }

        /// <summary>
        /// Меняет местами два элемента.
        /// </summary>
        protected void Swop(int positionA, int positionB)
        {
            if(positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwopCount++;
            }
            else
            {
                throw new Exception("Выход за границы массива");
            }
        }

    }
}
