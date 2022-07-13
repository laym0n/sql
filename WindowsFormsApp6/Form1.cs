using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "Запрос: \n" +
            "SELECT p.name, c.name\n" +
    "from product p\n" +
    "left join setting s on\n" +
    "s.product_id = p.Id\n" +
    "left join category c on\n" +
    "c.Id = s.category_id\n";
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.all_products". При необходимости она может быть перемещена или удалена.
            this.all_productsTableAdapter.Fill(this.database1DataSet.all_products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.database1DataSet.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.database1DataSet.category);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
