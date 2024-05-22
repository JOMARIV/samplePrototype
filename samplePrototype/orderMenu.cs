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
    public partial class orderMenu : Form
    {
        public orderMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transactionMenu tm = new transactionMenu();

            tm.Show();

            this.Close();
        }
    }
}
