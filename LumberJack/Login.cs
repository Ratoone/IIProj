using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LumberJack
{
    public partial class Login : Form
    {
        SqlConnection myCon;
        public Login()
        {
            InitializeComponent();
            myCon = new SqlConnection(); // set up a SQL Connection object
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myFirstDB.mdf;Integrated Security=True";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string pass = passBox.Text;

            OperatorForm op = new OperatorForm(op);
            op.Show();
        }

    }
}
