using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_FindPrimes(object sender, EventArgs e)
        {
            int bound = Convert.ToInt32(uxTextBoxInput.Text);
            SieveList list = new SieveList();
            list.BuildList(bound);
            list.FindPrimes();
            StringBuilder sb = new StringBuilder();
            foreach(int num in list)
            {
                sb.Append(num + " ");
            }
            uxTextBoxPrimeList.Text = sb.ToString();
        }
    }
}
