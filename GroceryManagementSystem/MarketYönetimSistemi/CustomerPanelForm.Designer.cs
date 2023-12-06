namespace MarketYönetimSistemi
{
    partial class CustomerPanelForm
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
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddProductBtn.Location = new System.Drawing.Point(29, 287);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(176, 33);
            this.AddProductBtn.TabIndex = 10;
            this.AddProductBtn.Text = "Add To Basket";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grocery Products";
            // 
            // ProductDgv
            // 
            this.ProductDgv.AllowUserToAddRows = false;
            this.ProductDgv.AllowUserToDeleteRows = false;
            this.ProductDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDgv.Location = new System.Drawing.Point(29, 46);
            this.ProductDgv.Name = "ProductDgv";
            this.ProductDgv.ReadOnly = true;
            this.ProductDgv.RowHeadersVisible = false;
            this.ProductDgv.RowHeadersWidth = 51;
            this.ProductDgv.RowTemplate.Height = 24;
            this.ProductDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDgv.Size = new System.Drawing.Size(550, 235);
            this.ProductDgv.TabIndex = 8;
            // 
            // CustomerPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductDgv);
            this.Name = "CustomerPanelForm";
            this.Text = "CustomerPanelForm";
            this.Load += new System.EventHandler(this.CustomerPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductDgv;
    }
}