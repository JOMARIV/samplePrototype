using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samplePrototype
{
    public partial class transactionMenu : Form
    {
        public transactionMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderMenu om = new orderMenu();

            om.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            receiptForm rf = new receiptForm();

            rf.Show();

            this.Close();
        }
    }
}
