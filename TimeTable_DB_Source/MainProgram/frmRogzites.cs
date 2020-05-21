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

namespace MainProgram
{
    public partial class frmRogzites : Form
    {
        public frmRogzites()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;attachdbfilename=D:\Training\timetable_program\TimeTable_DB_Source\TimeTable_DB_Source\db\Login.mdf;integrated security=True;connect timeout=30");

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
