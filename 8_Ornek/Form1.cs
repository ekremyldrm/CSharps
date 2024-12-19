namespace _8_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            // this => mevcut instance ifade eder
            Form2 frm = new Form2();
            frm.mainForm = this;
            frm.ShowDialog();     
        }
    }
}