using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Ornek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string a;
        public Form1 mainForm;
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            Test t = new Test();
            t.Adi = "dsadas";

            //Form1 frm = new Form1(); BİZ YENİ BİR İNSTANCE DEĞİL MEVCUT İNSTANCEİ KULLANMAMIZ GEREKİR...

            mainForm.lstOgrenciler.Items.Add(txtAdi.Text);

            txtAdi.Clear(); // textboxin textini temizle...
            txtAdi.Focus();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
