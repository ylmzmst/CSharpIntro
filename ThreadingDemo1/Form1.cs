namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProccess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iþlem1 çalýþtý");
        }

        private void btnProccess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iþlem2 çalýþtý");
        }
    }
}
