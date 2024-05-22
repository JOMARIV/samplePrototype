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
    public partial class managerMenu : Form
    {
        public managerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderHistory oh = new orderHistory();

            oh.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm lg = new loginForm();

            lg.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeList el = new employeeList();

            el.Show();

            this.Close();
        }
    }
}
