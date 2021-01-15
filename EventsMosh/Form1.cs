using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsMosh
{
    public partial class Form1 : Form
    {
        MailService mailService = new MailService();
        MessageService messageService = new MessageService();
        VideoEncoder encoder = new VideoEncoder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lastArrayIndex = textBox1.Text.Split('\\').Length - 1;
            string videoTitle = textBox1.Text.Split('\\')[lastArrayIndex];

            Video video = new Video { FileName = textBox1.Text,
                Title =  videoTitle};
            encoder.Encode(video);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


    }
}
