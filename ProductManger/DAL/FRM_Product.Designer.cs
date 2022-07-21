namespace ProductManger.DAL
{
    partial class FRM_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DGV_Pro = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 63);
            this.panel2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ProductManger.Properties.Resources._2992643_box_checklist_export_management_package_icon1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(635, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "المنتجات";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Image = global::ProductManger.Properties.Resources._31230_minus_out_zoom_icon;
            this.button6.Location = new System.Drawing.Point(52, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 44);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::ProductManger.Properties.Resources._58669_find_search_icon;
            this.button7.Location = new System.Drawing.Point(104, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 44);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = global::ProductManger.Properties.Resources._9004715_cross_delete_remove_cancel_;
            this.button10.Location = new System.Drawing.Point(0, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 44);
            this.button10.TabIndex = 0;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(186, 87);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(433, 24);
            this.txt_search.TabIndex = 16;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F);
            this.label1.Location = new System.Drawing.Point(655, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "ابحث هنا";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(529, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(635, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 41);
            this.button5.TabIndex = 29;
            this.button5.Text = "اضافة";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(228, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 41);
            this.button3.TabIndex = 32;
            this.button3.Text = "عرض الصورة";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(419, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 41);
            this.button4.TabIndex = 31;
            this.button4.Text = "تعديل";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DGV_Pro
            // 
            this.DGV_Pro.AllowUserToAddRows = false;
            this.DGV_Pro.AllowUserToDeleteRows = false;
            this.DGV_Pro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Pro.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pro.Location = new System.Drawing.Point(12, 141);
            this.DGV_Pro.Name = "DGV_Pro";
            this.DGV_Pro.ReadOnly = true;
            this.DGV_Pro.RowHeadersWidth = 51;
            this.DGV_Pro.RowTemplate.Height = 26;
            this.DGV_Pro.Size = new System.Drawing.Size(832, 328);
            this.DGV_Pro.TabIndex = 33;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Cooper Black", 13.8F);
            this.button8.Image = global::ProductManger.Properties.Resources._211614_down_b_arrow_icon;
            this.button8.Location = new System.Drawing.Point(810, 104);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 31);
            this.button8.TabIndex = 34;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // FRM_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 533);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.DGV_Pro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_Product_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DGV_Pro;
        private System.Windows.Forms.Button button8;
    }
}