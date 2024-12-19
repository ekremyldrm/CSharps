namespace _8_Collections_Ornek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            txtAdi = new TextBox();
            btnEkle = new Button();
            btnEkleArray = new Button();
            btnGosterList = new Button();
            btnGosterArray = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(55, 177);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(55, 12);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(152, 23);
            txtAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(42, 44);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(101, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle List";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnEkleArray
            // 
            btnEkleArray.Location = new Point(149, 44);
            btnEkleArray.Name = "btnEkleArray";
            btnEkleArray.Size = new Size(76, 23);
            btnEkleArray.TabIndex = 3;
            btnEkleArray.Text = "Ekle Array";
            btnEkleArray.UseVisualStyleBackColor = true;
            btnEkleArray.Click += btnEkleArray_Click;
            // 
            // btnGosterList
            // 
            btnGosterList.Location = new Point(12, 138);
            btnGosterList.Name = "btnGosterList";
            btnGosterList.Size = new Size(95, 23);
            btnGosterList.TabIndex = 4;
            btnGosterList.Text = "List Goster";
            btnGosterList.UseVisualStyleBackColor = true;
            btnGosterList.Click += btnGosterList_Click;
            // 
            // btnGosterArray
            // 
            btnGosterArray.Location = new Point(125, 136);
            btnGosterArray.Name = "btnGosterArray";
            btnGosterArray.Size = new Size(110, 23);
            btnGosterArray.TabIndex = 5;
            btnGosterArray.Text = "Array Göster";
            btnGosterArray.UseVisualStyleBackColor = true;
            btnGosterArray.Click += btnGosterArray_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 406);
            Controls.Add(btnGosterArray);
            Controls.Add(btnGosterList);
            Controls.Add(btnEkleArray);
            Controls.Add(btnEkle);
            Controls.Add(txtAdi);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox txtAdi;
        private Button btnEkle;
        private Button btnEkleArray;
        private Button btnGosterList;
        private Button btnGosterArray;
    }
}
