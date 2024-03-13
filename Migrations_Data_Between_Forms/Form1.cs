using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Migrations_Data_Between_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr=new Form2();
            fr.message1=textBox1.Text;
            fr.message2=textBox2.Text;
            fr.message3= textBox3.Text;
            fr.Show();

           

            this.Hide();
        }
    }
}
