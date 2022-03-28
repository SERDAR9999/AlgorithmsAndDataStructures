using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        public int SwopCount { get; protected set; } //количество обменов
        public int ComparisonCount { get; protected set; } //количество сравнений

        public TimeSpan Sort()
        {
            SwopCount = 0;
            ComparisonCount = 0;

            var timer = new Stopwatch();

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        // Переопределяется для каждого отдельного алгоритма сортировки
        protected virtual void MakeSort()
        {
            Items.Sort();
        }


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
