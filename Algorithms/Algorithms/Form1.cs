// Визуализации алгоритмов сортировки https://tproger.ru/digest/sorting-algorithms-visualized/


using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        private List<int> listItems = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbAddItem.Text, out int value))
            {
                listItems.Add(value);
            }

            tbAddItem.Text = "";
            tbArrayItems.Text += string.Join(" ", listItems.ToArray());
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            listItems.Clear();

            if (int.TryParse(tbCountItem.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    listItems.Add(rnd.Next(100));
                }
            }

            tbCountItem.Text = "";
            tbArrayItems.Text = string.Join(" ", listItems.ToArray());
        }

        private void btnClearArray_Click(object sender, EventArgs e)
        {
            listItems.Clear();
            tbArrayItems.Text = "";
            tbSortedArray.Text = "";
        }

        private void SortAndOutputInfo(AlgorithmBase<int> algorithm)
        {
            algorithm.Sort();
            tbSortedArray.Text = string.Join(" ", algorithm.Items.ToArray());

            lbTime.Text = "Время: " + algorithm.SortingTime;
            lbSwop.Text = "Количество обменов: " + algorithm.SwopCount;
            lbCompare.Text = "Количество сравнений: " + algorithm.ComparisonCount;
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            List<int> list = listItems.GetRange(0, listItems.Count);
            var algorithm = new BubbleSort<int>(list);
            SortAndOutputInfo(algorithm);
        }

        private void btnCocktailSort_Click(object sender, EventArgs e)
        {
            List<int> list = listItems.GetRange(0, listItems.Count);
            var algorithm = new CocktailSort<int>(list);
            SortAndOutputInfo(algorithm);
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            List<int> list = listItems.GetRange(0, listItems.Count);
            var algorithm = new InsertionSort<int>(list);
            SortAndOutputInfo(algorithm);
        }
    }
}
