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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           DAL.FRM_Add_Category C= new DAL.FRM_Add_Category();
            C.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DAL.FRM_Product P = new FRM_Product();
            P.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Login L = new FRM_Login();
            L.ShowDialog();
        }
    }
}
