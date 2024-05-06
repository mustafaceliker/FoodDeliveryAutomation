using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryAutomation
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            ShowLabel.Text ="Hoşgeldiniz "+ MainPage.gidenVeri.ToString() + ",sizi gördüğümüze sevindik. Lütfen aşağıdan sipariş vermek istediğiniz restorantı seçiniz."; 
            //Sisteme giriş yapan kullanıcıya karşılama mesajı giriş yapılan mail ile veriliyor.
        }

        private void ShowLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FiveGuysOrderPage fiveguysorderPage = new FiveGuysOrderPage();
            fiveguysorderPage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StarbucksOrderPage starbucksorderPage = new StarbucksOrderPage();
            starbucksorderPage.Show();
        }
    }
    
}
