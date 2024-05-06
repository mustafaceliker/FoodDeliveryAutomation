using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodDeliveryAutomation
{
    public partial class FiveGuysEditPage : Form
    {
        SqlConnection dataconnection = new SqlConnection("Data Source=VIDENTE\\SQLEXPRESS;Initial Catalog=YemeksepetiAutomation1;Integrated Security=True"); // veritabanı bağlantı satırı
        SqlCommand command;
        SqlDataReader reader;

        public FiveGuysEditPage()
        {
            InitializeComponent();


        }

        private void button5_Click(object sender, EventArgs e) // bu butona basılması durumunda ürün silinecektir. burada mantık ID'e göre silmektir çünkü ID primary key olduğundan hep farklı olacaktır.
        {
            dataconnection.Open();

            SqlCommand komutSil = new SqlCommand("Delete from tbl_FiveGuysDatabase where ProductID=@s1", dataconnection);
            komutSil.Parameters.AddWithValue("@s1", ProductID.Text);
            komutSil.ExecuteNonQuery();

            dataconnection.Close();
            MessageBox.Show("Five Guys Ürün Silme İşlemi Başarılı!");
            this.tbl_FiveGuysDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet.tbl_FiveGuysDatabase);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FiveGuysEditPage_Load(object sender, EventArgs e)
        {
            
        }

        private void fiveguyseditpageDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void fiveguyseditpageDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fiveguyseditpageDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)  // datagridview'in mouse double click eventi kullanılarak herhangi bir ürünün verileri ekrana getiriliyor
        {
            int secilen = fiveguyseditpageDataGridView.SelectedCells[0].RowIndex;
            ProductID.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[0].Value.ToString();
            fiveguyseditpageType1.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[1].Value.ToString();
            fiveguyseditpageName.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[2].Value.ToString();
            fiveguyseditpageHC.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[3].Value.ToString();
            fiveguyseditpageContent.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[4].Value.ToString();
            fiveguyseditpagePrice.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[5].Value.ToString();
            fiveguyseditpageStock.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[6].Value.ToString();
            fiveguyseditpageDescription.Text = fiveguyseditpageDataGridView.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e) // bu butona basılması durumunda girilen verilerle ürün ekleme işlemi yapılacaktır, mantık olarak dönemin başında derste yaptığımız uygulama baz alınmıştır.
        {
            dataconnection.Open();

            SqlCommand komut = new SqlCommand("insert into tbl_FiveGuysDatabase(ProductType, ProductName, ProductHeat, ProductContent, ProductPrice, ProductStock," +
            "ProductDescription)" +
            "values (@a1,@a2,@a3,@a4,@a5,@a6,@a7)", dataconnection);
            komut.Parameters.AddWithValue("@a1", fiveguyseditpageType1.Text);
            komut.Parameters.AddWithValue("@a2", fiveguyseditpageName.Text);
            komut.Parameters.AddWithValue("@a3", fiveguyseditpageHC.Text);
            komut.Parameters.AddWithValue("@a4", fiveguyseditpageContent.Text);
            komut.Parameters.AddWithValue("@a5", fiveguyseditpagePrice.Text);
            komut.Parameters.AddWithValue("@a6", fiveguyseditpageStock.Text);
            komut.Parameters.AddWithValue("@a7", fiveguyseditpageDescription.Text);
            komut.ExecuteNonQuery();

            dataconnection.Close();
            MessageBox.Show("Five Guys Ürün Kaydı Başarılı Şekilde Oluşturuldu!");
            this.tbl_FiveGuysDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet.tbl_FiveGuysDatabase);
        }

        private void button9_Click(object sender, EventArgs e) // bu butona basılması durumunda veritabanından tüm bilgiler datagridview'a çekilecektir.
        {
            this.tbl_FiveGuysDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet.tbl_FiveGuysDatabase);
        }

        private void button8_Click(object sender, EventArgs e) // bu buton textboxladaki verileri temizlemeye yarıyor, her box " " yani boş şekilde değiştiriliyor.
        {
            ProductID.Text = "";
            fiveguyseditpageType1.Text = "";
            fiveguyseditpageName.Text = "";
            fiveguyseditpageContent.Text = "";
            fiveguyseditpagePrice.Text = "";
            fiveguyseditpageStock.Text = "";
            fiveguyseditpageHC.Text = "";
            fiveguyseditpageDescription.Text = "";
            MessageBox.Show("Five Guys Ürün Verileri Temizlendi!");
            this.tbl_FiveGuysDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet.tbl_FiveGuysDatabase);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) // bu butona basılması durumunda ürün bilgileri güncelleniyor
        {
            dataconnection.Open();
            string kayit = "Update tbl_FiveguysDatabase Set ProductType = @g1, ProductName = @g2, ProductHeat = @g3," +
            "ProductContent=@g4, ProductPrice=@g5, ProductStock=@g6,ProductDescription=@g7 where ProductID=@g8";
            // ürün tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, dataconnection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@g1", fiveguyseditpageType.Text);
            komut.Parameters.AddWithValue("@g2", fiveguyseditpageName.Text);
            komut.Parameters.AddWithValue("@g3", fiveguyseditpageHC.Text);
            komut.Parameters.AddWithValue("@g4", fiveguyseditpageContent.Text);
            komut.Parameters.AddWithValue("@g5", fiveguyseditpagePrice.Text);
            komut.Parameters.AddWithValue("@g6", fiveguyseditpageStock.Text);
            komut.Parameters.AddWithValue("@g7", fiveguyseditpageDescription.Text);
            komut.Parameters.AddWithValue("@g8", ProductID.Text);
            // parametrelere form üzerindeki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            // veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor
            dataconnection.Close();
            MessageBox.Show("FiveGuys Ürün Bilgileri Güncellendi.");
            this.tbl_FiveGuysDatabaseTableAdapter.Fill(this.yemeksepetiAutomation1DataSet.tbl_FiveGuysDatabase);

        }
    }
}
