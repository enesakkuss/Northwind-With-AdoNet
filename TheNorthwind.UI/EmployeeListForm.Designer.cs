namespace TheNorthwind.UI
{
    partial class EmployeeListForm
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
            this.grdEmployeeListForm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuUpdateEmployeeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteUpdateForm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeListForm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEmployeeListForm
            // 
            this.grdEmployeeListForm.AllowUserToAddRows = false;
            this.grdEmployeeListForm.AllowUserToDeleteRows = false;
            this.grdEmployeeListForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployeeListForm.ContextMenuStrip = this.contextMenuStrip1;
            this.grdEmployeeListForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmployeeListForm.Location = new System.Drawing.Point(0, 0);
            this.grdEmployeeListForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdEmployeeListForm.MultiSelect = false;
            this.grdEmployeeListForm.Name = "grdEmployeeListForm";
            this.grdEmployeeListForm.ReadOnly = true;
            this.grdEmployeeListForm.RowHeadersWidth = 51;
            this.grdEmployeeListForm.RowTemplate.Height = 25;
            this.grdEmployeeListForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployeeListForm.Size = new System.Drawing.Size(914, 600);
            this.grdEmployeeListForm.TabIndex = 0;
            this.grdEmployeeListForm.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdEmployeeListForm_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdateEmployeeForm,
            this.menuDeleteUpdateForm});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 80);
            // 
            // menuUpdateEmployeeForm
            // 
            this.menuUpdateEmployeeForm.Name = "menuUpdateEmployeeForm";
            this.menuUpdateEmployeeForm.Size = new System.Drawing.Size(250, 24);
            this.menuUpdateEmployeeForm.Text = "Çalışan Bilgilerini Düzenle";
            this.menuUpdateEmployeeForm.Click += new System.EventHandler(this.menuUpdateEmployeeForm_Click);
            // 
            // menuDeleteUpdateForm
            // 
            this.menuDeleteUpdateForm.Name = "menuDeleteUpdateForm";
            this.menuDeleteUpdateForm.Size = new System.Drawing.Size(250, 24);
            this.menuDeleteUpdateForm.Text = "Çalışan Sil";
            this.menuDeleteUpdateForm.Click += new System.EventHandler(this.menuDeleteUpdateForm_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.grdEmployeeListForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeListForm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdEmployeeListForm;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuUpdateEmployeeForm;
        private ToolStripMenuItem menuDeleteUpdateForm;
    }
}