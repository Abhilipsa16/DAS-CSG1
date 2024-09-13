using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e) {
            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else {
                timer1.Stop();

                //richTextBox1.Show("Successfull");
            }
        }

        private void btn_closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
