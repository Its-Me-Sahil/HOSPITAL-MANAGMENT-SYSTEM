//Form1.cs [LogIn form]
namespace HMS6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username == "sahil" && password == "123")
            {
                //MessageBox.Show("login successfull");
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();

            }
            else
            {
                MessageBox.Show("incorrect data");
            }
        }
    }
}
