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
    public partial class StarbucksPage : Form
    {
        public StarbucksPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StarbucksPage_Load(object sender, EventArgs e)
        {

        }

        // bu sayfadaki herhangi bir picturebox'a tıklanması durumunda starbucks ürün düzenleme/ekle-sil sayfasına yönlendirme sağlanacaktır.

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            StarbucksEditPage starbucksEditPage = new StarbucksEditPage();
            starbucksEditPage.Show();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            StarbucksEditPage starbucksEditPage = new StarbucksEditPage();
            starbucksEditPage.Show();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            StarbucksEditPage starbucksEditPage = new StarbucksEditPage();
            starbucksEditPage.Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            StarbucksEditPage starbucksEditPage = new StarbucksEditPage();
            starbucksEditPage.Show();
        }
    }
}
