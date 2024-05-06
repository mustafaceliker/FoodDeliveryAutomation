using FoodDeliveryAutomation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FoodDeliveryAutomation
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public static string gidenVeri = "";
        SqlConnection baglantiLogin = new SqlConnection("Data Source=VIDENTE\\SQLEXPRESS;Initial Catalog=YemeksepetiAutomation1;Integrated Security=True"); // veritabanı bağlantı satırı

        SqlCommand command;
        SqlDataReader reader;
        int girisTuru;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();

        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (MainPagePostaText.Text=="" || MainPageParolaText.Text=="") // bilgi alanlarının boş olup olmadığını ve giriş kısmında veritabanındaki üye bilgileriyle uyuşma kontrol edecek if-else bloğu
            {
                MessageBox.Show("Bu alanlardan herhangi birisi boş olamaz");
            }
            else
            {


                baglantiLogin.Open();
                command = new SqlCommand("sp_UyeGirisi", baglantiLogin);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@posta", SqlDbType.VarChar, 50).Value = MainPagePostaText.Text;
                command.Parameters.Add("@parola", SqlDbType.VarChar, 50).Value = MainPageParolaText.Text;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    gidenVeri = MainPagePostaText.Text;
                    MessageBox.Show("Kullanıcı, isteme giriş başarılı...");
                    UserMenu satinAl = new UserMenu();
                    satinAl.ShowDialog();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Postanız veya parola bilginiz hatalı...");

                }
                baglantiLogin.Close();
                

            }

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainPagePostaText2.Text == "star" && MainPageParolaText2.Text == "admin") // starbucks sayfa yöneticisinin giriş yapması için gerekli kullanıcı adı şifresini girmesi durumunda kontrol edecek if-else kontrol bloğu
            {
                girisTuru=1;
                
                MessageBox.Show("Admin, sisteme giriş başarılı...");
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.pictureBox2.Visible = false;
                adminMenu.Show();
                this.Hide();
              

            }
              else if (MainPagePostaText2.Text == "five" && MainPageParolaText2.Text == "admin") // fiveguys sayfa yöneticisinin giriş yapması için gerekli kullanıcı adı şifresini girmesi durumunda kontrol edecek if-else kontrol bloğu
            {
                girisTuru=0;
                MessageBox.Show("Admin, sisteme giriş başarılı...");
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.pictureBox1.Visible = false;
                adminMenu.Show();
                this.Hide();


              }
              else
              {
              MessageBox.Show("Girdiğiniz bilgiler hatalı, kontrol ediniz."); // diğer durumlarda bilgilerin hatalı olduğunu gösterecek else bloğu
              }
        }

        private void txtParola_CheckedChanged(object sender, EventArgs e)
        {
          

            
        }

        private void MainPagePostaText2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

