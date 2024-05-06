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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          

            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            StarbucksPage starbucksPage = new StarbucksPage(); // bu picturebox'a tıklanmasıyla starbucks yönetim sayfasına gidilecektir
            starbucksPage.Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            FiveGuysPage fiveGuysPage = new FiveGuysPage(); // bu picturebox'a tıklanmasıyla fiveguys yönetim sayfasına gidilecektir
            fiveGuysPage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
