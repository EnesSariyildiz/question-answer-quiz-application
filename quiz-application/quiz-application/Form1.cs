using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;



            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;

            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;



            soruNo++;
            LblSoruNo.Text = soruNo.ToString();
            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında kuruldu ?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            else if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il ege bölgemizde bulunmaz ?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            else if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir ?";
                BtnA.Text = "Sait Faik Abasıyanık";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Attila İlhan";
                BtnD.Text = "Reşat Nuri Güntekin";
                label4.Text = "Sait Faik Abasıyanık";
                BtnSonraki.Text = "Sonuçlar";
            }
            else if (soruNo == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;

                MessageBox.Show(dogru + " Doğru "+ Environment.NewLine + yanlis + " Yanlış ");
            }
        }
    }
}
