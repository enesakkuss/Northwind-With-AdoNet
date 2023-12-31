﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNorthwind.UI
{
    public partial class UpdateUnitPricesConfimartionBox : Form
    {
        private readonly List<Product> _products;
        public UpdateUnitPricesConfimartionBox(List<Product> products)
        {
            InitializeComponent();
            _products = products;
        }

        private void UpdateUnitPricesConfimartionBox_Load(object sender, EventArgs e)
        {
            grdProducts.DataSource = _products;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Yes;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.No;
            Close();
        }
    }
}
