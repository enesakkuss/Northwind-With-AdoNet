using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI
{
    public partial class ProductListForm : Form
    {
        private const string ConnectionString = "Server=.;Database=Northwind;Integrated Security = true";
        private ProductService _productService = new ProductService();
        private Product product;
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void grdProductListForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var produtcs = _productService.GetAll();
            grdProductListForm.DataSource = produtcs;


            //using (var conn = new SqlConnection(ConnectionString))
            //using (var comm = new SqlCommand())
            //{
            //    try
            //    {
            //        comm.Connection = conn;
            //        comm.CommandText = "select * from Products";

            //        conn.Open();

            //        var productList = new List<Product>();

            //        using (var dataReader = comm.ExecuteReader())
            //        {
            //            while (dataReader.Read())
            //            {
            //                var product = new Product()
            //                {
            //                    Id = (int)dataReader["ProductID"],
            //                    Name = (string)dataReader["ProductName"],
            //                    SupplierId = dataReader.IsDBNull("SupplierID")
            //                        ? default(int?)
            //                        : dataReader.GetInt32("SupplierID"),
            //                    // CategoryID = (int)dataReader["CategoryID"],
            //                    QuantityPerUnit = (string)dataReader["QuantityPerUnit"],
            //                    //UnitPrice = (decimal)dataReader["UnitPrice"],
            //                    //UnitsInStock = (short)dataReader["UnitsInStock"],
            //                    //UnitsOnOrder = (short)dataReader["UnitsOnOrder"],
            //                    //ReorderLevel = (short)dataReader["ReorderLevel"],
            //                    Discontinued = (bool)dataReader["Discontinued"]
            //                };
            //                // Eğer dataReader["HÜCRE_ADI"] değeri veritabanından NULL
            //                // değer geliyorsa aşağıdaki satır runtime'da hata fırlatacaktır
            //                // Result Set'ten NULL gelebilecel değerleri aşağıdaki gibi
            //                // doğrudan cas etme işlemi yapamam
            //                // product.SupplierId = (int)dataReader["SupplierID"];

            //                // Result Set'ten NULL gelebilecek değerleri aşağıdaki örneklerde
            //                // olduğu gibi kontrollü bir şekilde karşılamam gerekiyor

            //                //product.SupplierId =
            //                //    dataReader["SupplierID"] == DBNull.Value
            //                //    ? null
            //                //    : (int)dataReader["SupplierID"];

            //                //product.SupplierId = 
            //                //    dataReader.IsDBNull("SupplierID")
            //                //    ? null // (int?) null
            //                //    : (int)dataReader["SupplierID"];

            //                //product.SupplierId =
            //                //    dataReader.IsDBNull("SupplierID")
            //                //    ? default(int?)
            //                //    : dataReader.GetInt32("SupplierID");

            //                // TODO: Extension method GELİŞTİRİLECEK
            //                // Sonra geliştirilecek Extension Method
            //                //product.SupplierId = dataReader.GetNullableInt32("SupplierId");

            //                product.CategoryID = 
            //                    dataReader.IsDBNull("CategoryID")
            //                    ? default(int?)
            //                    : dataReader.GetInt32("CategoryID");

            //                product.UnitPrice = dataReader["UnitPrice"] == DBNull.Value
            //                    ? null
            //                    : (decimal)dataReader["UnitPrice"];

            //                product.UnitsInStock =
            //                    dataReader.IsDBNull("UnitsInStock")
            //                    ? (short?)null
            //                    : dataReader.GetInt16("UnitsInStock");

            //                product.UnitsOnOrder = !dataReader.IsDBNull("UnitsOnOrder")
            //                    ? (short)dataReader["UnitsOnOrder"]
            //                    : default ;

            //                product.ReorderLevel = dataReader.IsDBNull("ReorderLevel")
            //                    ? default(short?)
            //                    : (short)dataReader["ReorderLevel"];

            //                productList.Add(product);
            //            }
            //        }
            //        conn.Close();

            //        grdProductListForm.DataSource = productList;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Kayıtlar Yüklenemedi" + "\n" + ex);

            //    }
            //}
        }

        private void NullableTest()
        {
            // Normal Int32 değişkeni , yani null değer kabul edemez
            int number = 10;
            number = 1;
            number = default;
            //number = null
            // yukarıdaki satır doğal olarak bir derleme hatasına sebep olur

            // nullableNumber isimli diğişken null değer atanabilir bir Iny32
            // uzuun uzun yazım şekil Nullable<int>
            // Kısace int?
            Nullable<int> nullableNumber = 10;
            nullableNumber = 0;
            nullableNumber = null;
            nullableNumber= default;// int? nullable Int32 tiplerin default (varsayılan)
            // değeri 0 değill null değeridir !!

            // int? tipindeki bir değişkene int tipindeki bir değişkenim değerini
            // doğrudan atayabilirim
            // meali; null geçilebilir bir değişkene null geçilemeyen bir değişkenin
            // değerini atayabilirim
            nullableNumber = number;

            // int tipindeki bir değişkene int? (yani nullable) tipindek bir değişkenden 
            // değeri doğrudan atama yapamam. burada bir nevi kontrollü bir atama işlme
            // yapılması gerekiyor
            //.HasValur => Bu değişkenim değeri var mı?(yani null değilse true)
            // .Value => int tipindeki değeri döndürür
            number = nullableNumber.HasValue
                ? nullableNumber.Value
                : default;

            // nullableNumber değişkeninin .Value ile değerini doğrudan okumak sakıncalıdır
            // Eğer değişkenin değeri null ise bu işlem Exceptionfırlatılmasına sebep olur
            number = nullableNumber.Value;

            // Nullable değişkenleri  genellikle tip ismnin yanına ? ekleyerek tanımlarız
            // Nullable<int> şeklinde pek yazılmaz
            int? nullableNumber2 = 10;
            nullableNumber2=null;

            // Sadece int? değil, diğer tüm değer tipli(yani özünde struct yapı olan) tipler
            // nullable olarak tanımlanabilir
            // örneğin short?
            short? unitsInStock = 10;
            unitsInStock = null;

            var product = new Product();

            // Nullable tipler yalnızca değişkenlerde değili Property, Field,Method (dönüş tipi)
            // gibi bir tipe sahip herhangi bir birimde kullanılabilir
            product.SupplierId = null;
            product.CategoryID = null;
        }

        private void ProductListForm_Load_1(object sender, EventArgs e)
        {
            var produtcs = _productService.GetAll();
            grdProductListForm.DataSource = produtcs;
        }

        private void grdProductListForm_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                grdProductListForm.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuProductUpdateForm_Click(object sender, EventArgs e)
        {
            if(grdProductListForm.SelectedRows.Count>0)
            {
                var product = (Product)grdProductListForm.SelectedRows[0].DataBoundItem;

                var productUpdateForm = new ProductUpdateForm((int)product.Id);
                productUpdateForm.MdiParent = this.MdiParent;
                productUpdateForm.Show();
            }
        }

        private void menuProductDeleteForm_Click(object sender, EventArgs e)
        {
            var product = (Product)grdProductListForm.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show($"{product.Name} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Dikkat!!", MessageBoxButtons.YesNo);

            if(result== DialogResult.Yes)
            {
                grdProductListForm.DataSource = _productService.Delete(product);
            }
            grdProductListForm.DataSource = _productService.GetAll();
        }
    }
}
