using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainProgram;


namespace UserLogin
{

    
    public partial class frmLogin : Form
               
    {

        frmMainProgram main = new frmMainProgram();
        public frmLogin()
        {
            InitializeComponent();
            setToolTip();
        }

        private void setToolTip() {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.tbUserName, "Add meg a felhasználónevet!");
            tip.SetToolTip(this.tbPassword, "Add meg a jelszót!");
       

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnEntrance_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Training\timetable_program\TimeTable_DB_Source\TimeTable_DB_Source\db\Login.mdf;integrated security=True;connect timeout=30;");
            string querry = "SELECT * FROM enSzemelyek WHERE UserName='" + tbUserName.Text.Trim() + "'and Password ='" +tbPassword.Text.Trim() + "'";
            
            SqlDataAdapter sda = new SqlDataAdapter(querry, sqlconn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                main.ShowDialog();



            }
            else
            {
                MessageBox.Show("Rossz felhasználónevet/jelszót adott meg", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}
