using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ProductManger.DAL
{
    public partial class UPdate_Pro : Form
    {
        public UPdate_Pro()
        {
            InitializeComponent();
            comboBox1.DataSource = atc.sellectall();
            comboBox1.DisplayMember = "Categores_Name";
            comboBox1.ValueMember = "Id_Categores";
        }
        DataSet1.ProductsDataTable t = new DataSet1.ProductsDataTable();
        DataSet1TableAdapters.ProductsTableAdapter at = new DataSet1TableAdapters.ProductsTableAdapter();


        DataSet1TableAdapters.CategoriesTableAdapter atc = new DataSet1TableAdapters.CategoriesTableAdapter();
        private void button5_Click(object sender, EventArgs e)
        {
            //MemoryStream ms = new MemoryStream();
            //pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            //byte[] img = ms.ToArray();
            //atc.UpdateQuery(txt_id.Text, txt_name.Text, int.Parse(numericUpDown1.Value.ToString()), int.Parse(txt_sale.Text), int.Parse(txt_buy.Text), img, int.Parse(comboBox1.SelectedValue.ToString()));
            //txt_id.Clear();
            //txt_name.Clear();
            //numericUpDown1.Value = 0;
            //txt_sale.Clear();
            //txt_buy.Clear();
            //txt_id.Focus();
            //MessageBox.Show("تم التعديل بنجاح");






        }
    }
}
