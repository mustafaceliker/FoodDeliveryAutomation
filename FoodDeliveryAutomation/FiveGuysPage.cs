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
    public partial class FiveGuysPage : Form
    {
        public FiveGuysPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // bu sayfadaki herhangi bir picturebox'a tıklanması durumunda starbucks ürün düzenleme/ekle-sil sayfasına yönlendirme sağlanacaktır.

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            FiveGuysEditPage fiveguysEditPage = new FiveGuysEditPage();
            fiveguysEditPage.Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            FiveGuysEditPage fiveguysEditPage = new FiveGuysEditPage();
            fiveguysEditPage.Show();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            FiveGuysEditPage fiveguysEditPage = new FiveGuysEditPage();
            fiveguysEditPage.Show();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            FiveGuysEditPage fiveguysEditPage = new FiveGuysEditPage();
            fiveguysEditPage.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FiveGuysPage_Load(object sender, EventArgs e)
        {

        }
    }
}
