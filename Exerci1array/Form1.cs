namespace Exerci1array
{
    public partial class Form1 : Form
    {
        string[] Nome = new string[3];
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (Nome[0] == null)
            {

                Nome[0] = txtnome.Text;

            }
            else if (Nome[1] == txtnome.Text || Nome[0] == txtnome.Text || Nome[2] == txtnome.Text)
            {
                MessageBox.Show("Escreva outro nome");

            }

            else if (Nome[1] == null)
            {
                Nome[1] = txtnome.Text;
            }
            else if (Nome[2] == null)
            {
                Nome[2] = txtnome.Text;

            }
            else
            {
                MessageBox.Show(Nome[0] + "\n" + Nome[1] + "\n" + Nome[2]);

            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Nome[0] = null;
            Nome[1] = null;
            Nome[2] = null;
            txtnome.Text = null;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Nome[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Nome[1]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Nome[2]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
