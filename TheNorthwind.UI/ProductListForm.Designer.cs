namespace TheNorthwind.UI
{
    partial class ProductListForm
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
            this.components = new System.ComponentModel.Container();
            this.grdProductListForm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuProductUpdateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductDeleteForm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductListForm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProductListForm
            // 
            this.grdProductListForm.AllowUserToAddRows = false;
            this.grdProductListForm.AllowUserToDeleteRows = false;
            this.grdProductListForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductListForm.ContextMenuStrip = this.contextMenuStrip1;
            this.grdProductListForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductListForm.Location = new System.Drawing.Point(0, 0);
            this.grdProductListForm.MultiSelect = false;
            this.grdProductListForm.Name = "grdProductListForm";
            this.grdProductListForm.ReadOnly = true;
            this.grdProductListForm.RowTemplate.Height = 25;
            this.grdProductListForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductListForm.Size = new System.Drawing.Size(800, 450);
            this.grdProductListForm.TabIndex = 0;
            this.grdProductListForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductListForm_CellContentClick);
            this.grdProductListForm.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdProductListForm_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductUpdateForm,
            this.menuProductDeleteForm});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 48);
            // 
            // menuProductUpdateForm
            // 
            this.menuProductUpdateForm.Name = "menuProductUpdateForm";
            this.menuProductUpdateForm.Size = new System.Drawing.Size(149, 22);
            this.menuProductUpdateForm.Text = "Ürün Güncelle";
            this.menuProductUpdateForm.Click += new System.EventHandler(this.menuProductUpdateForm_Click);
            // 
            // menuProductDeleteForm
            // 
            this.menuProductDeleteForm.Name = "menuProductDeleteForm";
            this.menuProductDeleteForm.Size = new System.Drawing.Size(149, 22);
            this.menuProductDeleteForm.Text = "Ürün Sil";
            this.menuProductDeleteForm.Click += new System.EventHandler(this.menuProductDeleteForm_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProductListForm);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.Load += new System.EventHandler(this.ProductListForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductListForm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdProductListForm;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuProductUpdateForm;
        private ToolStripMenuItem menuProductDeleteForm;
    }
}