//Dashboard.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace HMS6
{
    public partial class Dashboard : Form
    {
        //public object SqlConnection { get; private set; }

        public Dashboard()
        {
            InitializeComponent();
        }
         private void btnAddPatient_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string contact = txtContact.Text;
            string age = txtAge.Text;
            string gender = comboGender.Text;
            string blood = comboBlood.Text;
            string any = txtAny.Text;
            string pid = txtPid.Text;
            string ConnectionString = "Data Source=LAPTOP-362VLFIO\\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = " INSERT INTO AddPatient values('" + name + "'," + contact + "," + age + ",'" + gender + "','" + blood + "','" + any + "','" + pid + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ds = new Form2();
            ds.Show();
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }
    }
}

 
