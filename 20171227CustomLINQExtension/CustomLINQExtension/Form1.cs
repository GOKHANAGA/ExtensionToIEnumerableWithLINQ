using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LINQExtensions;

namespace CustomLINQExtension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            List<int> medianTrial = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 18 };

            //lstMedian.Items.Add(medianTrial.SelectGivenElement(o=>o==(medianTrial.Count/2)));
            lstMedian.DataSource = medianTrial.NotSelect(s => s > 5);
        }
    }
}
