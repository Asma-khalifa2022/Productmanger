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
    public partial class FRM_Add_Category : Form
    {
        public FRM_Add_Category()
        {
            InitializeComponent();
        }
        DataSet1.CategoriesDataTable tc = new DataSet1.CategoriesDataTable();
        DataSet1TableAdapters.CategoriesTableAdapter atc = new DataSet1TableAdapters.CategoriesTableAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            atc.InsertQuery(txt_CAT.Text);
            MessageBox.Show("تمت الإضافة بنجاح");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("انتبه", "هل أنت متأكد من حذف العنصر المحدد؟", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                atc.DeleteQuery(txt_editor.Text);
            }
            MessageBox.Show("تم حذف العنصر بنجاح");

        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
           // textBox3.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tc = atc.sellectall();
            DGV_CAT.DataSource = tc;
            DGV_CAT.Columns[0].HeaderText = "التسلسل";
            DGV_CAT.Columns[1].HeaderText = "اسم الصنف";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            atc.UpdateQuery(textBox3.Text, txt_editor.Text );

            MessageBox.Show("تم التعديل بنجاح");

        }

        private void FRM_Add_Product_Load(object sender, EventArgs e)
        {
           
        }

        private void DGV_CAT_SelectionChanged(object sender, EventArgs e)
        {
            txt_editor.Text = DGV_CAT.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
