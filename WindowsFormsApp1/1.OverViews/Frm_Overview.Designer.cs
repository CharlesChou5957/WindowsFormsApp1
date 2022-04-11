
namespace WindowsFormsApp1._1.OverViews
{
    partial class Frm_Overview
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
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTableAdapterProduct = new System.Windows.Forms.Button();
            this.btnDisconnectedAws = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnectCategories = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productsTableAdapter1 = new WindowsFormsApp1.NWDataSetTableAdapters.ProductsTableAdapter();
            this.nwDataSet1 = new WindowsFormsApp1.NWDataSet();
            this.btnTableAdapterCategor = new System.Windows.Forms.Button();
            this.categoriesTableAdapter1 = new WindowsFormsApp1.NWDataSetTableAdapters.CategoriesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnected
            // 
            this.btnConnected.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnected.Location = new System.Drawing.Point(22, 21);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(118, 30);
            this.btnConnected.TabIndex = 0;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnected.Location = new System.Drawing.Point(8, 28);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(266, 30);
            this.btnDisconnected.TabIndex = 1;
            this.btnDisconnected.Text = "DisConnected_Products";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // lbShow
            // 
            this.lbShow.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 19;
            this.lbShow.Location = new System.Drawing.Point(40, 102);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(539, 308);
            this.lbShow.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 697);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbShow);
            this.tabPage1.Controls.Add(this.btnConnected);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connected";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTableAdapterCategor);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnTableAdapterProduct);
            this.tabPage2.Controls.Add(this.btnDisconnectedAws);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnDisconnectCategories);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Controls.Add(this.btnDisconnected);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Disconneted setData";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 202);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnTableAdapterProduct
            // 
            this.btnTableAdapterProduct.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTableAdapterProduct.Location = new System.Drawing.Point(8, 256);
            this.btnTableAdapterProduct.Name = "btnTableAdapterProduct";
            this.btnTableAdapterProduct.Size = new System.Drawing.Size(266, 30);
            this.btnTableAdapterProduct.TabIndex = 6;
            this.btnTableAdapterProduct.Text = "Products";
            this.btnTableAdapterProduct.UseVisualStyleBackColor = true;
            this.btnTableAdapterProduct.Click += new System.EventHandler(this.btnTableAdapterProduct_Click);
            // 
            // btnDisconnectedAws
            // 
            this.btnDisconnectedAws.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnectedAws.Location = new System.Drawing.Point(10, 153);
            this.btnDisconnectedAws.Name = "btnDisconnectedAws";
            this.btnDisconnectedAws.Size = new System.Drawing.Size(266, 34);
            this.btnDisconnectedAws.TabIndex = 5;
            this.btnDisconnectedAws.Text = "DisConnected_Aws";
            this.btnDisconnectedAws.UseVisualStyleBackColor = true;
            this.btnDisconnectedAws.Click += new System.EventHandler(this.btnDisconnectedAws_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1131, 10);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnDisconnectCategories
            // 
            this.btnDisconnectCategories.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnectCategories.Location = new System.Drawing.Point(8, 99);
            this.btnDisconnectCategories.Name = "btnDisconnectCategories";
            this.btnDisconnectCategories.Size = new System.Drawing.Size(266, 34);
            this.btnDisconnectCategories.TabIndex = 3;
            this.btnDisconnectCategories.Text = "DisConnected_Categories";
            this.btnDisconnectCategories.UseVisualStyleBackColor = true;
            this.btnDisconnectCategories.Click += new System.EventHandler(this.btnDisconnectCategories_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(293, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(846, 202);
            this.dataGridView.TabIndex = 2;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTableAdapterCategor
            // 
            this.btnTableAdapterCategor.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTableAdapterCategor.Location = new System.Drawing.Point(10, 310);
            this.btnTableAdapterCategor.Name = "btnTableAdapterCategor";
            this.btnTableAdapterCategor.Size = new System.Drawing.Size(266, 30);
            this.btnTableAdapterCategor.TabIndex = 8;
            this.btnTableAdapterCategor.Text = "Categories";
            this.btnTableAdapterCategor.UseVisualStyleBackColor = true;
            this.btnTableAdapterCategor.Click += new System.EventHandler(this.btnTableAdapterCategor_Click);
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 697);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Overview";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDisconnectCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnectedAws;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTableAdapterProduct;
        private NWDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private NWDataSet nwDataSet1;
        private System.Windows.Forms.Button btnTableAdapterCategor;
        private NWDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
    }
}