using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodDeliveryAutomation
{
    public partial class StarbucksEditPage : Form
    {
        SqlConnection dataconnection2 = new SqlConnection("Data Source = VIDENTE\\SQLEXPRESS; Initial Catalog = YemeksepetiAutomation1; Integrated Security = True"); // veritabanı bağlantı satırı
        public StarbucksEditPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StarbucksEditPage_Load(object sender, EventArgs e)
        { 

        }

        private void button9_Click(object sender, EventArgs e) // bu butona basılması durumunda veritabanından tüm bilgiler datagridview'a çekilecektir.
        {
            this.tbl_StarbucksDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet1.tbl_StarbucksDatabase);
        }

        private void button6_Click(object sender, EventArgs e) // bu butona basılması durumunda girilen verilerle ürün ekleme işlemi yapılacaktır, mantık olarak dönemin başında derste yaptığımız uygulama baz alınmıştır.
        {
            dataconnection2.Open();

            SqlCommand komut = new SqlCommand("insert into tbl_StarbucksDatabase(ProductType, ProductName, ProductHeat, ProductContent, ProductPrice, ProductStock," +
            "ProductDescription)" +
            "values (@a1,@a2,@a3,@a4,@a5,@a6,@a7)", dataconnection2);
            komut.Parameters.AddWithValue("@a1", stareditpageType.Text);
            komut.Parameters.AddWithValue("@a2", stareditpageName.Text);
            komut.Parameters.AddWithValue("@a3", stareditpageHC.Text);
            komut.Parameters.AddWithValue("@a4", stareditpageContent.Text);
            komut.Parameters.AddWithValue("@a5", stareditpagePrice.Text);
            komut.Parameters.AddWithValue("@a6", stareditpageStock.Text);
            komut.Parameters.AddWithValue("@a7", stareditpageDescription.Text);
            komut.ExecuteNonQuery();

            dataconnection2.Close();
            MessageBox.Show("Starbucks Ürün Kaydı Başarılı Şekilde Oluşturuldu!");
            this.tbl_StarbucksDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet1.tbl_StarbucksDatabase);
        }

        private void button5_Click(object sender, EventArgs e) // bu butona basılması durumunda ürün silinecektir. burada mantık ID'e göre silmektir çünkü ID primary key olduğundan hep farklı olacaktır.
        {
            dataconnection2.Open();

            SqlCommand komutSil = new SqlCommand("Delete from tbl_StarbucksDatabase where ProductID=@s1", dataconnection2);
            komutSil.Parameters.AddWithValue("@s1", ProductID.Text);
            komutSil.ExecuteNonQuery();

            dataconnection2.Close();
            MessageBox.Show("Starbucks Ürün Silme İşlemi Başarılı!");
            this.tbl_StarbucksDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet1.tbl_StarbucksDatabase);
        }

        private void button7_Click(object sender, EventArgs e) // bu butona basılması durumunda ürün bilgileri güncelleniyor
        {
            dataconnection2.Open();
            string kayit = "Update tbl_StarbucksDatabase Set ProductType = @g1, ProductName = @g2, ProductHeat = @g3," +
            "ProductContent=@g4, ProductPrice=@g5, ProductStock=@g6,ProductDescription=@g7 where ProductID=@g8";
            // ürün ile ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, dataconnection2);
            // sorguyu ve bağlantıyı parametre alan sqlcommand her zamanki gibi oluşturuluyor
            komut.Parameters.AddWithValue("@g1", stareditpageType.Text);
            komut.Parameters.AddWithValue("@g2", stareditpageName.Text);
            komut.Parameters.AddWithValue("@g3", stareditpageHC.Text);
            komut.Parameters.AddWithValue("@g4", stareditpageContent.Text);
            komut.Parameters.AddWithValue("@g5", stareditpagePrice.Text);
            komut.Parameters.AddWithValue("@g6", stareditpageStock.Text);
            komut.Parameters.AddWithValue("@g7", stareditpageDescription.Text);
            komut.Parameters.AddWithValue("@g8", ProductID.Text);
            // parametrelere bilgileri aktarıyoruz
            komut.ExecuteNonQuery();
            // değişiklik bu satırda gerçekleşti (güncelleme)
            dataconnection2.Close();
            MessageBox.Show("Starbucks Ürün Bilgileri Güncellendi.");
            this.tbl_StarbucksDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet1.tbl_StarbucksDatabase);
        }

        private void button8_Click(object sender, EventArgs e) // bu buton textboxladaki verileri temizlemeye yarıyor, her box " " yani boş şekilde değiştiriliyor.
        {
            ProductID.Text = "";
            stareditpageType.Text = "";
            stareditpageName.Text = "";
            stareditpageContent.Text = "";
            stareditpagePrice.Text = "";
            stareditpageStock.Text = "";
            stareditpageHC.Text = "";
            stareditpageDescription.Text = "";
            MessageBox.Show("Starbucks Ürün Verileri Temizlendi!");
            this.tbl_StarbucksDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet1.tbl_StarbucksDatabase);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e) // datagridview'in mouse double click eventi kullanılarak herhangi bir ürünün verileri ekrana getiriliyor
        {
            int secilen = starbuckseditpageDataGridView.SelectedCells[0].RowIndex;
            ProductID.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[0].Value.ToString();
            stareditpageType.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[1].Value.ToString();
            stareditpageName.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[2].Value.ToString();
            stareditpageHC.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[3].Value.ToString();
            stareditpageContent.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[4].Value.ToString();
            stareditpagePrice.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[5].Value.ToString();
            stareditpageStock.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[6].Value.ToString();
            stareditpageDescription.Text = starbuckseditpageDataGridView.Rows[secilen].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
