using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        private List<SortedItem> items = new List<SortedItem>();
        private const int sleep = 50;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbAdd.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }

            RefreshItems();
            tbAdd.Text = "";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbFill.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);
                }
            }

            RefreshItems();
            tbFill.Text = "";
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();
            panel3.Refresh();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            panel3.Refresh();
        }

        private void AlgorithmSwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Aqua);
            e.Item2.SetColor(Color.Brown);
            panel3.Refresh();

            Thread.Sleep(sleep);

            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(sleep);
        }

        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(sleep);
        }

        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Red);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item2.SetPosition(e.Item1);
            panel3.Refresh();

            Thread.Sleep(sleep);

            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(sleep);
        }

        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel3.Refresh();

            //algorithm.CompareEvent += AlgorithmCompareEvent;
            //algorithm.SwopEvent += AlgorithmSwopEvent;
            //algorithm.SetEvent += AlgorithmSetEvent;
            var time = algorithm.Sort();

            TimeLbl.Text = "Время: " + time.Seconds;
            SwopLbl.Text = "Количество обменов: " + algorithm.SwopCount;
            CompareLbl.Text = "Количество сравнений: " + algorithm.ComparisonCount;
        }

        private void btnBubbleSort_Click_1(object sender, EventArgs e)
        {
            var algorithm = new BubbleSort<int>();
            algorithm.Sort();
        }

        private void btnCocktailSort_Click(object sender, EventArgs e)
        {

        }
    }
}
