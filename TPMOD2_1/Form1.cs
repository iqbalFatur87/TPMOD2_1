namespace TPMOD2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button Submit mengambil data dari textbox
            string submit = textBox1.Text;
            
            //Label akan muncul text ketika telah disubmit
            label1.Text = submit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}