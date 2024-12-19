namespace _8_Ornek
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
            btnEkle = new Button();
            lstOgrenciler = new ListBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(62, 112);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 26);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstOgrenciler
            // 
            lstOgrenciler.FormattingEnabled = true;
            lstOgrenciler.ItemHeight = 15;
            lstOgrenciler.Location = new Point(62, 12);
            lstOgrenciler.Name = "lstOgrenciler";
            lstOgrenciler.Size = new Size(120, 94);
            lstOgrenciler.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 199);
            Controls.Add(lstOgrenciler);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        public ListBox lstOgrenciler;
    }
}
