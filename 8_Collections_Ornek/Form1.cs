namespace _8_Collections_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ogrenciler = new string[0];
        private void btnEkleArray_Click(object sender, EventArgs e)
        {
            Array.Resize(ref ogrenciler, ogrenciler.Length + 1);
            ogrenciler[ogrenciler.Length - 1] = txtAdi.Text;
        }

        // liste yapısında studens değişkenin coun'ı 0'dır...
        List<string> students = new List<string>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            students.Add(txtAdi.Text); // add index açar ve elemanı ekler..
        }

        private void btnGosterList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            students.Sort(); // SIRALA...
            foreach (string s in students)
                listBox1.Items.Add(s);
        }

        private void btnGosterArray_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(ogrenciler);
            foreach (string o in ogrenciler)
                listBox1.Items.Add(o); 
        }
    }
}