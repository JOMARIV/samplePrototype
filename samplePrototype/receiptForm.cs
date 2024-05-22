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
    public partial class receiptForm : Form
    {
        public receiptForm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();

            loginForm lg = new loginForm();

            lg.Show();
        }
    }
}
