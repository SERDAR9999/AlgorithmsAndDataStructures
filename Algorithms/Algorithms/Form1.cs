using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            AlgorithmBase<int> algorithm = new BubbleSort<int>();

            algorithm.Sort();

            string str = "jdlsdl";

            label1.Text = nameof(str);
        }
    }
}
