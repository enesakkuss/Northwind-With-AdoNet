namespace TheNorthwind.UI
{
    partial class ShipperListForm
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
            this.grdShipperListForm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuShipperUpdateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperDeleteForm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdShipperListForm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdShipperListForm
            // 
            this.grdShipperListForm.AllowUserToAddRows = false;
            this.grdShipperListForm.AllowUserToDeleteRows = false;
            this.grdShipperListForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShipperListForm.ContextMenuStrip = this.contextMenuStrip1;
            this.grdShipperListForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdShipperListForm.Location = new System.Drawing.Point(0, 0);
            this.grdShipperListForm.MultiSelect = false;
            this.grdShipperListForm.Name = "grdShipperListForm";
            this.grdShipperListForm.ReadOnly = true;
            this.grdShipperListForm.RowTemplate.Height = 25;
            this.grdShipperListForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdShipperListForm.Size = new System.Drawing.Size(800, 450);
            this.grdShipperListForm.TabIndex = 0;
            this.grdShipperListForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdShipperListForm_CellContentClick);
            this.grdShipperListForm.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdShipperListForm_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShipperUpdateForm,
            this.menuShipperDeleteForm});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // menuShipperUpdateForm
            // 
            this.menuShipperUpdateForm.Name = "menuShipperUpdateForm";
            this.menuShipperUpdateForm.Size = new System.Drawing.Size(180, 22);
            this.menuShipperUpdateForm.Text = "Nakliyeci Güncelle";
            this.menuShipperUpdateForm.Click += new System.EventHandler(this.menuShipperUpdateForm_Click);
            // 
            // menuShipperDeleteForm
            // 
            this.menuShipperDeleteForm.Name = "menuShipperDeleteForm";
            this.menuShipperDeleteForm.Size = new System.Drawing.Size(180, 22);
            this.menuShipperDeleteForm.Text = "Nakliyeci Sil";
            this.menuShipperDeleteForm.Click += new System.EventHandler(this.menuShipperDeleteForm_Click);
            // 
            // ShipperListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdShipperListForm);
            this.Name = "ShipperListForm";
            this.Text = "ShipperListForm";
            this.Load += new System.EventHandler(this.ShipperListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShipperListForm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdShipperListForm;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuShipperUpdateForm;
        private ToolStripMenuItem menuShipperDeleteForm;
    }
}