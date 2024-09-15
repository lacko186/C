using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sajat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator gwn = new QRCoder.QRCodeGenerator();
            var qradat = QRCodeGenerator.GenerateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.H);
            var qrcode = new QRCoder.QRCode(qradat);
            var image = qrcode.GetGraphic(8);
            pictureBox1.Image = image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            label1.ForeColor = Color.White;
            BackColor = Color.Black;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;

            BackColor = Color.White;
        }
    }
}
