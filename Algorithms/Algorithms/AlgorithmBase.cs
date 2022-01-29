using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        protected void Swop(int positionA, int positionB)
        {
            if(positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }

        //public void FillRandom(int count)
        //{
        //    var rnd = new Random();
        //    for (int i = 0; i < Items.Count; i++)
        //    {
        //        Items.Add(rnd.Next(0, 100));
        //    }
        //    Array.Copy(arr_1, arr_2, arr_1.Length);
        //    Array.Copy(arr_1, arr_3, arr_1.Length);
        //}

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
