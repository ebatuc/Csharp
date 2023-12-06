namespace MarketYönetimSistemi
{
    partial class AdminPanelForm
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
            this.marketLbl = new System.Windows.Forms.Label();
            this.ProductDgv = new System.Windows.Forms.DataGridView();
            this.CustomerDgv = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductEditBtn = new System.Windows.Forms.Button();
            this.ProductDeleteBtn = new System.Windows.Forms.Button();
            this.CustomerDeleteBtn = new System.Windows.Forms.Button();
            this.CustomerEditBtn = new System.Windows.Forms.Button();
            this.CustomerAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // marketLbl
            // 
            this.marketLbl.AutoSize = true;
            this.marketLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marketLbl.Location = new System.Drawing.Point(480, 40);
            this.marketLbl.Name = "marketLbl";
            this.marketLbl.Size = new System.Drawing.Size(267, 29);
            this.marketLbl.TabIndex = 0;
            this.marketLbl.Text = "Market Yönetim Sistemi";
            this.marketLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductDgv
            // 
            this.ProductDgv.AllowUserToAddRows = false;
            this.ProductDgv.AllowUserToDeleteRows = false;
            this.ProductDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDgv.Location = new System.Drawing.Point(25, 111);
            this.ProductDgv.Name = "ProductDgv";
            this.ProductDgv.ReadOnly = true;
            this.ProductDgv.RowHeadersVisible = false;
            this.ProductDgv.RowHeadersWidth = 51;
            this.ProductDgv.RowTemplate.Height = 24;
            this.ProductDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDgv.Size = new System.Drawing.Size(550, 235);
            this.ProductDgv.TabIndex = 1;
            this.ProductDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDgv_CellContentClick);
            // 
            // CustomerDgv
            // 
            this.CustomerDgv.AllowUserToAddRows = false;
            this.CustomerDgv.AllowUserToDeleteRows = false;
            this.CustomerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDgv.Location = new System.Drawing.Point(702, 111);
            this.CustomerDgv.Name = "CustomerDgv";
            this.CustomerDgv.ReadOnly = true;
            this.CustomerDgv.RowHeadersVisible = false;
            this.CustomerDgv.RowHeadersWidth = 51;
            this.CustomerDgv.RowTemplate.Height = 24;
            this.CustomerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDgv.Size = new System.Drawing.Size(550, 235);
            this.CustomerDgv.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(371, 447);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(550, 235);
            this.dataGridView3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Tracking List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(698, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(367, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reports";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddProductBtn.Location = new System.Drawing.Point(25, 352);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(176, 33);
            this.AddProductBtn.TabIndex = 7;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductEditBtn
            // 
            this.ProductEditBtn.BackColor = System.Drawing.Color.Gold;
            this.ProductEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductEditBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductEditBtn.Location = new System.Drawing.Point(212, 352);
            this.ProductEditBtn.Name = "ProductEditBtn";
            this.ProductEditBtn.Size = new System.Drawing.Size(176, 33);
            this.ProductEditBtn.TabIndex = 8;
            this.ProductEditBtn.Text = "Edit Product";
            this.ProductEditBtn.UseVisualStyleBackColor = false;
            this.ProductEditBtn.Click += new System.EventHandler(this.ProductEditBtn_Click);
            // 
            // ProductDeleteBtn
            // 
            this.ProductDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductDeleteBtn.Location = new System.Drawing.Point(399, 352);
            this.ProductDeleteBtn.Name = "ProductDeleteBtn";
            this.ProductDeleteBtn.Size = new System.Drawing.Size(176, 33);
            this.ProductDeleteBtn.TabIndex = 9;
            this.ProductDeleteBtn.Text = "Delete Product";
            this.ProductDeleteBtn.UseVisualStyleBackColor = false;
            this.ProductDeleteBtn.Click += new System.EventHandler(this.ProductDeleteBtn_Click);
            // 
            // CustomerDeleteBtn
            // 
            this.CustomerDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CustomerDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerDeleteBtn.Location = new System.Drawing.Point(1076, 352);
            this.CustomerDeleteBtn.Name = "CustomerDeleteBtn";
            this.CustomerDeleteBtn.Size = new System.Drawing.Size(176, 33);
            this.CustomerDeleteBtn.TabIndex = 12;
            this.CustomerDeleteBtn.Text = "Delete Customer";
            this.CustomerDeleteBtn.UseVisualStyleBackColor = false;
            this.CustomerDeleteBtn.Click += new System.EventHandler(this.CustomerDeleteBtn_Click);
            // 
            // CustomerEditBtn
            // 
            this.CustomerEditBtn.BackColor = System.Drawing.Color.Gold;
            this.CustomerEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerEditBtn.Location = new System.Drawing.Point(889, 352);
            this.CustomerEditBtn.Name = "CustomerEditBtn";
            this.CustomerEditBtn.Size = new System.Drawing.Size(176, 33);
            this.CustomerEditBtn.TabIndex = 11;
            this.CustomerEditBtn.Text = "Edit Customer";
            this.CustomerEditBtn.UseVisualStyleBackColor = false;
            this.CustomerEditBtn.Click += new System.EventHandler(this.CustomerEditBtn_Click);
            // 
            // CustomerAddBtn
            // 
            this.CustomerAddBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.CustomerAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerAddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerAddBtn.Location = new System.Drawing.Point(702, 352);
            this.CustomerAddBtn.Name = "CustomerAddBtn";
            this.CustomerAddBtn.Size = new System.Drawing.Size(176, 33);
            this.CustomerAddBtn.TabIndex = 10;
            this.CustomerAddBtn.Text = "Add Customer";
            this.CustomerAddBtn.UseVisualStyleBackColor = false;
            this.CustomerAddBtn.Click += new System.EventHandler(this.CustomerAddBtn_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 746);
            this.Controls.Add(this.CustomerDeleteBtn);
            this.Controls.Add(this.CustomerEditBtn);
            this.Controls.Add(this.CustomerAddBtn);
            this.Controls.Add(this.ProductDeleteBtn);
            this.Controls.Add(this.ProductEditBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.CustomerDgv);
            this.Controls.Add(this.ProductDgv);
            this.Controls.Add(this.marketLbl);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marketLbl;
        public System.Windows.Forms.DataGridView ProductDgv;
        private System.Windows.Forms.DataGridView CustomerDgv;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button ProductEditBtn;
        private System.Windows.Forms.Button ProductDeleteBtn;
        private System.Windows.Forms.Button CustomerDeleteBtn;
        private System.Windows.Forms.Button CustomerEditBtn;
        private System.Windows.Forms.Button CustomerAddBtn;
    }
}