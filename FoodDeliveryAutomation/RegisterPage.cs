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

namespace FoodDeliveryAutomation
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        SqlConnection connectionRegister = new SqlConnection("Data Source=VIDENTE\\SQLEXPRESS;Initial Catalog=YemeksepetiAutomation1;Integrated Security=True"); // database bağlantı satırı

        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e) // bu kod satırı girilen bilgilerle veritabanı arasında bağlantı kurarak üyeleri kaydedecektir.
        {

            // girilen isim,parola,posta ve adres bilgileri addwithvalue tekniği ile veritabanına aktarılıyor
            connectionRegister.Open(); 
            cmd = new SqlCommand("sp_RegisterAUser", connectionRegister);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@isim", registerIsimText.Text);
            cmd.Parameters.AddWithValue("@parola", registerParolaText.Text);
            cmd.Parameters.AddWithValue("@posta", registerPostaText.Text);
            cmd.Parameters.AddWithValue("@adres", registerAdresText.Text);
            cmd.ExecuteNonQuery();
            connectionRegister.Close();
            MessageBox.Show("Başarıyla sisteme kayıt oldunuz...");
            this.Close();
            MainPage uye = new MainPage();
            uye.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void isim_Click(object sender, EventArgs e)
        {

        }
    }
}
