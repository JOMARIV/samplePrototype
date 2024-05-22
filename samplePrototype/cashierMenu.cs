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
    public partial class cashierMenu : Form
    {
        public cashierMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm lg = new loginForm();

            lg.Show();

            this.Close();
        }
    }
}
