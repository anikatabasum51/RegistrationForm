namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.name = textBox1.Text;
            form.roll = textBox2.Text;
            form.regid = textBox3.Text;
            form.semester = textBox4.Text;
            form.bloodgroup = textBox5.Text;
            form.gender = comboBox1.Text;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

