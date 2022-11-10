using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(text1.Text);
            int so2 = Convert.ToInt32(text2.Text);
            Calculation c = new Calculation(so1, so2);
            text3.Text = c.Execute("+").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(text1.Text);
            int so2 = Convert.ToInt32(text2.Text);
            Calculation c = new Calculation(so1, so2);
            text3.Text = c.Execute("-").ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(text1.Text);
            int so2 = Convert.ToInt32(text2.Text);
            Calculation c = new Calculation(so1, so2);
            text3.Text = c.Execute("*").ToString(); 
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(text1.Text);
            int so2 = Convert.ToInt32(text2.Text);
            Calculation c = new Calculation(so1, so2);
            text3.Text = c.Execute("/").ToString();
        }

        
    }
}
