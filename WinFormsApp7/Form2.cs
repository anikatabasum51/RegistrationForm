using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        public string name { get; set; }
        public string roll { get; set; }
        public string regid { get; set; }
        public string semester { get; set; }
        public string bloodgroup { get; set; }
        public string gender { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = name;
            label2.Text = roll;
            label3.Text = regid;
            label4.Text = semester;
            label5.Text = bloodgroup;
            label6.Text = gender;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
