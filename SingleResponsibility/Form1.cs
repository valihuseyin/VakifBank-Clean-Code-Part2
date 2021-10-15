using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        //Bir sınıf sadece bir işten sorumlu olmalı.
        //Bir sınıfta değişiklik yapmak için birden fazla sebebiniz varsa, bu prensibi ihlal edersiniz.
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
           
            string name = textBoxProductName.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            var productService = new ProductService();
            var affectedRows = productService.AddProduct(name, price);
            var message = affectedRows > 0 ? "Kayıt başarılı " : "Başarısız";
            MessageBox.Show(message);

        }

      
    }
}
