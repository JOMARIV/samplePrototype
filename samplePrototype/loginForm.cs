using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace samplePrototype
{
    public partial class loginForm : Form
    {

        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=adu_sample_db;Uid=root;Pwd=;";

        public loginForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connected to the database!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // After successfully connecting, retrieve data from a table
                string query = "SELECT id, lname, fname FROM students"; // Replace 'your_table' with the name of your table
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to connect to the database: " + ex.Message, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //orderMenu om = new orderMenu();

            //om.Show();

            //this.Hide();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Already connected to the database!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not connected to the database!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String username = textBox1.Text;
                String password = textBox2.Text;

                if (username == "manager" && password == "manager")
                {
                    managerMenu mm = new managerMenu();

                    mm.Show();

                    this.Hide();
                }
                else if (username == "cashier" && password == "cashier")
                {
                    cashierMenu cm = new cashierMenu();

                    cm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input. Please enter valid values.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
