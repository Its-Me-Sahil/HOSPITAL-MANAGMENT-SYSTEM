//Form3.cs [View Patient]
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-362VLFIO\\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "SELECT * FROM AddPatient";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
            
            con.Close();
        }
    }
}
 
