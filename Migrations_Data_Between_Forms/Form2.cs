using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migrations_Data_Between_Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string message1,message2,message3;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = message1;
            label2.Text = message2;
            comboBox1.Text = message3;
        }
    }
}
