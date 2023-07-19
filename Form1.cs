using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno=0, dogru=0, yanlis = 0;
        

        private void btnB_Click(object sender, EventArgs e)
        {
            btnsonraki.Text = "Sonraki";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            lblcevap.Text = btnB.Text;
            if (lblcevap.Text==lbldogru.Text)
            {
                dogru++;
                lbldogrusayisi.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblyanlissayisi.Text = yanlis.ToString();
            }
            
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnsonraki.Text = "Sonraki";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            lblcevap.Text = btnD.Text;
            if (lblcevap.Text==lbldogru.Text)
            {
                dogru++;
                lbldogrusayisi.Text=dogru.ToString();
            }
            else
            {
                yanlis++;
                lblyanlissayisi.Text=(yanlis.ToString());   
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnsonraki.Text = "Sonraki";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            lblcevap.Text = btnC.Text;
            if (lblcevap.Text==lbldogru.Text)
            {
                dogru++;
                lbldogrusayisi.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblyanlissayisi.Text=yanlis.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnsonraki.Text = "Başlat";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnsonraki.Text = "Sonraki";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            lblcevap.Text = btnA.Text;
            if (lblcevap.Text==lbldogru.Text)
            {
                dogru++;
                lbldogrusayisi.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblyanlissayisi.Text = yanlis.ToString();
            }
        }
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;
            soruno++;
            lblsoruno.Text=soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Türkiyenin başkenti neresidir?";
                btnA.Text = "Ankara";
                btnB.Text= "İstanbul";
                btnC.Text = "İzmir";
                btnD.Text = "Bursa";
                lbldogru.Text = "Ankara";

            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Atatürk hangi yıl doğmuştur?";
                btnA.Text = "1880";
                btnB.Text = "1881";
                btnC.Text = "1886";
                btnD.Text = "1890";
                lbldogru.Text = "1881";

            }
            if (soruno==3)
            {
                richTextBox1.Text = "Sarı ve mavi rengin karışımından hangi renk elde edilir?";

                btnA.Text = "Mor";
                btnB.Text = "Kırmızı";
                btnC.Text = "Koyu Sarı";
                btnD.Text = "Yeşil";
                lbldogru.Text = "Yeşil";
               

            }
            if (soruno==4)
            {
                richTextBox1.Text = "Suyun kaynama noktası kaç derecedir?";
                btnA.Text = "120";
                btnB.Text = "130";
                btnC.Text = "100";
                btnD.Text = "110";
                lbldogru.Text = "100";
                btnsonraki.Text = "Sonuçlar";
            }
            if (soruno==5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;
                lblsoruno.Visible = false;
                label3.Visible = false;

                MessageBox.Show("Doğru Sayısı: " + dogru + "\n" + "Yanlış Sayısı: " + yanlis);
            }

            
        }
    }
}
