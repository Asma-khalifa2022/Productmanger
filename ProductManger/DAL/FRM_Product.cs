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
    public partial class FRM_Product : Form
    {
        public FRM_Product()
        {
            InitializeComponent();
        }
        DataSet1.ProductsDataTable tc = new DataSet1.ProductsDataTable();
        DataSet1TableAdapters.ProductsTableAdapter atc = new DataSet1TableAdapters.ProductsTableAdapter();

        private void button5_Click(object sender, EventArgs e)
        {
            DAL.FRM_Add_Product addp = new DAL.FRM_Add_Product();
            addp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DAL.UPdate_Pro U = new DAL.UPdate_Pro();
            //U.ShowDialog();
            DAL.FRM_Add_Product addp = new DAL.FRM_Add_Product();
            addp.txt_id.Text = DGV_Pro.CurrentRow.Cells[0].Value.ToString();
            addp.txt_name.Text = DGV_Pro.CurrentRow.Cells[1].Value.ToString();
            addp.numericUpDown1.Text = DGV_Pro.CurrentRow.Cells[2].Value.ToString();
            addp.txt_sale.Text = DGV_Pro.CurrentRow.Cells[3].Value.ToString();
            addp.txt_buy.Text = DGV_Pro.CurrentRow.Cells[4].Value.ToString();
            addp.Text="تحديث المنتج:"+ DGV_Pro.CurrentRow.Cells[1].Value.ToString();
            addp.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tc = atc.Sellect();
            DGV_Pro.DataSource = tc;

            DGV_Pro.Columns[0].HeaderText = "التسلسل";
            DGV_Pro.Columns[1].HeaderText = "اسم المنتج";
            DGV_Pro.Columns[2].HeaderText = " الكمية";
            DGV_Pro.Columns[3].HeaderText = "سعر المبيع";
            DGV_Pro.Columns[4].HeaderText = " سعر الشراء";
            DGV_Pro.Columns[5].HeaderText = " الصورة ";
            DGV_Pro.Columns[6].HeaderText = " رقم المنتج ";

        }

        private void FRM_Product_Load(object sender, EventArgs e)
        {
            //tc = atc.Select();
            //DGV_Pro.DataSource = tc;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DGV_Pro.DataSource = (txt_search.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("انتبه", "هل أنت متأكد من حذف العنصر المحدد؟", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                atc.DeleteQuery(txt_search.Text);
            }
            MessageBox.Show("تم حذف العنصر بنجاح");

        }
    }
}
