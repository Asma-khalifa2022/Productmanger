using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManger.DAL
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }
        DataSet1.UsersDataTable t = new DataSet1.UsersDataTable();
        DataSet1TableAdapters.UsersTableAdapter at = new DataSet1TableAdapters.UsersTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            at.InsertQuery(textBox1.Text, textBox2.Text);
            Main M = Application.OpenForms["Main"] as Main;
            M.button6.Enabled = true;
            M.button7.Enabled = true;
            M.button8.Enabled = true;

        }
    }
}
