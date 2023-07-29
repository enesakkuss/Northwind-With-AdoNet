namespace TheNorthwind.UI
{
    partial class SupplierListForm
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
            this.grdSupplierList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSupplierUpdateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierDeleteForm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSupplierList
            // 
            this.grdSupplierList.AllowUserToAddRows = false;
            this.grdSupplierList.AllowUserToDeleteRows = false;
            this.grdSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplierList.ContextMenuStrip = this.contextMenuStrip1;
            this.grdSupplierList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSupplierList.Location = new System.Drawing.Point(0, 0);
            this.grdSupplierList.MultiSelect = false;
            this.grdSupplierList.Name = "grdSupplierList";
            this.grdSupplierList.ReadOnly = true;
            this.grdSupplierList.RowTemplate.Height = 25;
            this.grdSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSupplierList.Size = new System.Drawing.Size(800, 450);
            this.grdSupplierList.TabIndex = 0;
            this.grdSupplierList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSupplierList_CellContentClick);
            this.grdSupplierList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSupplierList_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSupplierUpdateForm,
            this.menuSupplierDeleteForm});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // menuSupplierUpdateForm
            // 
            this.menuSupplierUpdateForm.Name = "menuSupplierUpdateForm";
            this.menuSupplierUpdateForm.Size = new System.Drawing.Size(165, 22);
            this.menuSupplierUpdateForm.Text = "Tedarikçi Düzenle";
            this.menuSupplierUpdateForm.Click += new System.EventHandler(this.menuSupplierUpdateForm_Click);
            // 
            // menuSupplierDeleteForm
            // 
            this.menuSupplierDeleteForm.Name = "menuSupplierDeleteForm";
            this.menuSupplierDeleteForm.Size = new System.Drawing.Size(165, 22);
            this.menuSupplierDeleteForm.Text = "Tedarikçi Sil";
            this.menuSupplierDeleteForm.Click += new System.EventHandler(this.menuSupplierDeleteForm_Click);
            // 
            // SupplierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSupplierList);
            this.Name = "SupplierListForm";
            this.Text = "SupplierListForm";
            this.Load += new System.EventHandler(this.SupplierListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdSupplierList;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuSupplierUpdateForm;
        private ToolStripMenuItem menuSupplierDeleteForm;
    }
}