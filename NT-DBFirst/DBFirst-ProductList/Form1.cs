using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst_ProductList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //productıd productname category name
        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            var obj = db.Products.Select(x => new {
                productId = x.ProductID,
                productName = x.ProductName,
                categoryName = x.Category.CategoryName
            }).ToList(); // var yerine IEnumerable yazılabilir. yada IList

            dataGridView1.DataSource = obj;
        }
    }
}
